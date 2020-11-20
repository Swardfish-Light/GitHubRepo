using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using System.IO;
using System.Security;
using System.Xml.Linq;

namespace ArtNetManager
{
    public partial class ArtUI_Path : DarkForm
    {
        ArtUI_Main main;
        string path;
        string file;

        public ArtUI_Path(ArtUI_Main main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void darkPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = dialog.SelectedPath;
                    darkTextPath.Text = path;
                }
                catch (SecurityException ex)
                {
                }
            }
        }

        public void ProcessSaveToXML(XDocument doc)
        {
            XElement element;

            try
            {
                element = doc.Root.Element(ArtUI_XML.XML_TAG_PATH);
                if (element==null)
                {
                    element = new XElement(ArtUI_XML.XML_TAG_PATH);
                    doc.Root.Add(element);
                }
                path = darkTextPath.Text;
                element.Value = path;

                element = doc.Root.Element(ArtUI_XML.XML_TAG_FILE);
                if (element == null)
                {
                    element = new XElement(ArtUI_XML.XML_TAG_FILE);
                    doc.Root.Add(element);
                }
                file = darkTextFile.Text;
                element.Value = file;

            }
            catch (Exception)
            {
            }
            ArtUI_XML.SaveToXml(doc);
        }

        public void ProcessLoadFromXML(XDocument doc)
        {
            XElement element;

            try
            {
                element = doc.Root.Element(ArtUI_XML.XML_TAG_PATH);
                if (element != null)
                {
                    darkTextPath.Text = element.Value;
                    path = darkTextPath.Text;
                }

                element = doc.Root.Element(ArtUI_XML.XML_TAG_FILE);
                if (element != null)
                {
                    darkTextFile.Text = element.Value;
                    file = darkTextFile.Text;
                }
            }
            catch (Exception)
            {
            }
        }

        private void darkOK_Click(object sender, EventArgs e)
        {
            ProcessSaveToXML(ArtUI_XML.LoadFromXml());
            Close();
        }

        private void darkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArtUI_Path_Load(object sender, EventArgs e)
        {
            ProcessLoadFromXML(ArtUI_XML.LoadFromXml());
        }

        public string GetFilePath()
        {
            ProcessLoadFromXML(ArtUI_XML.LoadFromXml());
            return path + "\\" + file;
        }
    }
}