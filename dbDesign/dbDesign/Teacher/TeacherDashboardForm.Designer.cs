namespace dbDesign
{
    partial class TeacherDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboardForm));
            btnLogout = new Button();
            btnChangePassword = new Button();
            btnPersonalInfo = new Button();
            btnSubmitGrades = new Button();
            btnCourseInfo = new Button();
            btnGradeRanking = new Button();
            btnGradeQuery = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Location = new Point(572, 25);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 40);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "退出";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(462, 356);
            btnChangePassword.Margin = new Padding(4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(139, 72);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "修改密码";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnPersonalInfo
            // 
            btnPersonalInfo.Location = new Point(76, 101);
            btnPersonalInfo.Margin = new Padding(4);
            btnPersonalInfo.Name = "btnPersonalInfo";
            btnPersonalInfo.Size = new Size(139, 72);
            btnPersonalInfo.TabIndex = 0;
            btnPersonalInfo.Text = "个人信息";
            btnPersonalInfo.UseVisualStyleBackColor = true;
            btnPersonalInfo.Click += btnPersonalInfo_Click;
            // 
            // btnSubmitGrades
            // 
            btnSubmitGrades.Location = new Point(76, 356);
            btnSubmitGrades.Margin = new Padding(4);
            btnSubmitGrades.Name = "btnSubmitGrades";
            btnSubmitGrades.Size = new Size(139, 72);
            btnSubmitGrades.TabIndex = 4;
            btnSubmitGrades.Text = "提交学生成绩";
            btnSubmitGrades.UseVisualStyleBackColor = true;
            btnSubmitGrades.Click += btnSubmitGrades_Click;
            // 
            // btnCourseInfo
            // 
            btnCourseInfo.Location = new Point(462, 101);
            btnCourseInfo.Margin = new Padding(4);
            btnCourseInfo.Name = "btnCourseInfo";
            btnCourseInfo.Size = new Size(139, 72);
            btnCourseInfo.TabIndex = 1;
            btnCourseInfo.Text = "任课情况";
            btnCourseInfo.UseVisualStyleBackColor = true;
            btnCourseInfo.Click += btnCourseInfo_Click;
            // 
            // btnGradeRanking
            // 
            btnGradeRanking.Location = new Point(76, 224);
            btnGradeRanking.Margin = new Padding(4);
            btnGradeRanking.Name = "btnGradeRanking";
            btnGradeRanking.Size = new Size(139, 72);
            btnGradeRanking.TabIndex = 3;
            btnGradeRanking.Text = "所任课程学生排名";
            btnGradeRanking.UseVisualStyleBackColor = true;
            btnGradeRanking.Click += btnGradeRanking_Click;
            // 
            // btnGradeQuery
            // 
            btnGradeQuery.Location = new Point(462, 224);
            btnGradeQuery.Margin = new Padding(4);
            btnGradeQuery.Name = "btnGradeQuery";
            btnGradeQuery.Size = new Size(139, 72);
            btnGradeQuery.TabIndex = 2;
            btnGradeQuery.Text = "所任课程平均成绩";
            btnGradeQuery.UseVisualStyleBackColor = true;
            btnGradeQuery.Click += btnGradeQuery_Click;
            // 
            // TeacherDashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 480);
            Controls.Add(btnLogout);
            Controls.Add(btnChangePassword);
            Controls.Add(btnPersonalInfo);
            Controls.Add(btnSubmitGrades);
            Controls.Add(btnCourseInfo);
            Controls.Add(btnGradeRanking);
            Controls.Add(btnGradeQuery);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师主页";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnSubmitGrades;
        private System.Windows.Forms.Button btnCourseInfo;
        private System.Windows.Forms.Button btnGradeRanking;
        private System.Windows.Forms.Button btnGradeQuery;

    }
}