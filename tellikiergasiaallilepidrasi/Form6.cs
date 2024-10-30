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
    public partial class Form6 : Form
    {
        int x = 1;
        int y = 1;
        int z = 99;
        Random rnd = new Random();
        public Form6()
        {
            InitializeComponent();
            int t = rnd.Next(10);
            z = t;
            progressBar1.Value = t * 10;
            label1.Text = t * 10 + "%";
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            if (t > 5)
            {
                label2.Text = "Ή συσκευή είναι επαρκώς φορτισμένη";
            }
            else
            {
                label2.Text = "Δεν συνιστάται έναρξη καθαρισμού λόγω χαμηλής μπαταρίας";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            if (x % 2 == 0 || z==0)
            {
                pictureBox1.Image = Properties.Resources.vacuum_cleaner;
                pictureBox6.Image = Properties.Resources.off_button;
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel3.BackColor = Color.Black;
                label2.Text = " ";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.vacuum_spy_Jason20A20Keisling;
                pictureBox6.Image = Properties.Resources.on_button;
                label2.Text = "Επιλέξτε λειτουργία καθαρισμού";
            }
            x++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            label2.Text = "Κανονική λειτουργία καθαρισμού";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Green;
            panel3.BackColor = Color.Black;
            label2.Text = "Λειτουργία καθαρισμού ακρών";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Green;
            label2.Text = "Λειτουργία σπιράλ καθαρισμού";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
        }
    }
}
