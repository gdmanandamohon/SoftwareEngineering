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
using System.Windows.Forms.DataVisualization.Charting;


namespace view
{
    public partial class W8multiTool_mainView : Form
    {
        MainviewController mainviewController_obj = new MainviewController();
        CCleanerClass cclass = new CCleanerClass();
        public W8multiTool_mainView()
        {
            InitializeComponent();
            DrawToGraph1(50);
            panel_alarmClock.Hide();
            chart_map.Size = new System.Drawing.Size(305, 115);
            chart_map.Location = new System.Drawing.Point(-20, 109);
            minimize_form();
        }

        Point formloc, curloc = new Point(0, 0);
        private void setpositions()
        {
            formloc = this.Location;
            //
            curloc = System.Windows.Forms.Cursor.Position;
            //
        }

        private void timer_w8_positioning_Tick(object sender, EventArgs e)
        {
            int exe = formloc.X - curloc.X + System.Windows.Forms.Cursor.Position.X;
            int eye = formloc.Y - curloc.Y + System.Windows.Forms.Cursor.Position.Y;
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

        double x = 6;
        private void timer_PerformanceCounter_Tick(object sender, EventArgs e)
        {
            int cpu_rate = mainviewController_obj.ProcessorUsages();
            Cpu_Count_label.Text = cpu_rate.ToString() + " %";
            Ram_Count_label.Text = mainviewController_obj.MemoryUsage() + " MB";
            Hdd_Count_label.Text = mainviewController_obj.DiskUsages()+" MB";
            Battery_Count_label.Text=mainviewController_obj.PowerCalculator()+" %";

            DataPoint dp2 = new DataPoint(x, cpu_rate);
            chart_map.Series["CPU"].Points.Add(dp2);
            x++;
            chart_map.Series["CPU"].Points.RemoveAt(0);
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

            Hdd_label.Location = new System.Drawing.Point(92, 26);
            Hdd_Count_label.Location = new System.Drawing.Point(97, 52);
            Battery_label.Location = new System.Drawing.Point(92, 68);
            Battery_Count_label.Location = new System.Drawing.Point(97, 96);
        }


        public void maximize_form()
        {
            this.Size = new System.Drawing.Size(189, 268);

            TitleBar.Size = new System.Drawing.Size(188, 20);
            Exit_PicBox.Location = new System.Drawing.Point(168, 0);
            Max_PicBox.Location = new System.Drawing.Point(148, 0);
            menuStrip_menu.Location = new System.Drawing.Point(114, -2);

            Hdd_label.Location = new System.Drawing.Point(103, 25);
            Hdd_Count_label.Location = new System.Drawing.Point(107, 49);
            Battery_label.Location = new System.Drawing.Point(106, 68);
            Battery_Count_label.Location = new System.Drawing.Point(107, 93);
           /* Hdd_label.Location = new System.Drawing.Point(-1, 121);
            Hdd_Count_label.Location = new System.Drawing.Point(7, 149);
            Battery_label.Location = new System.Drawing.Point(2, 173);
            Battery_Count_label.Location = new System.Drawing.Point(9, 200);*/
        }

        private void Active_Click(object sender, EventArgs e)
        {
            //maximize_form();
            if (!isSetAlarm.Checked)
            {
                Alarm_time.Text = dateTimePicker.Text;
                isSetAlarm.Checked = true;
            }
           // maximize_form();
            //panel_alarmClock.Hide();
            options_panel.Show();
            
        }

        int j = 0;
        private void Alarm_picBox_Click(object sender, EventArgs e)
        {
            if (j % 2 == 0)
            {

                this.Size = new System.Drawing.Size(189, 360);
                WMP_panel.Hide();
                panel_alarmClock.Show();
                cCleaner_panel.Hide();
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

        int k = 0;
        private void CCleanerpictureBox_Click(object sender, EventArgs e)
        {

            if (k % 2 == 0)
            {

                this.Size = new System.Drawing.Size(189, 360);
                cCleaner_panel.Show();
                panel_alarmClock.Hide();
                WMP_panel.Hide();


                k++;
            }
            else
            {
                maximize_form();
                k++;
            }

        }

        private void RunClean_button_Click(object sender, EventArgs e)
        {
            if (TempClean_checkBox.Checked)
                cclass.cleanTemp();
            if (CeanP_Temp_checkBox.Checked)
                cclass.clean_PTemp();
            if (CleanPrefetch_checkBox.Checked)
                cclass.cleanPrefetch();
            if (TemporaryInternetFiles_checkBox.Checked)
                cclass.cleanTempInternetCach();
            
            
        }

        private void Alarm_picBox_MouseEnter(object sender, EventArgs e)
        {
            Alarm_picBox.BackColor = Color.DimGray ;
        }

        private void Alarm_picBox_MouseLeave(object sender, EventArgs e)
        {
            Alarm_picBox.BackColor = Color.Gray;
        }

        private void CCleanerpictureBox_MouseEnter(object sender, EventArgs e)
        {
            CCleanerpictureBox.BackColor = Color.DimGray;
        }

        private void CCleanerpictureBox_MouseLeave(object sender, EventArgs e)
        {
            CCleanerpictureBox.BackColor = Color.Gray;
        }
        Random ran = new Random();
        private void DrawToGraph1(int X)
        {
            chart_map.Series[0].Points.Clear();
            for (int g = 0; g <= 5; g++)
            {
                DataPoint dp = new DataPoint(g, X);
                chart_map.Series["CPU"].Points.Add(dp);
            }
        }

        private void cCleaner_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        int indextoggel=0;
        private void WMP_pictureBox_Click(object sender, EventArgs e)
        {


            if (indextoggel % 2 == 0)
            {

                this.Size = new System.Drawing.Size(189, 360);
                cCleaner_panel.Hide();
                panel_alarmClock.Hide();
                WMP_panel.Show();


                indextoggel++;
            }
            else
            {
                maximize_form();
                indextoggel++;
            }
        }

        private void openaudio_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void audioopen_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Title = "Open File";
            fopen.Filter = "files Mp3 |*.mp3 |files MPEG |*.m4a |files WMA |*.wma |files WAV |*.wav";
            fopen.FilterIndex = 1;

            try
            {
                if (fopen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = (fopen.FileName);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        


    }
}
