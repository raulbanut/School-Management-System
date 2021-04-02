using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnLoginProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
