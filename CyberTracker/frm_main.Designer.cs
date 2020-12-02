namespace CyberTracker
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.ni_program = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_program = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_tracker = new System.Windows.Forms.Timer(this.components);
            this.lbl_logoText = new System.Windows.Forms.Label();
            this.flp_tracks = new System.Windows.Forms.FlowLayoutPanel();
            this.pcr_logo = new System.Windows.Forms.PictureBox();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_program.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ni_program
            // 
            this.ni_program.BalloonTipText = "Çalışan uygulamalar hakkında uyarılar var";
            this.ni_program.BalloonTipTitle = "Siber İzleyici";
            this.ni_program.ContextMenuStrip = this.cms_program;
            this.ni_program.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_program.Icon")));
            this.ni_program.Text = "Siber İzleyici";
            this.ni_program.Visible = true;
            this.ni_program.BalloonTipClicked += new System.EventHandler(this.ni_program_BalloonTipClicked);
            this.ni_program.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_program_MouseDoubleClick);
            // 
            // cms_program
            // 
            this.cms_program.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_program.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.cms_program.Name = "cms_program";
            this.cms_program.Size = new System.Drawing.Size(211, 80);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // tmr_tracker
            // 
            this.tmr_tracker.Enabled = true;
            this.tmr_tracker.Interval = 2000;
            this.tmr_tracker.Tick += new System.EventHandler(this.tmr_tracker_Tick);
            // 
            // lbl_logoText
            // 
            this.lbl_logoText.AutoSize = true;
            this.lbl_logoText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_logoText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_logoText.Location = new System.Drawing.Point(127, 21);
            this.lbl_logoText.Name = "lbl_logoText";
            this.lbl_logoText.Size = new System.Drawing.Size(164, 23);
            this.lbl_logoText.TabIndex = 1;
            this.lbl_logoText.Text = "SİBER İZLEYİCİ";
            // 
            // flp_tracks
            // 
            this.flp_tracks.AutoScroll = true;
            this.flp_tracks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_tracks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_tracks.Location = new System.Drawing.Point(0, 59);
            this.flp_tracks.Name = "flp_tracks";
            this.flp_tracks.Padding = new System.Windows.Forms.Padding(3);
            this.flp_tracks.Size = new System.Drawing.Size(379, 366);
            this.flp_tracks.TabIndex = 2;
            // 
            // pcr_logo
            // 
            this.pcr_logo.Image = global::CyberTracker.Properties.Resources.Internet_Security_home_house_smart_network_sharing_5172986_64;
            this.pcr_logo.Location = new System.Drawing.Point(66, 10);
            this.pcr_logo.Name = "pcr_logo";
            this.pcr_logo.Size = new System.Drawing.Size(43, 43);
            this.pcr_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_logo.TabIndex = 0;
            this.pcr_logo.TabStop = false;
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 425);
            this.Controls.Add(this.flp_tracks);
            this.Controls.Add(this.lbl_logoText);
            this.Controls.Add(this.pcr_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Text = "Siber İzleyici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.cms_program.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_logo;
        private System.Windows.Forms.NotifyIcon ni_program;
        private System.Windows.Forms.ContextMenuStrip cms_program;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_tracker;
        private System.Windows.Forms.Label lbl_logoText;
        private System.Windows.Forms.FlowLayoutPanel flp_tracks;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
    }
}

