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
    public partial class Form4 : Form
    {
        //using random
        Random rand = new Random();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //disabling timer3 to avoid overlap
            timer3.Enabled = false;

            //checking if the dog has eaten
            if (button1.Text == "FEED")
            {
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Dog has eaten!");
            }
        }

        //for the dogs movement
        private void timer1_Tick(object sender, EventArgs e)
        {
            //for the food
            if (pictureBox4.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
            //for the bowl
            else if (pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            //for dog movement
            else if (pictureBox1.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox1.Visible = false;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox7.Visible = true;
                pictureBox6.Visible = false;
            }
            else if (pictureBox7.Visible == true)
            {
                //disabling the timer
                timer1.Enabled = false;
                //bowl becomes empty
                pictureBox3.Visible = false;
                button1.Text = "NO FOOD";
                pictureBox1.Visible = true;
                pictureBox7.Visible = false;
                timer1.Enabled = false;
                int random_number = rand.Next(1, 4);
                timer2.Enabled = true;
                switch (random_number)
                {
                    case 1:
                        MessageBox.Show("Dog ate a little bit of food.");
                        timer2.Interval = 3000;
                        break;
                    case 2:
                        MessageBox.Show("Dog ate an reasonable ammount of food.");
                        timer2.Interval = 6000;
                        break;
                    case 3:
                        MessageBox.Show("Dog ate a lot of food.");
                        timer2.Interval = 10000;
                        break;
                }
                timer3.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Text = "FEED";
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox4.Visible = true;
            pictureBox2.Visible = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox8.Visible == false & timer2.Enabled == false & timer1.Enabled == false)
            {
                pictureBox8.Visible = true;
                MessageBox.Show("Oh No! The dog ia eating your shoe!!!");
                timer3.Enabled = false;
                pictureBox8.Visible = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }
    }
}
