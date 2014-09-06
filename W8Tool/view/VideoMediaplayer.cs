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
            //this.Disposed = true;
            //this.Hide();
            //this.Close();
            //this.axWindowsMediaPlayer1.close();
            this.Dispose();
            
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Title = "Open File";
            fopen.Filter = "files mp4 |*.mp4 |files AVI |*.avi |files MKV |*.mkv |files 3GP |*.3gp |files VOB |*.VOB | All files |*.*";
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

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox_Exit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_Exit_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exit.BackgroundImage = Properties.Resources.cross_hover;
        }

        private void pictureBox_Exit_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exit.BackgroundImage = Properties.Resources.cross_normal;
        }

        private void pictureBox_Minimize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Minimize.BackgroundImage = Properties.Resources.minimize_hover;
        }

        private void pictureBox_Minimize_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Minimize.BackgroundImage = Properties.Resources.minimize_normal;
        }

        private void pictureBox_Maximize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Maximize.BackgroundImage = Properties.Resources.maximize_hover;
        }

        private void pictureBox_Maximize_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Maximize.BackgroundImage = Properties.Resources.maximize_normal;
        }

       
    }

}
