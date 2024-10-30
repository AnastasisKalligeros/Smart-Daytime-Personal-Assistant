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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                Form9 f9 = new Form9(radioButton1.Text);
                f9.Show();
            }
            else if (radioButton2.Checked)
            {
                this.Hide();
                Form9 f9 = new Form9(radioButton2.Text);
                f9.Show();
            }
            else if (radioButton3.Checked)
            {
                this.Hide();
                Form9 f9 = new Form9(radioButton3.Text);
                f9.Show();
            }
            else if (radioButton4.Checked)
            {
                this.Hide();
                Form9 f9 = new Form9(radioButton4.Text);
                f9.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
        }
    }
}
