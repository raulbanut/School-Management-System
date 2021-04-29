using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainFormStudent : Form
    {
        string username;
        string password;
        public MainFormStudent(string username,string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            customizeDesign();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            panel_topMainForm.Hide();
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainFormStudent_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelSubCourses.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubCourses.Visible == true)
                panelSubCourses.Visible = false;
        }

        private void showSubMenu()
        {
            if (panelSubCourses.Visible == false)
            {
                hideSubMenu();
                panelSubCourses.Visible = true;
            }
            else
                panelSubCourses.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonalData_Click(object sender, EventArgs e)
        {
            openChildForm(new PersonalDataForm(username, password, "student"));
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new GradesFormStudent());
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new GroupsFormStudent());
        }

        private void BtnSeeCourses_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new SeeCoursesFormStudent());
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }
    }
}
