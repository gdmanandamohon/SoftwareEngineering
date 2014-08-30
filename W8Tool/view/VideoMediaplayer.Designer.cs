namespace view
{
    partial class VideoMediaplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoMediaplayer));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Maximize = new System.Windows.Forms.PictureBox();
            this.menuStrip_titleBar = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel_menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).BeginInit();
            this.menuStrip_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 23);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(282, 226);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel_menubar
            // 
            this.panel_menubar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menubar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menubar.Controls.Add(this.pictureBox1);
            this.panel_menubar.Controls.Add(this.pictureBox_Minimize);
            this.panel_menubar.Controls.Add(this.pictureBox_Maximize);
            this.panel_menubar.Controls.Add(this.menuStrip_titleBar);
            this.panel_menubar.Controls.Add(this.pictureBox_Exit);
            this.panel_menubar.Location = new System.Drawing.Point(-1, 0);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(286, 24);
            this.panel_menubar.TabIndex = 1;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menubar_MouseDown);
            this.panel_menubar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_menubar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(221, 2);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Minimize.TabIndex = 4;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            // 
            // pictureBox_Maximize
            // 
            this.pictureBox_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Maximize.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Maximize.Location = new System.Drawing.Point(242, 2);
            this.pictureBox_Maximize.Name = "pictureBox_Maximize";
            this.pictureBox_Maximize.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Maximize.TabIndex = 3;
            this.pictureBox_Maximize.TabStop = false;
            this.pictureBox_Maximize.Click += new System.EventHandler(this.pictureBox_Maximize_Click);
            // 
            // menuStrip_titleBar
            // 
            this.menuStrip_titleBar.AutoSize = false;
            this.menuStrip_titleBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip_titleBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_titleBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip_titleBar.Location = new System.Drawing.Point(23, 0);
            this.menuStrip_titleBar.Name = "menuStrip_titleBar";
            this.menuStrip_titleBar.Size = new System.Drawing.Size(47, 24);
            this.menuStrip_titleBar.TabIndex = 2;
            this.menuStrip_titleBar.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Exit.Location = new System.Drawing.Point(263, 2);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Exit.TabIndex = 2;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // timer_move
            // 
            this.timer_move.Interval = 1;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // VideoMediaplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel_menubar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_titleBar;
            this.Name = "VideoMediaplayer";
            this.Text = "VideoMediaplayer";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel_menubar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).EndInit();
            this.menuStrip_titleBar.ResumeLayout(false);
            this.menuStrip_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel_menubar;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Maximize;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Timer timer_move;
        private System.Windows.Forms.MenuStrip menuStrip_titleBar;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}