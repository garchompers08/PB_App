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
    public partial class MyQuizzes : Form
    {
        public MyQuizzes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyProfessor button = new MyProfessor();
            button.ShowDialog();
            this.Hide();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    