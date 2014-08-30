using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class VideoMediaplayer : Form
    {
        public VideoMediaplayer()
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

        private void timer_move_Tick(object sender, EventArgs e)
        {
            int exe = formloc.X - curloc.X + System.Windows.Forms.Cursor.Position.X;
            int eye = formloc.Y - curloc.Y + System.Windows.Forms.Cursor.Position.Y;
            this.Location = new Point(exe, eye);
        }


        private void panel_menubar_MouseDown(object sender, MouseEventArgs e)
        {
                setpositions();
                timer_move.Start();
        }

        private void panel_menubar_MouseUp(object sender, MouseEventArgs e)
        {
            setpositions();
            timer_move.Stop();
        }
        int count_toggle = 0;
        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            if (count_toggle % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                count_toggle++;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(285, 243);
                count_toggle++;
            }
                
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
