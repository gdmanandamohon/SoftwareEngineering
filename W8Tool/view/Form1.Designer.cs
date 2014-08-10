namespace view
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.clock_label = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.battery_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.performanceCounter_battery = new System.Diagnostics.PerformanceCounter();
            this.timer_battery = new System.Windows.Forms.Timer(this.components);
            this.cpu_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter_battery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIME :";
            // 
            // clock_label
            // 
            this.clock_label.AutoSize = true;
            this.clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_label.Location = new System.Drawing.Point(92, 30);
            this.clock_label.Name = "clock_label";
            this.clock_label.Size = new System.Drawing.Size(70, 25);
            this.clock_label.TabIndex = 1;
            this.clock_label.Text = "label2";
            // 
            // timer_clock
            // 
            this.timer_clock.Enabled = true;
            this.timer_clock.Interval = 1;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // battery_label
            // 
            this.battery_label.AutoSize = true;
            this.battery_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battery_label.Location = new System.Drawing.Point(92, 71);
            this.battery_label.Name = "battery_label";
            this.battery_label.Size = new System.Drawing.Size(70, 25);
            this.battery_label.TabIndex = 3;
            this.battery_label.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAM :";
            // 
            // performanceCounter_battery
            // 
            this.performanceCounter_battery.CategoryName = "Memory";
            this.performanceCounter_battery.CounterName = "% Committed Bytes In Use";
            // 
            // timer_battery
            // 
            this.timer_battery.Enabled = true;
            this.timer_battery.Interval = 1000;
            this.timer_battery.Tick += new System.EventHandler(this.timer_battery_Tick);
            // 
            // cpu_label
            // 
            this.cpu_label.AutoSize = true;
            this.cpu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_label.Location = new System.Drawing.Point(92, 110);
            this.cpu_label.Name = "cpu_label";
            this.cpu_label.Size = new System.Drawing.Size(70, 25);
            this.cpu_label.TabIndex = 5;
            this.cpu_label.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPU :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 257);
            this.Controls.Add(this.cpu_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.battery_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clock_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "W8MultiTool";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter_battery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clock_label;
        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.Label battery_label;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.PerformanceCounter performanceCounter_battery;
        private System.Windows.Forms.Timer timer_battery;
        private System.Windows.Forms.Label cpu_label;
        private System.Windows.Forms.Label label4;
    }
}

