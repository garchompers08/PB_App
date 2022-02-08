using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB_App
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login button = new Login();
            button.ShowDialog();
            this.Hide();


        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Signup button = new Signup();
            button.ShowDialog();
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }
    }
}
