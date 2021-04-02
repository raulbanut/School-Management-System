using System;
using System.Windows.Forms;

namespace II_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
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

        #region SubCoursesMenu
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
        #endregion SubCoursesMenu

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
