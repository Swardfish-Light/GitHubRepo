namespace ArtNetManager
{
    partial class ArtUI_Nodes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtUI_Nodes));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darkCancel = new DarkUI.Controls.DarkButton();
            this.darkOK = new DarkUI.Controls.DarkButton();
            this.darkLabel = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEnabled,
            this.colNet,
            this.colSubnet,
            this.colPorts});
            this.dataGridView.Location = new System.Drawing.Point(12, 31);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(444, 239);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            this.dataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowLeave);
            this.dataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_RowStateChanged);
            // 
            // colEnabled
            // 
            this.colEnabled.FillWeight = 64F;
            this.colEnabled.HeaderText = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.ReadOnly = true;
            this.colEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNet
            // 
            this.colNet.FillWeight = 64F;
            this.colNet.HeaderText = "Net";
            this.colNet.Name = "colNet";
            this.colNet.ReadOnly = true;
            // 
            // colSubnet
            // 
            this.colSubnet.FillWeight = 64F;
            this.colSubnet.HeaderText = "Subnet";
            this.colSubnet.Name = "colSubnet";
            this.colSubnet.ReadOnly = true;
            // 
            // colPorts
            // 
            this.colPorts.FillWeight = 64F;
            this.colPorts.HeaderText = "Ports";
            this.colPorts.Name = "colPorts";
            this.colPorts.ReadOnly = true;
            // 
            // darkCancel
            // 
            this.darkCancel.Location = new System.Drawing.Point(475, 215);
            this.darkCancel.Name = "darkCancel";
            this.darkCancel.Padding = new System.Windows.Forms.Padding(5);
            this.darkCancel.Size = new System.Drawing.Size(75, 23);
            this.darkCancel.TabIndex = 28;
            this.darkCancel.Text = "Cancel";
            this.darkCancel.Click += new System.EventHandler(this.darkCancel_Click);
            // 
            // darkOK
            // 
            this.darkOK.Location = new System.Drawing.Point(475, 244);
            this.darkOK.Name = "darkOK";
            this.darkOK.Padding = new System.Windows.Forms.Padding(5);
            this.darkOK.Size = new System.Drawing.Size(75, 23);
            this.darkOK.TabIndex = 27;
            this.darkOK.Text = "OK";
            this.darkOK.Click += new System.EventHandler(this.darkOK_Click);
            // 
            // darkLabel
            // 
            this.darkLabel.AutoSize = true;
            this.darkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel.Location = new System.Drawing.Point(13, 12);
            this.darkLabel.Name = "darkLabel";
            this.darkLabel.Size = new System.Drawing.Size(102, 13);
            this.darkLabel.TabIndex = 29;
            this.darkLabel.Text = "List of ArtNet Nodes";
            // 
            // ArtUI_Nodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(562, 281);
            this.Controls.Add(this.darkLabel);
            this.Controls.Add(this.darkCancel);
            this.Controls.Add(this.darkOK);
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtUI_Nodes";
            this.Opacity = 0.95D;
            this.Text = "ArtNet Nodes";
            this.Load += new System.EventHandler(this.ArtUI_Nodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorts;
        private DarkUI.Controls.DarkButton darkCancel;
        private DarkUI.Controls.DarkButton darkOK;
        private DarkUI.Controls.DarkLabel darkLabel;
    }
}