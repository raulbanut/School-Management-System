using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagement
{
    public partial class LoginForm : Form
    {
        string teacherOrStudent;
        public LoginForm(string teacherOrStudent)
        {
            this.teacherOrStudent = teacherOrStudent;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            DataSet dataset = new DataSet();
            
            connection.ConnectionString = @"server=localhost;user id=deac;pwd=0000;database=school";
            connection.Open();
            
            if (teacherOrStudent == "student")
            {
                bool ok = false;
                MySqlDataAdapter dataAdapterStudent = new MySqlDataAdapter("select username,password from students_data", connection);
                dataAdapterStudent.Fill(dataset, "students_data");
                foreach (DataRow dr in dataset.Tables["students_data"].Rows)
                {
                    if (dr.ItemArray.GetValue(0).ToString() == username && dr.ItemArray.GetValue(1).ToString() == password)
                    {
                        ok = true;
                        MainFormStudent mainFormStudent = new MainFormStudent(username, password);
                        mainFormStudent.Show();
                        this.Hide();
                    }  
                }
                if (ok == false)
                    MessageBox.Show("Username or password incorrect, verify to login as teacher or student", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (teacherOrStudent == "teacher")
            {
                bool ok = false;
                MySqlDataAdapter dataAdapterTeacher = new MySqlDataAdapter("select username,password from teachers_data", connection);
                dataAdapterTeacher.Fill(dataset, "teachers_data");
                foreach (DataRow dr in dataset.Tables["teachers_data"].Rows)
                {
                    if (dr.ItemArray.GetValue(0).ToString() == username && dr.ItemArray.GetValue(1).ToString() == password)
                    {
                        ok = true;
                        MainFormProfessor mainFormProfessor = new MainFormProfessor(username, password);
                        mainFormProfessor.Show();
                        this.Close();
                    }  
                }
                if (ok == false)
                    MessageBox.Show("Username or password incorrect, verify to login as teacher or student", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
