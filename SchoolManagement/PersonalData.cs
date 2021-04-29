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
    public partial class PersonalDataForm : Form
    {
        string username;
        string password;
        string teacherOrStudent;
        public PersonalDataForm(string username, string password, string teacherOrStudent)
        {
            this.username = username;
            this.password = password;
            this.teacherOrStudent = teacherOrStudent;
            InitializeComponent();
        }

        private void PersonalDataForm_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection();
            DataSet dataset = new DataSet();
            connection.ConnectionString = @"server=localhost;user id=deac;pwd=0000;database=school";
            connection.Open();

            if(teacherOrStudent=="student")
            {
                MySqlDataAdapter dataAdapterStudent = new MySqlDataAdapter("SELECT username,sid,firstName,lastName,cnp,phoneNumber,mail FROM students_data", connection);
                dataAdapterStudent.Fill(dataset, "students_data");
                foreach (DataRow dataRow in dataset.Tables["students_data"].Rows)
                {
                    if(dataRow.ItemArray.GetValue(0).ToString()==username)
                    {
                        textBox1.Text = dataRow.ItemArray.GetValue(1).ToString();
                        textBox2.Text = dataRow.ItemArray.GetValue(2).ToString();
                        textBox3.Text = dataRow.ItemArray.GetValue(3).ToString();
                        textBox4.Text = dataRow.ItemArray.GetValue(4).ToString();
                        textBox6.Text = dataRow.ItemArray.GetValue(5).ToString();
                        textBox7.Text = dataRow.ItemArray.GetValue(6).ToString();
                    }
                    
                }
            }

            if (teacherOrStudent == "teacher")
            {
                MySqlDataAdapter dataAdapterTeacher = new MySqlDataAdapter("SELECT username,idTeacher,firstName,lastName,cnp,phoneNumber,mail FROM teachers_data", connection);
                dataAdapterTeacher.Fill(dataset, "teachers_data");
                foreach (DataRow dataRow in dataset.Tables["teachers_data"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(0).ToString() == username)
                    {
                        textBox1.Text = dataRow.ItemArray.GetValue(1).ToString();
                        textBox2.Text = dataRow.ItemArray.GetValue(2).ToString();
                        textBox3.Text = dataRow.ItemArray.GetValue(3).ToString();
                        textBox4.Text = dataRow.ItemArray.GetValue(4).ToString();
                        textBox6.Text = dataRow.ItemArray.GetValue(5).ToString();
                        textBox7.Text = dataRow.ItemArray.GetValue(6).ToString();
                    }
                }
            }



            


            
            
            
            

            
                

        }
    }
}
