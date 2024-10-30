using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tellikiergasiaallilepidrasi
{
    public partial class Form3 : Form
    {
        String connectionString = "Data Source=PlanDB.db;Version=3;";
        SQLiteConnection conn;
        String displayQuery = "Select * from Person";
        String Coffee;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            loadData();

            //initializing the selected data
            comboBox1.SelectedItem = "University";
            comboBox2.SelectedItem = "Car";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void loadData()
        {
            SQLiteCommand cmd1 = new SQLiteCommand(displayQuery, conn);
            SQLiteDataReader reader1 = cmd1.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader1);

            conn.Close();
            dataGridView1.DataSource = dt; //dataGrid has the deleting option enabled
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Coffee = "Yes";
            }
            else
            {
                Coffee = "No";

            }
            conn.Open();
            string insertQuery = "Insert into Person(Destination, Means, DateTime, Coffee) values('" + comboBox1.SelectedItem.ToString() + "','"
                + comboBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value + "',  '"+Coffee +"')";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            int rows = cmd.ExecuteNonQuery();
            loadData();
            MessageBox.Show("New event inserted.");
        }

        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String deleteQuery = "DELETE FROM Person WHERE ID = '" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'";
            SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
            int rows = cmd.ExecuteNonQuery(); // rows must be greater than 0 if successfull
            loadData();
            MessageBox.Show("Deleted one plan!");
        }

        //edit
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Coffee = "Yes";
            }
            else
            {
                Coffee = "No";

            }
            conn.Open();
            string updateQuery = "update Person set Destination = '" + comboBox1.SelectedItem.ToString() + "', Means = '" + comboBox2.SelectedItem.ToString() + "', " +
               "DateTime = '" + dateTimePicker1.Value.ToString() + "', Coffee = '"+Coffee+"' where ID = '" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'";
            SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
            int rows = cmd.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Event updated.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "Insert into Person(Destination, Means, DateTime, Coffee) values('" + "Dog Feeding" + "','"
                + "None" + "','" + DateTime.Now + "',  '" + "Empty" + "')";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            int rows = cmd.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Dog feeding inserted.");
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //maps with url
            System.Diagnostics.Process.Start("https://www.google.com/maps");
        }
    }
}
