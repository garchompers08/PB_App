﻿using System;
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
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Signup()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-F4IP62L;Initial Catalog=pb_app;Integrated Security=True";
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com = new SqlCommand("insert into profiles (pass,last_name,first_name,birthdate,sex,course) VALUES ('" + textpass.Text+ "','"+textLastName.Text + "','" +txtFirstName.Text + "','" +birthday.Value.Date.ToString("yyyyMMdd") + "','" + textSex.Text + "','" + textCourse.Text+  "')",con);
            com.ExecuteNonQuery();
            MessageBox.Show("Signup Complete");
            

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
