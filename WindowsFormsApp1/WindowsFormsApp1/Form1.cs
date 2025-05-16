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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=ZAHRA-DESKTOP\\MSSQLSERVER2;Initial Catalog=project2;Integrated Security=True");
            connectionString.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Doctor VALUES (@SSN, @FirstName, @LastName, @Specialty, @YearsOfExperience, @PhoneNum)", connectionString);
            command.Parameters.AddWithValue("@SSN", GenerateRandomId());
            command.Parameters.AddWithValue("@FirstName", textBox1.Text);
            command.Parameters.AddWithValue("@LastName",  textBox2.Text);
            command.Parameters.AddWithValue("@Specialty",  textBox3.Text);
            command.Parameters.AddWithValue("@YearsOfExperience", numericUpDown1.Value);
            command.Parameters.AddWithValue("@PhoneNum", Int64.Parse(textBox4.Text));
            command.ExecuteNonQuery();

            connectionString.Close();
            MessageBox.Show("Successfully inserted!");
        }

        private string GenerateRandomId()
        {
            int length = 10; // Length of the ID
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Characters to choose from
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form1
            Form2 form2 = new Form2();

            // Show Form1
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form1
            Form3 form3 = new Form3();

            // Show Form1
            form3.Show();
        }
    }
}
