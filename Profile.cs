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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FindCourses button = new FindCourses();
            button.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard button = new Dashboard();
            button.ShowDialog();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindCourses button = new FindCourses();
            button.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCourses button = new MyCourses();
            button.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyProfessor button = new MyProfessor();
            button.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyQuizzes button = new MyQuizzes();
            button.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
