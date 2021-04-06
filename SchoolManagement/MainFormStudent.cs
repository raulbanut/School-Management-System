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
        public MainFormStudent()
        {
            InitializeComponent();
            customizeDesign();
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

        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSeeCourses_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }
    }
}
