namespace ArtNetManager
{
    partial class ArtUI_Config
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtUI_Config));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pix_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pix_Margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pix_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pix_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matrix_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matrix_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darkCancel = new DarkUI.Controls.DarkButton();
            this.darkOK = new DarkUI.Controls.DarkButton();
            this.darkRemove = new DarkUI.Controls.DarkButton();
            this.darkLabel = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enabled,
            this.Pix_Size,
            this.Pix_Margin,
            this.Pix_H,
            this.Pix_V,
            this.Matrix_H,
            this.Matrix_V,
            this.Net,
            this.Subnet,
            this.Ports});
            this.dataGridView.Location = new System.Drawing.Point(12, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(692, 244);
            this.dataGridView.TabIndex = 29;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // Enabled
            // 
            this.Enabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.Name = "Enabled";
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Enabled.Width = 71;
            // 
            // Pix_Size
            // 
            this.Pix_Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.NullValue = null;
            this.Pix_Size.DefaultCellStyle = dataGridViewCellStyle1;
            this.Pix_Size.HeaderText = "Pix.Size";
            this.Pix_Size.Name = "Pix_Size";
            this.Pix_Size.Width = 64;
            // 
            // Pix_Margin
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Pix_Margin.DefaultCellStyle = dataGridViewCellStyle2;
            this.Pix_Margin.HeaderText = "Pix.Margin";
            this.Pix_Margin.Name = "Pix_Margin";
            this.Pix_Margin.Width = 64;
            // 
            // Pix_H
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Pix_H.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pix_H.HeaderText = "Pix.H";
            this.Pix_H.Name = "Pix_H";
            this.Pix_H.Width = 64;
            // 
            // Pix_V
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.Pix_V.DefaultCellStyle = dataGridViewCellStyle4;
            this.Pix_V.HeaderText = "Pix.V";
            this.Pix_V.Name = "Pix_V";
            this.Pix_V.Width = 64;
            // 
            // Matrix_H
            // 
            dataGridViewCellStyle5.NullValue = null;
            this.Matrix_H.DefaultCellStyle = dataGridViewCellStyle5;
            this.Matrix_H.HeaderText = "Matrix.H";
            this.Matrix_H.Name = "Matrix_H";
            this.Matrix_H.Width = 64;
            // 
            // Matrix_V
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.Matrix_V.DefaultCellStyle = dataGridViewCellStyle6;
            this.Matrix_V.HeaderText = "Matrix.V";
            this.Matrix_V.Name = "Matrix_V";
            this.Matrix_V.Width = 64;
            // 
            // Net
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = null;
            this.Net.DefaultCellStyle = dataGridViewCellStyle7;
            this.Net.HeaderText = "Net";
            this.Net.Name = "Net";
            this.Net.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Net.Width = 64;
            // 
            // Subnet
            // 
            this.Subnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.NullValue = null;
            this.Subnet.DefaultCellStyle = dataGridViewCellStyle8;
            this.Subnet.FillWeight = 64F;
            this.Subnet.HeaderText = "Subnet";
            this.Subnet.Name = "Subnet";
            this.Subnet.Width = 64;
            // 
            // Ports
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.NullValue = null;
            this.Ports.DefaultCellStyle = dataGridViewCellStyle9;
            this.Ports.FillWeight = 64F;
            this.Ports.HeaderText = "Ports";
            this.Ports.Name = "Ports";
            this.Ports.Width = 64;
            // 
            // darkCancel
            // 
            this.darkCancel.Location = new System.Drawing.Point(723, 218);
            this.darkCancel.Name = "darkCancel";
            this.darkCancel.Padding = new System.Windows.Forms.Padding(5);
            this.darkCancel.Size = new System.Drawing.Size(75, 23);
            this.darkCancel.TabIndex = 33;
            this.darkCancel.Text = "Cancel";
            this.darkCancel.Click += new System.EventHandler(this.darkCancel_Click);
            // 
            // darkOK
            // 
            this.darkOK.Location = new System.Drawing.Point(723, 247);
            this.darkOK.Name = "darkOK";
            this.darkOK.Padding = new System.Windows.Forms.Padding(5);
            this.darkOK.Size = new System.Drawing.Size(75, 23);
            this.darkOK.TabIndex = 32;
            this.darkOK.Text = "OK";
            this.darkOK.Click += new System.EventHandler(this.darkOK_Click);
            // 
            // darkRemove
            // 
            this.darkRemove.Location = new System.Drawing.Point(723, 180);
            this.darkRemove.Name = "darkRemove";
            this.darkRemove.Padding = new System.Windows.Forms.Padding(5);
            this.darkRemove.Size = new System.Drawing.Size(75, 23);
            this.darkRemove.TabIndex = 34;
            this.darkRemove.Text = "Remove";
            this.darkRemove.Click += new System.EventHandler(this.darkRemove_Click);
            // 
            // darkLabel
            // 
            this.darkLabel.AutoSize = true;
            this.darkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel.Location = new System.Drawing.Point(13, 9);
            this.darkLabel.Name = "darkLabel";
            this.darkLabel.Size = new System.Drawing.Size(78, 13);
            this.darkLabel.TabIndex = 35;
            this.darkLabel.Text = "List of Matrices";
            // 
            // ArtUI_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(810, 283);
            this.Controls.Add(this.darkLabel);
            this.Controls.Add(this.darkRemove);
            this.Controls.Add(this.darkCancel);
            this.Controls.Add(this.darkOK);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtUI_Config";
            this.Opacity = 0.95D;
            this.Text = "ArtNet Config";
            this.Load += new System.EventHandler(this.ArtUI_Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pix_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pix_Margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pix_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pix_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrix_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrix_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ports;
        private DarkUI.Controls.DarkButton darkCancel;
        private DarkUI.Controls.DarkButton darkOK;
        private DarkUI.Controls.DarkButton darkRemove;
        private DarkUI.Controls.DarkLabel darkLabel;
    }
}