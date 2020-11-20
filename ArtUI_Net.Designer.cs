namespace ArtNetManager
{
    partial class ArtUI_Net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtUI_Net));
            this.lbListView = new System.Windows.Forms.Label();
            this.infoListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.darkOK = new DarkUI.Controls.DarkButton();
            this.darkCancel = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // lbListView
            // 
            this.lbListView.AutoSize = true;
            this.lbListView.ForeColor = System.Drawing.Color.White;
            this.lbListView.Location = new System.Drawing.Point(9, 10);
            this.lbListView.Name = "lbListView";
            this.lbListView.Size = new System.Drawing.Size(127, 13);
            this.lbListView.TabIndex = 24;
            this.lbListView.Text = "List of Network interfaces";
            this.lbListView.Click += new System.EventHandler(this.lbListView_Click);
            // 
            // infoListView
            // 
            this.infoListView.BackColor = System.Drawing.Color.Silver;
            this.infoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnIP,
            this.columnStatus});
            this.infoListView.ForeColor = System.Drawing.Color.Black;
            this.infoListView.FullRowSelect = true;
            this.infoListView.GridLines = true;
            this.infoListView.HideSelection = false;
            this.infoListView.Location = new System.Drawing.Point(12, 28);
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(440, 175);
            this.infoListView.TabIndex = 21;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            this.infoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 125;
            // 
            // columnIP
            // 
            this.columnIP.Text = "IP";
            this.columnIP.Width = 123;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Type";
            this.columnStatus.Width = 188;
            // 
            // darkOK
            // 
            this.darkOK.Location = new System.Drawing.Point(464, 178);
            this.darkOK.Name = "darkOK";
            this.darkOK.Padding = new System.Windows.Forms.Padding(5);
            this.darkOK.Size = new System.Drawing.Size(75, 23);
            this.darkOK.TabIndex = 25;
            this.darkOK.Text = "OK";
            this.darkOK.Click += new System.EventHandler(this.darkOK_Click);
            // 
            // darkCancel
            // 
            this.darkCancel.Location = new System.Drawing.Point(464, 149);
            this.darkCancel.Name = "darkCancel";
            this.darkCancel.Padding = new System.Windows.Forms.Padding(5);
            this.darkCancel.Size = new System.Drawing.Size(75, 23);
            this.darkCancel.TabIndex = 26;
            this.darkCancel.Text = "Cancel";
            this.darkCancel.Click += new System.EventHandler(this.darkCancel_Click);
            // 
            // ArtUI_Net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(551, 216);
            this.Controls.Add(this.darkCancel);
            this.Controls.Add(this.darkOK);
            this.Controls.Add(this.lbListView);
            this.Controls.Add(this.infoListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtUI_Net";
            this.Opacity = 0.95D;
            this.Text = "Net";
            this.Load += new System.EventHandler(this.ArtUI_Net_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListView;
        private System.Windows.Forms.ListView infoListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnIP;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private DarkUI.Controls.DarkButton darkOK;
        private DarkUI.Controls.DarkButton darkCancel;
    }
}