
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
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSubCourses = new System.Windows.Forms.Panel();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnSeeCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnPersonalData = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_topMainForm = new System.Windows.Forms.Panel();
            this.labelPersonalData = new System.Windows.Forms.Label();
            this.panelSlide.SuspendLayout();
            this.panelSubCourses.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel_topMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.panelSlide.Controls.Add(this.btnExit);
            this.panelSlide.Controls.Add(this.panelSubCourses);
            this.panelSlide.Controls.Add(this.btnCourses);
            this.panelSlide.Controls.Add(this.btnPersonalData);
            this.panelSlide.Controls.Add(this.panelLogo);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(220, 844);
            this.panelSlide.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 55);
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
            this.panelSubCourses.Controls.Add(this.btnSeeCourse);
            this.panelSubCourses.Controls.Add(this.btnAddCourse);
            this.panelSubCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCourses.Location = new System.Drawing.Point(0, 230);
            this.panelSubCourses.Name = "panelSubCourses";
            this.panelSubCourses.Size = new System.Drawing.Size(220, 220);
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
            this.btnGrades.Size = new System.Drawing.Size(220, 55);
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
            this.btnGroups.Size = new System.Drawing.Size(220, 55);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnSeeCourse
            // 
            this.btnSeeCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnSeeCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeCourse.FlatAppearance.BorderSize = 0;
            this.btnSeeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeCourse.ForeColor = System.Drawing.Color.White;
            this.btnSeeCourse.Location = new System.Drawing.Point(0, 55);
            this.btnSeeCourse.Name = "btnSeeCourse";
            this.btnSeeCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSeeCourse.Size = new System.Drawing.Size(220, 55);
            this.btnSeeCourse.TabIndex = 1;
            this.btnSeeCourse.Text = "See courses";
            this.btnSeeCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeCourse.UseVisualStyleBackColor = false;
            this.btnSeeCourse.Click += new System.EventHandler(this.BtnSeeCourse_Click);
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
            this.btnAddCourse.Size = new System.Drawing.Size(220, 55);
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
            this.btnCourses.Location = new System.Drawing.Point(0, 175);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(220, 55);
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
            this.btnPersonalData.Location = new System.Drawing.Point(0, 120);
            this.btnPersonalData.Name = "btnPersonalData";
            this.btnPersonalData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPersonalData.Size = new System.Drawing.Size(220, 55);
            this.btnPersonalData.TabIndex = 1;
            this.btnPersonalData.Text = "Personal Data";
            this.btnPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalData.UseVisualStyleBackColor = false;
            this.btnPersonalData.Click += new System.EventHandler(this.btnPersonalData_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panel_topMainForm);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1158, 844);
            this.panelMain.TabIndex = 2;
            // 
            // panel_topMainForm
            // 
            this.panel_topMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.panel_topMainForm.Controls.Add(this.labelPersonalData);
            this.panel_topMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topMainForm.Location = new System.Drawing.Point(0, 0);
            this.panel_topMainForm.Name = "panel_topMainForm";
            this.panel_topMainForm.Size = new System.Drawing.Size(1158, 94);
            this.panel_topMainForm.TabIndex = 1;
            // 
            // labelPersonalData
            // 
            this.labelPersonalData.AutoSize = true;
            this.labelPersonalData.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelPersonalData.ForeColor = System.Drawing.Color.White;
            this.labelPersonalData.Location = new System.Drawing.Point(409, 22);
            this.labelPersonalData.Name = "labelPersonalData";
            this.labelPersonalData.Size = new System.Drawing.Size(304, 48);
            this.labelPersonalData.TabIndex = 3;
            this.labelPersonalData.Text = "Welcome to TUCN";
            // 
            // MainFormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSlide);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainFormProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormProfessor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSlide.ResumeLayout(false);
            this.panelSubCourses.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panel_topMainForm.ResumeLayout(false);
            this.panel_topMainForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSubCourses;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnSeeCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnPersonalData;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel_topMainForm;
        private System.Windows.Forms.Label labelPersonalData;
    }
}

