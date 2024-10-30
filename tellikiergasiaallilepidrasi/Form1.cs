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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            guna2Panel4.FillColor = Color.Blue;
            new Form8().Show();
            this.Hide();
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            guna2Panel5.FillColor = Color.Blue;
            new Form5().Show();
            this.Hide();
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            guna2Panel3.FillColor = Color.Blue;
            new Form7().Show();
            this.Hide();
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            guna2Panel6.FillColor = Color.Blue;
            new Form6().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = Form2.SetValueForUsername;
            MessageBox.Show(user.HiUser());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        { 
            User user = new User();
            user.Password = Form2.SetValueForPassword;
            MessageBox.Show(user.MyPass());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
