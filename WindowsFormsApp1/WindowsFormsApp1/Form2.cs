using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.project2DataSet1.Doctor);
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
