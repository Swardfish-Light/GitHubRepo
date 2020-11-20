using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DarkUI.Forms;

namespace ArtNetManager
{
    public partial class ArtUI_Config : DarkForm
    {
        ArtUI_Main main;

        public ArtUI_Config(ArtUI_Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ArtUI_Config_Load(object sender, EventArgs e)
        {
            ProcessLoadFromXml(ArtUI_XML.LoadFromXml());
        }

        private void CreateMatrix()
        {
            bool enabled;
            int pix_Size;
            int pix_Margin;
            int pix_H;
            int pix_V;
            int matrix_H;
            int matrix_V;
            int net;
            int subnet;
            int ports;
            int port;

            main.artnetManager.PauseMode = true;
            main.artnetManager.Nodes.Clear();
            main.clientWindow.Controls.Clear();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    enabled = Convert.ToBoolean(row.Cells["Enabled"].Value);
                    if (enabled)
                    {
                        pix_Size = Convert.ToInt32(row.Cells["Pix_Size"].Value);
                        pix_Margin = Convert.ToInt32(row.Cells["Pix_Margin"].Value);
                        pix_H = Convert.ToInt32(row.Cells["Pix_H"].Value);
                        pix_V = Convert.ToInt32(row.Cells["Pix_V"].Value);
                        matrix_H = Convert.ToInt32(row.Cells["Matrix_H"].Value);
                        matrix_V = Convert.ToInt32(row.Cells["Matrix_V"].Value);
                        net = Convert.ToInt32(row.Cells["Net"].Value);
                        subnet = Convert.ToInt32(row.Cells["Subnet"].Value);
                        ports = Convert.ToInt32(row.Cells["Ports"].Value);

                        ArtNetNode node = new ArtNetNode(net, subnet, ports);
                        main.artnetManager.Nodes.Add(node);

                        port = 0;
                        for (int y = 0; y < matrix_V; y++)
                        {
                            int y1 = y * (pix_V * pix_Size - 1 + pix_Margin) + pix_Margin;

                            for (int x = 0; x < matrix_H; x++)
                            {
                                int x1 = x * (pix_H * pix_Size - 1 + pix_Margin) + pix_Margin;

                                ArtUI_Matrix matrix = new ArtUI_Matrix(node, port++, new Size(pix_H, pix_V), new Point(x1, y1), new Size(pix_Size, pix_Size), Color.Gray);
                                matrix.Create();
                                matrix.Start(ArtUI_Matrix.UPDATE_ULTRA_FAST);
                                main.clientWindow.Controls.Add(matrix);
                            }
                        }
                    }
                }
            }
            main.artnetManager.PauseMode = false;
        }

        private void ProcessSaveToXml(XDocument doc)
        {
            XElement element = null;

            try
            {
                IEnumerable<XElement> elements = doc.Root.Elements(ArtUI_XML.XML_TAG_CONFIG);
                if (elements.Count() > 0)
                {
                    element = elements.First();
                    element.RemoveAll();
                }
                else
                {
                    element = new XElement(ArtUI_XML.XML_TAG_CONFIG);
                    doc.Root.Add(element);
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        IEnumerable<DataGridViewCell> empty = row.Cells
                            .Cast<DataGridViewCell>()
                            .Where(c => c.FormattedValue.ToString() == string.Empty);

                        if (empty.Count() > 0)
                        {
                            row.Cells["Enabled"].Value = false;
                            break;
                        }

                        XElement matrix = new XElement(ArtUI_XML.XML_TAG_MATRIX);
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string columnName = dataGridView.Columns[cell.ColumnIndex].HeaderText;

                            string cellValue = "";
                            if (Convert.ToString(cell.Value) != string.Empty)
                                cellValue = Convert.ToString(cell.Value);

                            XAttribute attr = new XAttribute(columnName, cellValue);
                            matrix.Add(attr);
                        }
                        element.Add(matrix);
                    }
                }

            }
            catch (Exception)
            {
            }
            ArtUI_XML.SaveToXml(doc);
        }

        private void ProcessLoadFromXml(XDocument doc)
        {
            try
            {
                IEnumerable<XElement> elements = doc.Root.Elements(ArtUI_XML.XML_TAG_CONFIG).Elements(ArtUI_XML.XML_TAG_MATRIX);
                foreach (XElement element in elements)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        var readValue = element.Attribute(column.HeaderText).Value;

                        if (row.Cells[column.Index].FormattedValueType.Name.Equals("Boolean"))
                        {
                            if (readValue.ToString() != string.Empty)
                            {
                                row.Cells[column.Index].Value = Convert.ToBoolean(readValue);
                            }
                            else
                            {
                                row.Cells[column.Index].Value = false;
                            }
                        }
                        else
                            row.Cells[column.Index].Value = readValue;
                    }
                    dataGridView.Rows.Add(row);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGridView.Columns[e.ColumnIndex].HeaderText;

            if (dataGridView.Rows[e.RowIndex].IsNewRow
                || headerText.Equals("Enabled"))
            {
                return;
            }

            int i;
            if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {
                NotifyUserAndForceRedo(e, "Must be numeric!");
                return;
            }

            if (Convert.ToInt32(e.FormattedValue) < 0)
            {
                NotifyUserAndForceRedo(e, "Must be positive");
                return;
            }

            switch (headerText)
            {
                case "Pix.Size":
                    if (Convert.ToInt32(e.FormattedValue) < 1)
                        NotifyUserAndForceRedo(e, "Must be >= 1");
                    break;
                case "Net":
                case "Subnet":
                    if (Convert.ToInt32(e.FormattedValue) > 15)
                        NotifyUserAndForceRedo(e, "Must be in range <0..15>");
                    break;
                case "Ports":
                    if ((Convert.ToInt32(e.FormattedValue) > 16) || (Convert.ToInt32(e.FormattedValue) < 1))
                        NotifyUserAndForceRedo(e, "Must be in range <1..16>");
                    break;
                default:
                    break;
            }
        }

        void NotifyUserAndForceRedo(DataGridViewCellValidatingEventArgs e, string message)
        {
            dataGridView.Rows[e.RowIndex].ErrorText = message;
            e.Cancel = true;
        }

        private void darkRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void darkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void darkOK_Click(object sender, EventArgs e)
        {
            ProcessSaveToXml(ArtUI_XML.LoadFromXml());
            CreateMatrix();
            Close();
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
