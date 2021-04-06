using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainFormProfessor : Form
    {
        public MainFormProfessor()
        {

            InitializeComponent();
            customizeDesign();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
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

        private void MainForm_Load(object sender, EventArgs e)
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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSeeRemoveCourse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonalData_Click(object sender, EventArgs e)
        {
            openChildForm(new PersonalData());
        }
    }
}
