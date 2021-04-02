
namespace SchoolManagement
{
    partial class MainFormProfessor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSubCourses = new System.Windows.Forms.Panel();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnSeeRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnPersonalData = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelSubCourses.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.panelSubCourses);
            this.panelMain.Controls.Add(this.btnCourses);
            this.panelMain.Controls.Add(this.btnPersonalData);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(219, 644);
            this.panelMain.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(219, 55);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSubCourses
            // 
            this.panelSubCourses.Controls.Add(this.btnGrades);
            this.panelSubCourses.Controls.Add(this.btnGroups);
            this.panelSubCourses.Controls.Add(this.btnSeeRemoveCourse);
            this.panelSubCourses.Controls.Add(this.btnAddCourse);
            this.panelSubCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCourses.Location = new System.Drawing.Point(0, 231);
            this.panelSubCourses.Name = "panelSubCourses";
            this.panelSubCourses.Size = new System.Drawing.Size(219, 220);
            this.panelSubCourses.TabIndex = 3;
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrades.FlatAppearance.BorderSize = 0;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.Location = new System.Drawing.Point(0, 165);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGrades.Size = new System.Drawing.Size(219, 55);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "Grades";
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.ForeColor = System.Drawing.Color.White;
            this.btnGroups.Location = new System.Drawing.Point(0, 110);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGroups.Size = new System.Drawing.Size(219, 55);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnSeeRemoveCourse
            // 
            this.btnSeeRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnSeeRemoveCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeRemoveCourse.FlatAppearance.BorderSize = 0;
            this.btnSeeRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnSeeRemoveCourse.Location = new System.Drawing.Point(0, 55);
            this.btnSeeRemoveCourse.Name = "btnSeeRemoveCourse";
            this.btnSeeRemoveCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSeeRemoveCourse.Size = new System.Drawing.Size(219, 55);
            this.btnSeeRemoveCourse.TabIndex = 1;
            this.btnSeeRemoveCourse.Text = "See/Remove course";
            this.btnSeeRemoveCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeRemoveCourse.UseVisualStyleBackColor = false;
            this.btnSeeRemoveCourse.Click += new System.EventHandler(this.btnSeeRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnAddCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(0, 0);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddCourse.Size = new System.Drawing.Size(219, 55);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add course";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(0, 176);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(219, 55);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnPersonalData
            // 
            this.btnPersonalData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnPersonalData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonalData.FlatAppearance.BorderSize = 0;
            this.btnPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalData.ForeColor = System.Drawing.Color.White;
            this.btnPersonalData.Location = new System.Drawing.Point(0, 121);
            this.btnPersonalData.Name = "btnPersonalData";
            this.btnPersonalData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPersonalData.Size = new System.Drawing.Size(219, 55);
            this.btnPersonalData.TabIndex = 1;
            this.btnPersonalData.Text = "Personal Data";
            this.btnPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalData.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(219, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "TUCN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // MainFormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainFormProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelSubCourses.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSubCourses;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnSeeRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnPersonalData;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

