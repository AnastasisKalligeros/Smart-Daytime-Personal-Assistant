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
    public partial class Form7 : Form
    {
        int x = 1;
        double y = 0.0;
        int t = 0;
        Random rnd = new Random();
        public Form7()
        {
            InitializeComponent();
            t = rnd.Next(30);
            label1.Text = "  0.0";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {

                pictureBox2.Image = Properties.Resources.off_button;
                label1.Text = "  0.0";
                timer1.Enabled = false;

            }

            else
            {

                pictureBox2.Image = Properties.Resources.on_button;
                timer1.Enabled = true;
            }
            x++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 36.0)
            {
                timer1.Interval = 10;
                y = y + 0.1;
                String text = y.ToString();
                if (text.Length > 4)
                {
                    label1.Text = text.Substring(0, 4);
                }
                else
                {
                    label1.Text = text;
                }

            }
            else if (t > 0)
            {
                timer1.Interval = 100;
                y = y + 0.1;
                String text = y.ToString();
                if (text.Length > 4)
                {
                    label1.Text = text.Substring(0, 4);
                }
                else
                {
                    label1.Text = text;
                }
                t--;
                if (y > 37 && y < 38)
                {
                    panel1.BackColor = Color.Yellow;
                }
                else if (y > 38)
                {
                    panel1.BackColor = Color.Red;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
        }
    }
}
