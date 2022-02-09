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
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();


        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Signup = new Signup();
            Signup.Closed += (s, args) => this.Close();
            Signup.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            var About = new About();
            About.Closed += (s, args) => this.Close();
            About.Show();
        }
    }
}
