using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
namespace Apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user id = root; password = bca123; database = tourism";

            con.Open();
            MySqlCommand checkPasswordCmd = new MySqlCommand("SELECT COUNT(*) FROM login WHERE username = @username AND  Password = @Password", con);
            checkPasswordCmd.Parameters.AddWithValue("@username", textBox1.Text);
            checkPasswordCmd.Parameters.AddWithValue("@Password", textBox2.Text);
            int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());
            if (passwordCount == 0)
            {
                MessageBox.Show("Login not Successfull ");
                textBox2.Text = "";
                textBox1.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Logined Successfull ✔");
                new Form3().Show();
                this.Hide();
            }
            con.Close();
            con.Dispose();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
