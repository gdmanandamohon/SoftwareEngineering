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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            clock_label.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


    }
}
