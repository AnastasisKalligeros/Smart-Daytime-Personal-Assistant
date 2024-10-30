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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διάλεξες ένα ζευγάρι!");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
        }
    }
}
