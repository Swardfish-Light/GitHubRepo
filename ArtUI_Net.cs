using System;
using System.Windows.Forms;
using DarkUI.Forms;

namespace ArtNetManager
{
    public partial class ArtUI_Net : DarkForm
    {
        ArtUI_Main main;

        public ArtUI_Net(ArtUI_Main main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArtUI_Net_Load(object sender, EventArgs e)
        {
            foreach (ArtNetInterface nic in UdpCommunicator.GetNetworkInterfaces())
            {
                string[] row = { nic.name, nic.ip, nic.status };
                var item = new ListViewItem(row);
                infoListView.Items.Add(item);
            }
        }

        private void darkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void darkOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbListView_Click(object sender, EventArgs e)
        {

        }

        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
    }
}
