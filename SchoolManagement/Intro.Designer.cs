
namespace SchoolManagement
{
    partial class Intro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoginStudent = new System.Windows.Forms.Button();
            this.btnLoginProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginStudent
            // 
            this.btnLoginStudent.BackColor = System.Drawing.Color.White;
            this.btnLoginStudent.FlatAppearance.BorderSize = 0;
            this.btnLoginStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginStudent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnLoginStudent.Location = new System.Drawing.Point(293, 368);
            this.btnLoginStudent.Name = "btnLoginStudent";
            this.btnLoginStudent.Size = new System.Drawing.Size(210, 50);
            this.btnLoginStudent.TabIndex = 0;
            this.btnLoginStudent.Text = "Login as Student";
            this.btnLoginStudent.UseVisualStyleBackColor = false;
            this.btnLoginStudent.Click += new System.EventHandler(this.btnLoginStudent_Click);
            // 
            // btnLoginProfessor
            // 
            this.btnLoginProfessor.BackColor = System.Drawing.Color.White;
            this.btnLoginProfessor.FlatAppearance.BorderSize = 0;
            this.btnLoginProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginProfessor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.btnLoginProfessor.Location = new System.Drawing.Point(535, 368);
            this.btnLoginProfessor.Name = "btnLoginProfessor";
            this.btnLoginProfessor.Size = new System.Drawing.Size(210, 50);
            this.btnLoginProfessor.TabIndex = 1;
            this.btnLoginProfessor.Text = "Login as Professor";
            this.btnLoginProfessor.UseVisualStyleBackColor = false;
            this.btnLoginProfessor.Click += new System.EventHandler(this.btnLoginProfessor_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.intro;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.btnLoginProfessor);
            this.Controls.Add(this.btnLoginStudent);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginStudent;
        private System.Windows.Forms.Button btnLoginProfessor;
    }
}