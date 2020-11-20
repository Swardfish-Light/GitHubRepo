namespace ArtNetManager
{
    partial class ArtUI_Path
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
            this.darkOK = new DarkUI.Controls.DarkButton();
            this.darkLabelPath = new DarkUI.Controls.DarkLabel();
            this.darkPath = new DarkUI.Controls.DarkButton();
            this.darkLabelFile = new DarkUI.Controls.DarkLabel();
            this.darkTextFile = new DarkUI.Controls.DarkTextBox();
            this.darkCancel = new DarkUI.Controls.DarkButton();
            this.darkTextPath = new DarkUI.Controls.DarkTextBox();
            this.SuspendLayout();
            // 
            // darkOK
            // 
            this.darkOK.Location = new System.Drawing.Point(552, 92);
            this.darkOK.Name = "darkOK";
            this.darkOK.Padding = new System.Windows.Forms.Padding(5);
            this.darkOK.Size = new System.Drawing.Size(75, 23);
            this.darkOK.TabIndex = 29;
            this.darkOK.Text = "OK";
            this.darkOK.Click += new System.EventHandler(this.darkOK_Click);
            // 
            // darkLabelPath
            // 
            this.darkLabelPath.AutoSize = true;
            this.darkLabelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabelPath.Location = new System.Drawing.Point(12, 32);
            this.darkLabelPath.Name = "darkLabelPath";
            this.darkLabelPath.Size = new System.Drawing.Size(32, 13);
            this.darkLabelPath.TabIndex = 31;
            this.darkLabelPath.Text = "Path:";
            // 
            // darkPath
            // 
            this.darkPath.Location = new System.Drawing.Point(390, 92);
            this.darkPath.Name = "darkPath";
            this.darkPath.Padding = new System.Windows.Forms.Padding(5);
            this.darkPath.Size = new System.Drawing.Size(75, 23);
            this.darkPath.TabIndex = 33;
            this.darkPath.Text = "Path";
            this.darkPath.Click += new System.EventHandler(this.darkPath_Click);
            // 
            // darkLabelFile
            // 
            this.darkLabelFile.AutoSize = true;
            this.darkLabelFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabelFile.Location = new System.Drawing.Point(12, 58);
            this.darkLabelFile.Name = "darkLabelFile";
            this.darkLabelFile.Size = new System.Drawing.Size(26, 13);
            this.darkLabelFile.TabIndex = 35;
            this.darkLabelFile.Text = "File:";
            // 
            // darkTextFile
            // 
            this.darkTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextFile.Location = new System.Drawing.Point(54, 56);
            this.darkTextFile.Name = "darkTextFile";
            this.darkTextFile.Size = new System.Drawing.Size(576, 20);
            this.darkTextFile.TabIndex = 36;
            // 
            // darkCancel
            // 
            this.darkCancel.Location = new System.Drawing.Point(471, 92);
            this.darkCancel.Name = "darkCancel";
            this.darkCancel.Padding = new System.Windows.Forms.Padding(5);
            this.darkCancel.Size = new System.Drawing.Size(75, 23);
            this.darkCancel.TabIndex = 30;
            this.darkCancel.Text = "Cancel";
            this.darkCancel.Click += new System.EventHandler(this.darkCancel_Click);
            // 
            // darkTextPath
            // 
            this.darkTextPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextPath.Enabled = false;
            this.darkTextPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextPath.Location = new System.Drawing.Point(54, 30);
            this.darkTextPath.Name = "darkTextPath";
            this.darkTextPath.Size = new System.Drawing.Size(576, 20);
            this.darkTextPath.TabIndex = 37;
            // 
            // ArtUI_Path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(645, 127);
            this.Controls.Add(this.darkTextPath);
            this.Controls.Add(this.darkTextFile);
            this.Controls.Add(this.darkLabelFile);
            this.Controls.Add(this.darkPath);
            this.Controls.Add(this.darkLabelPath);
            this.Controls.Add(this.darkCancel);
            this.Controls.Add(this.darkOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArtUI_Path";
            this.Opacity = 0.95D;
            this.Text = "Path";
            this.Load += new System.EventHandler(this.ArtUI_Path_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkButton darkOK;
        private DarkUI.Controls.DarkLabel darkLabelPath;
        private DarkUI.Controls.DarkButton darkPath;
        private DarkUI.Controls.DarkLabel darkLabelFile;
        private DarkUI.Controls.DarkTextBox darkTextFile;
        private DarkUI.Controls.DarkButton darkCancel;
        private DarkUI.Controls.DarkTextBox darkTextPath;
    }
}