using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using controller;

namespace view
{
    public partial class W8multiTool_mainView : Form
    {
        MainviewController mainviewController_obj = new MainviewController();
        public W8multiTool_mainView()
        {
            InitializeComponent();

            TitleBar.Size = new System.Drawing.Size(165, 20);
            Exit_PicBox.Location = new System.Drawing.Point(145, 0);
            Max_PicBox.Location = new System.Drawing.Point(125, 0);
            this.Size = new System.Drawing.Size(165, 115);

            CpuRate_panel.Hide();
            RamRate_panel.Hide();
            HddRate_panel.Hide();

            Hdd_label.Location = new System.Drawing.Point(92, 26);
            Hdd_Count_label.Location = new System.Drawing.Point(97, 52);
            Battery_label.Location = new System.Drawing.Point(92, 68);
            Battery_Count_label.Location = new System.Drawing.Point(97, 96);
        }

        Point formloc, curloc = new Point(0, 0);
        private void setpositions()
        {
            formloc = this.Location;
            //
            curloc = Cursor.Position;
            //
        }

        private void timer_w8_positioning_Tick(object sender, EventArgs e)
        {
            int exe = formloc.X - curloc.X + Cursor.Position.X;
            int eye = formloc.Y - curloc.Y + Cursor.Position.Y;
            this.Location = new Point(exe, eye);
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            setpositions();
            timer_w8_positioning.Start();
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            setpositions();
            timer_w8_positioning.Stop();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            Clock_Count_label.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
        }

 
        protected PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private void Exit_PicBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_PicBox_MouseEnter(object sender, EventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit_enter;
        }

        private void Exit_PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit_click;
        }

        private void Exit_PicBox_MouseLeave(object sender, EventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit;
        }

        private void Max_PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            Max_PicBox.BackColor = Color.Gainsboro;
        }

        private void Max_PicBox_MouseEnter(object sender, EventArgs e)
        {
            Max_PicBox.BackColor = Color.Silver;
        }

        private void Max_PicBox_MouseLeave(object sender, EventArgs e)
        {
            Max_PicBox.BackColor = Color.Gray;
        }
        int i=0;

        private void Max_PicBox_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.Size = new System.Drawing.Size(189, 223);
                i++;
                CpuRate_panel.Show();
                RamRate_panel.Show();
                HddRate_panel.Show();

                TitleBar.Size = new System.Drawing.Size(188, 20);
                Exit_PicBox.Location = new System.Drawing.Point(168, 0);
                Max_PicBox.Location = new System.Drawing.Point(148, 0);

                Hdd_label.Location = new System.Drawing.Point(-1, 121);
                Hdd_Count_label.Location = new System.Drawing.Point(7, 149);
                Battery_label.Location = new System.Drawing.Point(2, 173);
                Battery_Count_label.Location = new System.Drawing.Point(9, 200);

                //Clock_label.Size = new System.Drawing.Size(113, 24);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            }

            else
            {
                i++;

                TitleBar.Size = new System.Drawing.Size(165, 20);
                Exit_PicBox.Location = new System.Drawing.Point(145, 0);
                Max_PicBox.Location = new System.Drawing.Point(125, 0);
                this.Size = new System.Drawing.Size(165, 115);

                CpuRate_panel.Hide();
                RamRate_panel.Hide();
                HddRate_panel.Hide();

                Hdd_label.Location = new System.Drawing.Point(92, 26);
                Hdd_Count_label.Location = new System.Drawing.Point(97, 52);
                Battery_label.Location = new System.Drawing.Point(92, 68);
                Battery_Count_label.Location = new System.Drawing.Point(97, 96); ;


                //Clock_label.Size = new System.Drawing.Size(70, 25);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
            }
        }
        private void timer_PerformanceCounter_Tick(object sender, EventArgs e)
        {        
            Cpu_Count_label.Text = mainviewController_obj.ProcessorUsages()+"%";
            Ram_Count_label.Text = mainviewController_obj.MemoryUsage() + "MB";
        }

       


        
       

    }
}
