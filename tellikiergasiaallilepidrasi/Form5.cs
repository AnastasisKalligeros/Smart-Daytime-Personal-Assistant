using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tellikiergasiaallilepidrasi
{
    public partial class Form5 : Form
    {
        int x = 1;
        int y = 1;
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Μπορείτε να ξεκινήσετε το πλύσιμο των ρούχων";
            y++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                pictureBox1.Image = Properties.Resources.washing_machine1;
                pictureBox2.Image = Properties.Resources.off_button;
            }
            else if (label1.Text == "Μπορείτε να ξεκινήσετε το πλύσιμο των ρούχων")
            {
                pictureBox1.Image = Properties.Resources.washmach;
                pictureBox2.Image = Properties.Resources.on_button;
            }
            else
            {
                label1.Text = "Προσοχή, δεν έχετε βάλει απορρυπαντικό!";
                x--;
            }
            x++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
    }
}
