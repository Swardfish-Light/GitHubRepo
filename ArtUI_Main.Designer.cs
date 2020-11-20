namespace ArtNetManager
{
    partial class ArtUI_Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtUI_Main));
            this.darkStatusStrip = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            this.darkMenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verboseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkStatusStrip.SuspendLayout();
            this.darkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkStatusStrip
            // 
            this.darkStatusStrip.AutoSize = false;
            this.darkStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.darkStatusStrip.Location = new System.Drawing.Point(0, 309);
            this.darkStatusStrip.Name = "darkStatusStrip";
            this.darkStatusStrip.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip.Size = new System.Drawing.Size(630, 28);
            this.darkStatusStrip.SizingGrip = false;
            this.darkStatusStrip.TabIndex = 2;
            this.darkStatusStrip.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 0);
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // darkMenuStrip
            // 
            this.darkMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.darkMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip.Name = "darkMenuStrip";
            this.darkMenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.darkMenuStrip.Size = new System.Drawing.Size(630, 24);
            this.darkMenuStrip.TabIndex = 4;
            this.darkMenuStrip.Text = "darkMenuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.nodesToolStripMenuItem,
            this.networksToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.verboseToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.playToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.playToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playToolStripMenuItem.Image")));
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configToolStripMenuItem.Image")));
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // nodesToolStripMenuItem
            // 
            this.nodesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nodesToolStripMenuItem.Image")));
            this.nodesToolStripMenuItem.Name = "nodesToolStripMenuItem";
            this.nodesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nodesToolStripMenuItem.Text = "Nodes";
            this.nodesToolStripMenuItem.Click += new System.EventHandler(this.nodesToolStripMenuItem_Click);
            // 
            // networksToolStripMenuItem
            // 
            this.networksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("networksToolStripMenuItem.Image")));
            this.networksToolStripMenuItem.Name = "networksToolStripMenuItem";
            this.networksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.networksToolStripMenuItem.Text = "Networks";
            this.networksToolStripMenuItem.Click += new System.EventHandler(this.networksToolStripMenuItem_Click);
            // 
            // verboseToolStripMenuItem
            // 
            this.verboseToolStripMenuItem.Checked = true;
            this.verboseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verboseToolStripMenuItem.Name = "verboseToolStripMenuItem";
            this.verboseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verboseToolStripMenuItem.Text = "Verbose";
            this.verboseToolStripMenuItem.Click += new System.EventHandler(this.verboseToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pathToolStripMenuItem.Image")));
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pathToolStripMenuItem.Text = "Path";
            this.pathToolStripMenuItem.Click += new System.EventHandler(this.pathToolStripMenuItem_Click);
            // 
            // ArtUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.darkStatusStrip);
            this.Controls.Add(this.darkMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtUI_Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArtUI_Main_FormClosing);
            this.Load += new System.EventHandler(this.ArtUI_Main_Load);
            this.SizeChanged += new System.EventHandler(this.ArtNet_UI_Main_SizeChanged);
            this.Resize += new System.EventHandler(this.ArtNet_UI_Main_SizeChanged);
            this.darkStatusStrip.ResumeLayout(false);
            this.darkStatusStrip.PerformLayout();
            this.darkMenuStrip.ResumeLayout(false);
            this.darkMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verboseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
    }
}

