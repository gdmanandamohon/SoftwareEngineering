using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class MainviewModelClass
    {
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
    }
}
