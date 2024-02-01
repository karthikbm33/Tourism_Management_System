using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apps
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user id = root; password = bca123; database = tourism";
            try
            {
                con.Open();

                string query = "INSERT INTO details(NAME,PH_NUMBER,EMAIL,ADDRESS)values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "')";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PH_NUMBER", textBox2.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", textBox3.Text);
                    cmd.Parameters.AddWithValue("@ADDRESS", textBox4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("data stored successfully");
                    new Form4().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show("data not stored successfully");
            }
            finally { con.Close(); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
