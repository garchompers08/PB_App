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
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            // Set the maximum length of text in the control to eight.
            textBox1.MaxLength = 8;
            // Assign the asterisk to be the password character.
            textBox1.PasswordChar = '*';
            // Change all text entered to be lowercase.
            textBox1.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Landing button = new Landing();
           button.ShowDialog();
           this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write function to check if username matches password
            SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + username.Text + "' AND password='" + password.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new Dashboard().Show();
            }
            else
                MessageBox.Show("Invalid username or password");

        }
    }
}
