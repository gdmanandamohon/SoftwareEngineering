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

namespace view
{
    public partial class W8multiTool_mainView : Form
    {
        public W8multiTool_mainView()
        {
            InitializeComponent();
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


        
       

    }
}
