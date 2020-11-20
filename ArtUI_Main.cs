using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using DarkUI.Forms;

namespace ArtNetManager
{
    public partial class ArtUI_Main : DarkForm
    {
        public ArtNetManager artnetManager;

        public Panel clientWindow;

        private Timer updateTimer { get; set; }
        private ArtNetPacket packet { get; set; }
        private ArtNetPacket lastPacket { get; set; }

        public ArtUI_Main()
        {
            InitializeComponent();

            BackColor = Color.Black;
            Text = "ArtManager";

            clientWindow = new Panel();
            clientWindow.BackColor = Color.Black;
            clientWindow.Location = new Point(0, darkMenuStrip.Size.Height);
            Controls.Add(clientWindow);
            ResizeClient();

            artnetManager = new ArtNetManager();

            artnetManager.RecordMode = false;
            artnetManager.DebugDataReceived += ArtNetManager_DebugDataReceived;
            artnetManager.RecorderDataReceived += ArtNetManager_RecorderDataReceived;

            VerboseModeUpdateStatus(verboseToolStripMenuItem.Checked);
            RecordModeUpdateStatus(recordToolStripMenuItem.Checked);

            toolStripStatusLabel4.Spring = true;

            artnetManager.Start();
            Start(250);
        }

        public void Start(int interval)
        {
            updateTimer = new Timer();
            updateTimer.Interval = interval;
            updateTimer.Tick += new EventHandler(VerboseModeUpdateStatus);
            updateTimer.Start();
        }

        public void ResizeClient()
        {
            clientWindow.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void VerboseModeUpdateStatus(object sender, EventArgs e)
        {
            if (verboseToolStripMenuItem.Checked)
            {
                if (packet != null)
                {
                    toolStripStatusLabel1.Text = packet.IsValid ? "PACKET VALID" : "PACKET INVALID";
                    toolStripStatusLabel2.Text = string.Format("COUNT [{0,10}]", packet.Index);
                    if (lastPacket != null)
                    {
                        long fps = packet.Index - lastPacket.Index;
                        toolStripStatusLabel3.Text = string.Format("PPS [{0,6}]", fps * 4);
                    }
                    darkStatusStrip.Refresh();
                    lastPacket = packet;
                }
                else
                {
                    toolStripStatusLabel1.Text = "NO UDP STREAM";
                }
            }
        }

        void ArtNetManager_DebugDataReceived(object sender, ArtNetPacket packet)
        {
            this.packet = packet;
        }

        void ArtNetManager_RecorderDataReceived(object sender, ArtNetPacket packet)
        {
        }
        private void ArtNet_UI_Main_SizeChanged(object sender, EventArgs e)
        {
            ResizeClient();
        }

        private void VerboseModeUpdateStatus(bool status)
        {
            if (!status)
            {
                toolStripStatusLabel1.Text = string.Format("VERBOSE MODE: FALSE");
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel3.Text = "";
            }
            else
            {
            }
            this.darkStatusStrip.Refresh();
            artnetManager.VerboseMode = status;
        }

        private void RecordModeUpdateStatus(bool status)
        {
            if (!status)
            {
                this.toolStripStatusLabel5.Text = string.Format("RECORD MODE: FALSE");
            }
            else
            {
                this.toolStripStatusLabel5.Text = string.Format("RECORDING");
            }
            this.darkStatusStrip.Refresh();
            artnetManager.RecordMode = status;
        }

        private void DialogShow(Form dialog)
        {
            var x = Location.X + (Size.Width - dialog.Size.Width) / 2;
            var y = Location.Y + (Size.Height - dialog.Size.Height) / 2;
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(x, y);
            dialog.ShowDialog();
        }


        public void ProcessSaveToXML(XDocument doc)
        {
            XElement element;

            try
            {
                IEnumerable<XElement> elements = doc.Root.Elements(ArtUI_XML.XML_TAG_CONFIG);
                if (elements.Count() > 0)
                {
                    element = elements.First();
                    element.RemoveAttributes();
                }
                else
                {
                    element = new XElement(ArtUI_XML.XML_TAG_CONFIG);
                    doc.Root.Add(element);
                }
                element.Add(new XAttribute("top", this.Location.Y.ToString()));
                element.Add(new XAttribute("left", this.Location.X.ToString()));
                element.Add(new XAttribute("width", this.Size.Width.ToString()));
                element.Add(new XAttribute("height", this.Size.Height.ToString()));
            }
            catch (Exception)
            {
            }
            ArtUI_XML.SaveToXml(doc);
        }

        public void ProcessLoadFromXML(XDocument doc)
        {
            try
            {
                IEnumerable<XElement> elements = doc.Root.Elements(ArtUI_XML.XML_TAG_CONFIG);
                if (elements.Count() > 0)
                {
                    if (elements.First().HasAttributes)
                    {
                        Location = new Point(Convert.ToInt32(elements.First().Attribute("left").Value), Convert.ToInt32(elements.First().Attribute("top").Value));
                        Size = new Size(Convert.ToInt32(elements.First().Attribute("width").Value), Convert.ToInt32(elements.First().Attribute("height").Value));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ArtUI_Main_Load(object sender, EventArgs e)
        {
            ProcessLoadFromXML(ArtUI_XML.LoadFromXml());
        }

        private void ArtUI_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public static List<ToolStripMenuItem> GetItems(MenuStrip menuStrip)
        {
            List<ToolStripMenuItem> myItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem i in menuStrip.Items)
            {
                GetMenuItems(i, myItems);
            }
            return myItems;
        }

        private static void GetMenuItems(ToolStripMenuItem item, List<ToolStripMenuItem> items)
        {
            items.Add(item);
            foreach (ToolStripItem i in item.DropDownItems)
            {
                if (i is ToolStripMenuItem)
                {
                    GetMenuItems((ToolStripMenuItem)i, items);
                }
            }
        }

        private void nodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogShow(new ArtUI_Nodes(this));
        }

        private void networksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogShow(new ArtUI_Net(this));
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordToolStripMenuItem.Checked = !recordToolStripMenuItem.Checked;
            RecordModeUpdateStatus(recordToolStripMenuItem.Checked);
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogShow(new ArtUI_Config(this));
        }

        private void verboseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verboseToolStripMenuItem.Checked = !verboseToolStripMenuItem.Checked;
            VerboseModeUpdateStatus(verboseToolStripMenuItem.Checked);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessSaveToXML(ArtUI_XML.LoadFromXml());
            Application.Exit();
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogShow(new ArtUI_Path(this));
        }
    }
}
