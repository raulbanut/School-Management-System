using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SchoolManagement
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnLoginStudent_Click(object sender, EventArgs e)
        {
            string student = "student";
            this.Hide();
            Form loginForm = new LoginForm(student);
            loginForm.Show();
        }

        private void btnLoginProfessor_Click(object sender, EventArgs e)
        {
            string teacher = "teacher";
            this.Hide();
            Form loginForm = new LoginForm(teacher);
            loginForm.Show();
        }
    }
}
