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
    public partial class Form9 : Form
    {
        public Form9(String str1)
        {
            InitializeComponent();
            if (str1 == "University")
            {
                pictureBox1.Image = Properties.Resources.shoe6;
                pictureBox2.Image = Properties.Resources.shoe4;
            }
            else if (str1 == "Gym")
            {
                pictureBox1.Image = Properties.Resources.shoe1;
                pictureBox2.Image = Properties.Resources.shoe6;
            }
            else if (str1 == "Driving School")
            {
                pictureBox1.Image = Properties.Resources.shoe3;
                pictureBox2.Image = Properties.Resources.shoe4;
            }
            else if (str1 == "Night Out")
            {
                pictureBox1.Image = Properties.Resources.shoe2;
                pictureBox2.Image = Properties.Resources.shoe5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες το πρώτο ζευγάρι!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες το δεύτερο ζευγάρι!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //online shop with url
            System.Diagnostics.Process.Start("https://www.kalogirou.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
        }
    }
}
