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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string SetValueForUsername = "";
        public static string SetValueForPassword = "";

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }*/
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }*/
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            /*if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
            }*/
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            /*if (textBox2.Text == "")
            {
                textBox2.Text = "";
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false && String.IsNullOrEmpty(textBox2.Text) == false)
            {
                new Form1().Show();
                SetValueForUsername = textBox1.Text;
                SetValueForPassword = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
