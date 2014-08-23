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
using System.Media;

namespace view
{
    public partial class W8multiTool_mainView : Form
    {
        MainviewController mainviewController_obj = new MainviewController();
        public W8multiTool_mainView()
        {
            InitializeComponent();
            panel_alarmClock.Hide();
            minimize_form();
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

         SoundPlayer sp = new SoundPlayer();
        //System.WMPLib.WindowsMediaPlayer Player;
        private void timer_clock_Tick(object sender, EventArgs e)
        {
            Clock_Count_label.Text = DateTime.Now.ToString("h:mm:ss tt");

            if (isSetAlarm.Checked && Alarm_time.Text==Clock_Count_label.Text)
            {

                if (audio_checkBox.Checked)
                {
                    //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                    //wplayer.URL = "My MP3 file.mp3";
                    //wplayer.controls.play();
                    sp.Stream=Properties.Resources.audio;
                    //sp.SoundLocation = "D:\\1.wav";
                    //sp.PlaySync();
                    sp.Play();
                    //MessageBox.Show("Alarm at " + Clock_Count_label.Text);

                    isSetAlarm.Checked = false;
                    if (MessageBox.Show("Alarm at " + Alarm_time.Text, "Alarm Clock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        sp.Stop();
                    }
                    Alarm_time.Text = "Not set Yet";
                }
             
                    
                   
                /*else
                {
                    if (MessageBox.Show("Alarm at" + Clock_Count_label.Text, "Alarm Clock", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        MessageBox.Show("Alarm at" + Clock_Count_label.Text);
                        isSetAlarm.Checked = false;
                        Alarm_time.Text = "Not set Yet";
                    }
                }*/
                    
                
            }
            
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
            Max_PicBox.BackgroundImage = Properties.Resources.maximize_click;
        }

        private void Max_PicBox_MouseEnter(object sender, EventArgs e)
        {
            Max_PicBox.BackgroundImage = Properties.Resources.maximize_enter;
        }


        private void Max_PicBox_MouseLeave(object sender, EventArgs e)
        {
            Max_PicBox.BackgroundImage = Properties.Resources.maximize;
        }
        int i=0;

        private void Max_PicBox_Click(object sender, EventArgs e)
        {
            
            if (i % 2 == 0)
            {
               
                i++;

                maximize_form();
                //Clock_label.Size = new System.Drawing.Size(113, 24);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            }

            else
            {
                i++;

                minimize_form();


                //Clock_label.Size = new System.Drawing.Size(70, 25);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
            }
        }
        private void timer_PerformanceCounter_Tick(object sender, EventArgs e)
        {        
            Cpu_Count_label.Text = mainviewController_obj.ProcessorUsages()+" %";
            Ram_Count_label.Text = mainviewController_obj.MemoryUsage() + " MB";
            Hdd_Count_label.Text = mainviewController_obj.DiskUsages()+" MB";
            Battery_Count_label.Text=mainviewController_obj.PowerCalculator()+" %";
        }

        //double opacity;
        private void opacity_10_Click(object sender, EventArgs e)
        {
            this.Opacity = .1;
            //opacity = 0.1;
        }

        private void W8multiTool_mainView_MouseEnter(object sender, EventArgs e)
        {
           // this.Opacity = 1;
        }

        private void W8multiTool_mainView_MouseLeave(object sender, EventArgs e)
        {
           
            
            //this.Opacity = opacity;
        }

        private void opacity_20_Click(object sender, EventArgs e)
        {
            this.Opacity = .2;
        }

        private void opacity_50_Click(object sender, EventArgs e)
        {
            this.Opacity = .5;
        }

        private void opacity_80_Click(object sender, EventArgs e)
        {
            this.Opacity = .8;
        }

        private void opacity_60_Click(object sender, EventArgs e)
        {
            this.Opacity = .6;
        }

        private void opacity_100_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }


        public void minimize_form()
        {
            TitleBar.Size = new System.Drawing.Size(165, 20);
            Exit_PicBox.Location = new System.Drawing.Point(145, 0);
            Max_PicBox.Location = new System.Drawing.Point(125, 0);
            menuStrip_menu.Location = new System.Drawing.Point(93, -2);
            this.Size = new System.Drawing.Size(165, 115);

            CpuRate_panel.Hide();
            RamRate_panel.Hide();
            HddRate_panel.Hide();

            Hdd_label.Location = new System.Drawing.Point(92, 26);
            Hdd_Count_label.Location = new System.Drawing.Point(97, 52);
            Battery_label.Location = new System.Drawing.Point(92, 68);
            Battery_Count_label.Location = new System.Drawing.Point(97, 96);
        }


        public void maximize_form()
        {
            this.Size = new System.Drawing.Size(189, 268);
            
            CpuRate_panel.Show();
            RamRate_panel.Show();
            HddRate_panel.Show();

            TitleBar.Size = new System.Drawing.Size(188, 20);
            Exit_PicBox.Location = new System.Drawing.Point(168, 0);
            Max_PicBox.Location = new System.Drawing.Point(148, 0);
            menuStrip_menu.Location = new System.Drawing.Point(114, -2);

            Hdd_label.Location = new System.Drawing.Point(-1, 121);
            Hdd_Count_label.Location = new System.Drawing.Point(7, 149);
            Battery_label.Location = new System.Drawing.Point(2, 173);
            Battery_Count_label.Location = new System.Drawing.Point(9, 200);
        }

        private void Active_Click(object sender, EventArgs e)
        {
            //maximize_form();
            if (!isSetAlarm.Checked)
            {
                Alarm_time.Text = dateTimePicker.Text;
                isSetAlarm.Checked = true;
            }
            maximize_form();
            panel_alarmClock.Hide();
            options_panel.Show();
            
        }

        int j = 0;
        private void Alarm_picBox_Click(object sender, EventArgs e)
        {
            if (j % 2 == 0)
            {

                this.Size = new System.Drawing.Size(189, 360);
                panel_alarmClock.Show();
                j++;
            }
            else
            {
                maximize_form();
                j++;
            }
            
        }

        private void alarrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


      
       


        
       

    }
}
