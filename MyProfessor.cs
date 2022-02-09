using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PB_App
{
    public partial class MyProfessor : Form
    {
        string connectionString = @"Data Source=DESKTOP-F4IP62L;Initial Catalog=pb_app;Integrated Security=True";
        public MyProfessor()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard button = new Dashboard();
            button.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile button = new Profile();
            button.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindCourses button = new FindCourses();
            button.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCourses button = new MyCourses();
            button.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyQuizzes button = new MyQuizzes();
            button.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chckProf_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM professor",sqlCon);
                DataTable dtbl = new DataTable();   
                sqlDa.Fill(dtbl);

                dgv1.DataSource = dtbl; 
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
