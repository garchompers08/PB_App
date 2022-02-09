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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-F4IP62L;Initial Catalog=pb_app;Integrated Security=True";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           Landing button = new Landing();
           button.ShowDialog();
           this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection=con;
            com.CommandText = "select * from profiles ";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (username.Text.Equals(dr["studentID"].ToString()) && password.Text.Equals(dr["pass"].ToString()))
                {
                    MessageBox.Show("not Error");
                    //Dashboard button = new Dashboard();
                    //button.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            con.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass(object sender, EventArgs e)
        {

        }

        private void txtUsername(object sender, EventArgs e)
        {

        }
    }
}
