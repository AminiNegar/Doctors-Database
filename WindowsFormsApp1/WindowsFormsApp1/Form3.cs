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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show Form1
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=ZAHRA-DESKTOP\\MSSQLSERVER2;Initial Catalog=project2;Integrated Security=True");
            connectionString.Open();

            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Doctor ORDER BY YearsOfExperience DESC", connectionString);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string ssn = reader["SSN"].ToString();
                string firstName = reader["FirstName"].ToString();
                string lastName = reader["LastName"].ToString();
                string specialty = reader["Specialty"].ToString();
                int yearsOfExperience = (int)reader["YearsOfExperience"];
                long phoneNum = (long)reader["PhoneNum"];

                label5.Text = ssn;
                label6.Text = firstName+" "+ lastName;
                label7.Text = specialty;
                label8.Text = yearsOfExperience.ToString();
                label9.Text = phoneNum.ToString();

                // Do something with the doctor information
                // For example, display it in text boxes or variables
            }

            reader.Close();
            connectionString.Close();
        }
    }
}
