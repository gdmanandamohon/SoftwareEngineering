namespace view
{
    partial class W8multiTool_mainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W8multiTool_mainView));
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Exit_PicBox = new System.Windows.Forms.PictureBox();
            this.Clock_Count_label = new System.Windows.Forms.Label();
            this.Max_PicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_20 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_60 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_80 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.alarrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calanderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Battery_label = new System.Windows.Forms.Label();
            this.Battery_Count_label = new System.Windows.Forms.Label();
            this.Hdd_Count_label = new System.Windows.Forms.Label();
            this.Hdd_label = new System.Windows.Forms.Label();
            this.Ram_label = new System.Windows.Forms.Label();
            this.Ram_Count_label = new System.Windows.Forms.Label();
            this.Cpu_Count_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BatteryRate_panel = new System.Windows.Forms.Panel();
            this.HddRate_panel = new System.Windows.Forms.Panel();
            this.RamRate_panel = new System.Windows.Forms.Panel();
            this.CpuRate_panel = new System.Windows.Forms.Panel();
            this.timer_w8_positioning = new System.Windows.Forms.Timer(this.components);
            this.timer_PerformanceCounter = new System.Windows.Forms.Timer(this.components);
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).BeginInit();
            this.menuStrip_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_clock
            // 
            this.timer_clock.Enabled = true;
            this.timer_clock.Interval = 1;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleBar.Controls.Add(this.Exit_PicBox);
            this.TitleBar.Controls.Add(this.Clock_Count_label);
            this.TitleBar.Controls.Add(this.Max_PicBox);
            this.TitleBar.Controls.Add(this.menuStrip_menu);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(188, 20);
            this.TitleBar.TabIndex = 6;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Exit_PicBox
            // 
            this.Exit_PicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit_PicBox.BackgroundImage = global::view.Properties.Resources.exit;
            this.Exit_PicBox.Location = new System.Drawing.Point(168, 0);
            this.Exit_PicBox.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_PicBox.Name = "Exit_PicBox";
            this.Exit_PicBox.Size = new System.Drawing.Size(20, 20);
            this.Exit_PicBox.TabIndex = 10;
            this.Exit_PicBox.TabStop = false;
            this.Exit_PicBox.Click += new System.EventHandler(this.Exit_PicBox_Click);
            this.Exit_PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_PicBox_MouseDown);
            this.Exit_PicBox.MouseEnter += new System.EventHandler(this.Exit_PicBox_MouseEnter);
            this.Exit_PicBox.MouseLeave += new System.EventHandler(this.Exit_PicBox_MouseLeave);
            // 
            // Clock_Count_label
            // 
            this.Clock_Count_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_Count_label.AutoSize = true;
            this.Clock_Count_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_Count_label.Location = new System.Drawing.Point(-2, 0);
            this.Clock_Count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock_Count_label.Name = "Clock_Count_label";
            this.Clock_Count_label.Size = new System.Drawing.Size(90, 20);
            this.Clock_Count_label.TabIndex = 1;
            this.Clock_Count_label.Text = "CLOCK TIME";
            // 
            // Max_PicBox
            // 
            this.Max_PicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Max_PicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Max_PicBox.BackgroundImage")));
            this.Max_PicBox.Location = new System.Drawing.Point(148, 0);
            this.Max_PicBox.Margin = new System.Windows.Forms.Padding(2);
            this.Max_PicBox.Name = "Max_PicBox";
            this.Max_PicBox.Size = new System.Drawing.Size(20, 20);
            this.Max_PicBox.TabIndex = 9;
            this.Max_PicBox.TabStop = false;
            this.Max_PicBox.Click += new System.EventHandler(this.Max_PicBox_Click);
            this.Max_PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Max_PicBox_MouseDown);
            this.Max_PicBox.MouseEnter += new System.EventHandler(this.Max_PicBox_MouseEnter);
            this.Max_PicBox.MouseLeave += new System.EventHandler(this.Max_PicBox_MouseLeave);
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.AutoSize = false;
            this.menuStrip_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiToolStripMenuItem});
            this.menuStrip_menu.Location = new System.Drawing.Point(107, -2);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(81, 24);
            this.menuStrip_menu.TabIndex = 34;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacityToolStripMenuItem,
            this.alarrmToolStripMenuItem,
            this.calanderToolStripMenuItem});
            this.hiToolStripMenuItem.Image = global::view.Properties.Resources.menu;
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacity_10,
            this.opacity_20,
            this.opacity_50,
            this.opacity_60,
            this.opacity_80,
            this.opacity_100});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.opacityToolStripMenuItem.Text = "Opacity";
            // 
            // opacity_10
            // 
            this.opacity_10.Name = "opacity_10";
            this.opacity_10.Size = new System.Drawing.Size(92, 22);
            this.opacity_10.Text = "10";
            this.opacity_10.Click += new System.EventHandler(this.opacity_10_Click);
            // 
            // opacity_20
            // 
            this.opacity_20.Name = "opacity_20";
            this.opacity_20.Size = new System.Drawing.Size(92, 22);
            this.opacity_20.Text = "30";
            this.opacity_20.Click += new System.EventHandler(this.opacity_20_Click);
            // 
            // opacity_50
            // 
            this.opacity_50.Name = "opacity_50";
            this.opacity_50.Size = new System.Drawing.Size(92, 22);
            this.opacity_50.Text = "50";
            this.opacity_50.Click += new System.EventHandler(this.opacity_50_Click);
            // 
            // opacity_60
            // 
            this.opacity_60.Name = "opacity_60";
            this.opacity_60.Size = new System.Drawing.Size(92, 22);
            this.opacity_60.Text = "60";
            this.opacity_60.Click += new System.EventHandler(this.opacity_60_Click);
            // 
            // opacity_80
            // 
            this.opacity_80.Name = "opacity_80";
            this.opacity_80.Size = new System.Drawing.Size(92, 22);
            this.opacity_80.Text = "80";
            this.opacity_80.Click += new System.EventHandler(this.opacity_80_Click);
            // 
            // opacity_100
            // 
            this.opacity_100.Name = "opacity_100";
            this.opacity_100.Size = new System.Drawing.Size(92, 22);
            this.opacity_100.Text = "100";
            this.opacity_100.Click += new System.EventHandler(this.opacity_100_Click);
            // 
            // alarrmToolStripMenuItem
            // 
            this.alarrmToolStripMenuItem.Name = "alarrmToolStripMenuItem";
            this.alarrmToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.alarrmToolStripMenuItem.Text = "Alarm";
            // 
            // calanderToolStripMenuItem
            // 
            this.calanderToolStripMenuItem.Name = "calanderToolStripMenuItem";
            this.calanderToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.calanderToolStripMenuItem.Text = "Calander";
            // 
            // Battery_label
            // 
            this.Battery_label.AutoSize = true;
            this.Battery_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Battery_label.Location = new System.Drawing.Point(5, 168);
            this.Battery_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Battery_label.Name = "Battery_label";
            this.Battery_label.Size = new System.Drawing.Size(69, 20);
            this.Battery_label.TabIndex = 28;
            this.Battery_label.Text = "BATTERY";
            // 
            // Battery_Count_label
            // 
            this.Battery_Count_label.AutoSize = true;
            this.Battery_Count_label.Location = new System.Drawing.Point(12, 195);
            this.Battery_Count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Battery_Count_label.Name = "Battery_Count_label";
            this.Battery_Count_label.Size = new System.Drawing.Size(39, 13);
            this.Battery_Count_label.TabIndex = 29;
            this.Battery_Count_label.Text = "battery";
            // 
            // Hdd_Count_label
            // 
            this.Hdd_Count_label.AutoSize = true;
            this.Hdd_Count_label.Location = new System.Drawing.Point(10, 144);
            this.Hdd_Count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hdd_Count_label.Name = "Hdd_Count_label";
            this.Hdd_Count_label.Size = new System.Drawing.Size(25, 13);
            this.Hdd_Count_label.TabIndex = 27;
            this.Hdd_Count_label.Text = "hdd";
            // 
            // Hdd_label
            // 
            this.Hdd_label.AutoSize = true;
            this.Hdd_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hdd_label.Location = new System.Drawing.Point(2, 116);
            this.Hdd_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hdd_label.Name = "Hdd_label";
            this.Hdd_label.Size = new System.Drawing.Size(75, 20);
            this.Hdd_label.TabIndex = 25;
            this.Hdd_label.Text = "HDD RATE";
            // 
            // Ram_label
            // 
            this.Ram_label.AutoSize = true;
            this.Ram_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram_label.Location = new System.Drawing.Point(0, 68);
            this.Ram_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ram_label.Name = "Ram_label";
            this.Ram_label.Size = new System.Drawing.Size(77, 20);
            this.Ram_label.TabIndex = 24;
            this.Ram_label.Text = "FREE RAM";
            // 
            // Ram_Count_label
            // 
            this.Ram_Count_label.AutoSize = true;
            this.Ram_Count_label.Location = new System.Drawing.Point(11, 93);
            this.Ram_Count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ram_Count_label.Name = "Ram_Count_label";
            this.Ram_Count_label.Size = new System.Drawing.Size(24, 13);
            this.Ram_Count_label.TabIndex = 26;
            this.Ram_Count_label.Text = "ram";
            // 
            // Cpu_Count_label
            // 
            this.Cpu_Count_label.AutoSize = true;
            this.Cpu_Count_label.Location = new System.Drawing.Point(11, 49);
            this.Cpu_Count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cpu_Count_label.Name = "Cpu_Count_label";
            this.Cpu_Count_label.Size = new System.Drawing.Size(25, 13);
            this.Cpu_Count_label.TabIndex = 23;
            this.Cpu_Count_label.Text = "cpu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPU RATE";
            // 
            // BatteryRate_panel
            // 
            this.BatteryRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatteryRate_panel.Location = new System.Drawing.Point(76, 167);
            this.BatteryRate_panel.Margin = new System.Windows.Forms.Padding(2);
            this.BatteryRate_panel.Name = "BatteryRate_panel";
            this.BatteryRate_panel.Size = new System.Drawing.Size(112, 47);
            this.BatteryRate_panel.TabIndex = 33;
            // 
            // HddRate_panel
            // 
            this.HddRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HddRate_panel.Location = new System.Drawing.Point(76, 115);
            this.HddRate_panel.Margin = new System.Windows.Forms.Padding(2);
            this.HddRate_panel.Name = "HddRate_panel";
            this.HddRate_panel.Size = new System.Drawing.Size(112, 47);
            this.HddRate_panel.TabIndex = 31;
            // 
            // RamRate_panel
            // 
            this.RamRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RamRate_panel.Location = new System.Drawing.Point(76, 67);
            this.RamRate_panel.Margin = new System.Windows.Forms.Padding(2);
            this.RamRate_panel.Name = "RamRate_panel";
            this.RamRate_panel.Size = new System.Drawing.Size(112, 45);
            this.RamRate_panel.TabIndex = 32;
            // 
            // CpuRate_panel
            // 
            this.CpuRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpuRate_panel.Location = new System.Drawing.Point(76, 24);
            this.CpuRate_panel.Margin = new System.Windows.Forms.Padding(2);
            this.CpuRate_panel.Name = "CpuRate_panel";
            this.CpuRate_panel.Size = new System.Drawing.Size(112, 40);
            this.CpuRate_panel.TabIndex = 30;
            // 
            // timer_w8_positioning
            // 
            this.timer_w8_positioning.Interval = 1;
            this.timer_w8_positioning.Tick += new System.EventHandler(this.timer_w8_positioning_Tick);
            // 
            // timer_PerformanceCounter
            // 
            this.timer_PerformanceCounter.Enabled = true;
            this.timer_PerformanceCounter.Interval = 1000;
            this.timer_PerformanceCounter.Tick += new System.EventHandler(this.timer_PerformanceCounter_Tick);
            // 
            // W8multiTool_mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(188, 223);
            this.Controls.Add(this.BatteryRate_panel);
            this.Controls.Add(this.HddRate_panel);
            this.Controls.Add(this.RamRate_panel);
            this.Controls.Add(this.CpuRate_panel);
            this.Controls.Add(this.Battery_label);
            this.Controls.Add(this.Battery_Count_label);
            this.Controls.Add(this.Hdd_Count_label);
            this.Controls.Add(this.Hdd_label);
            this.Controls.Add(this.Ram_label);
            this.Controls.Add(this.Ram_Count_label);
            this.Controls.Add(this.Cpu_Count_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_menu;
            this.Name = "W8multiTool_mainView";
            this.Text = "W8MultiTool";
            this.MouseEnter += new System.EventHandler(this.W8multiTool_mainView_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.W8multiTool_mainView_MouseLeave);

            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).EndInit();
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox Exit_PicBox;
        private System.Windows.Forms.Label Clock_Count_label;
        private System.Windows.Forms.PictureBox Max_PicBox;
        private System.Windows.Forms.Label Battery_label;
        private System.Windows.Forms.Label Battery_Count_label;
        private System.Windows.Forms.Label Hdd_Count_label;
        private System.Windows.Forms.Label Hdd_label;
        private System.Windows.Forms.Label Ram_label;
        private System.Windows.Forms.Label Ram_Count_label;
        private System.Windows.Forms.Label Cpu_Count_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BatteryRate_panel;
        private System.Windows.Forms.Panel HddRate_panel;
        private System.Windows.Forms.Panel RamRate_panel;
        private System.Windows.Forms.Panel CpuRate_panel;
        private System.Windows.Forms.Timer timer_w8_positioning;
        private System.Windows.Forms.Timer timer_PerformanceCounter;
        private System.Windows.Forms.MenuStrip menuStrip_menu;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacity_10;
        private System.Windows.Forms.ToolStripMenuItem opacity_20;
        private System.Windows.Forms.ToolStripMenuItem opacity_50;
        private System.Windows.Forms.ToolStripMenuItem opacity_60;
        private System.Windows.Forms.ToolStripMenuItem opacity_80;
        private System.Windows.Forms.ToolStripMenuItem opacity_100;
        private System.Windows.Forms.ToolStripMenuItem alarrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calanderToolStripMenuItem;
    }
}

