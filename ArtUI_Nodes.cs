using System;
using System.Windows.Forms;
using DarkUI.Forms;

namespace ArtNetManager
{
    public partial class ArtUI_Nodes : DarkForm
    {
        ArtUI_Main main;
        bool isClosing = false;

        public ArtUI_Nodes(ArtUI_Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellEnabled;
            DataGridViewCell cellNet;
            DataGridViewCell cellSubnet;
            DataGridViewCell cellPorts;

            int net = -1;
            int subnet = -1;
            int ports = -1;

            if (e.RowIndex >= 0)
            {
                cellEnabled = dataGridView.Rows[e.RowIndex].Cells[0];
                cellNet = dataGridView.Rows[e.RowIndex].Cells[1];
                cellSubnet = dataGridView.Rows[e.RowIndex].Cells[2];
                cellPorts = dataGridView.Rows[e.RowIndex].Cells[3];

                if ((cellNet.Value != System.DBNull.Value))
                {
                    net = Convert.ToInt32(cellNet.Value);
                }

                if ((cellSubnet.Value != System.DBNull.Value))
                {
                    subnet = Convert.ToInt32(cellSubnet.Value);
                }

                if ((cellPorts.Value != System.DBNull.Value))
                {
                    ports = Convert.ToInt32(cellPorts.Value);
                }
            }
            SelectionUpdate(e.RowIndex);
        }

        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SelectionUpdate(e.Row.Index);
        }
        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectionUpdate(e.RowIndex);
        }

        private void SelectionUpdate(int rowIndex)
        {
            DataGridViewCell cellNet;
            DataGridViewCell cellSubnet;

            bool selected;

            int net = -1;
            int subnet = -1;

            if ((rowIndex >= 0) && (!isClosing))
            {
                cellNet = dataGridView.Rows[rowIndex].Cells[1];
                cellSubnet = dataGridView.Rows[rowIndex].Cells[2];

                net = Convert.ToInt32(cellNet.Value);
                subnet = Convert.ToInt32(cellSubnet.Value);

                try
                {
                    foreach (Control c in main.clientWindow.Controls)
                    {
                        selected = false;
                        if (c.GetType() == typeof(ArtUI_Matrix))
                        {
                            ArtUI_Matrix matrix = (ArtUI_Matrix)c;
                            selected |= ((matrix.node.Net == net) && (matrix.node.Subnet == subnet));
                            ((ArtUI_Matrix)c).isTagged = selected;
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void SelectionClear()
        {
            foreach (Control c in main.clientWindow.Controls)
            {
                if (c.GetType() == typeof(ArtUI_Matrix))
                {
                    ((ArtUI_Matrix)c).isTagged = false;
                }
            }
        }

        private void ArtUI_Nodes_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            foreach (ArtNetNode node in main.artnetManager.Nodes)
            {
                dataGridView.Rows.Add(true, node.Net, node.Subnet, node.Ports.Count);
            }
        }

        private void dataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Control c in main.clientWindow.Controls)
            {
                if (c.GetType() == typeof(ArtUI_Matrix))
                {
                    ((ArtUI_Matrix)c).isTagged = false;
                }
            }
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

        private void darkCancel_Click(object sender, EventArgs e)
        {
            isClosing = true;
            SelectionClear();
            Close();
        }

        private void darkOK_Click(object sender, EventArgs e)
        {
            isClosing = true;
            SelectionClear();
            Close();
        }
    }
}