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
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Exit_PicBox = new System.Windows.Forms.PictureBox();
            this.Clock_Count_label = new System.Windows.Forms.Label();
            this.Max_PicBox = new System.Windows.Forms.PictureBox();
            this.Another_label = new System.Windows.Forms.Label();
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
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).BeginInit();
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
            this.Exit_PicBox.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_PicBox.BackgroundImage = global::view.Properties.Resources.exit;
            this.Exit_PicBox.Location = new System.Drawing.Point(168, 0);
            this.Exit_PicBox.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_PicBox.Name = "Exit_PicBox";
            this.Exit_PicBox.Size = new System.Drawing.Size(20, 20);
            this.Exit_PicBox.TabIndex = 10;
            this.Exit_PicBox.TabStop = false;
            this.Exit_PicBox.Click += new System.EventHandler(this.Exit_PicBox_Click);
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
            this.Max_PicBox.BackColor = System.Drawing.Color.Gray;
            this.Max_PicBox.BackgroundImage = global::view.Properties.Resources.maximize;
            this.Max_PicBox.Location = new System.Drawing.Point(148, 0);
            this.Max_PicBox.Margin = new System.Windows.Forms.Padding(2);
            this.Max_PicBox.Name = "Max_PicBox";
            this.Max_PicBox.Size = new System.Drawing.Size(20, 20);
            this.Max_PicBox.TabIndex = 9;
            this.Max_PicBox.TabStop = false;
            // 
            // Another_label
            // 
            this.Another_label.AutoSize = true;
            this.Another_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Another_label.Location = new System.Drawing.Point(5, 168);
            this.Another_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Another_label.Name = "Another_label";
            this.Another_label.Size = new System.Drawing.Size(69, 20);
            this.Another_label.TabIndex = 28;
            this.Another_label.Text = "BATTERY";
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
            this.Ram_label.Text = "RAM RATE";
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
            this.timer_w8_positioning.Tick += new System.EventHandler(this.timer_w8_positioning_Tick);
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
            this.Controls.Add(this.Another_label);
            this.Controls.Add(this.Battery_Count_label);
            this.Controls.Add(this.Hdd_Count_label);
            this.Controls.Add(this.Hdd_label);
            this.Controls.Add(this.Ram_label);
            this.Controls.Add(this.Ram_Count_label);
            this.Controls.Add(this.Cpu_Count_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "W8multiTool_mainView";
            this.Text = "W8MultiTool";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox Exit_PicBox;
        private System.Windows.Forms.Label Clock_Count_label;
        private System.Windows.Forms.PictureBox Max_PicBox;
        private System.Windows.Forms.Label Another_label;
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
    }
}

