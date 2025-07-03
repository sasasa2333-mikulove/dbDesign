namespace dbDesign
{
    partial class StudentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboardForm));
            btnPersonalInfo = new Button();
            btnClassSchedule = new Button();
            btnGradeQuery = new Button();
            btnChangePassword = new Button();
            btnLogout = new Button();
            btnCourseQuery = new Button();
            SuspendLayout();
            // 
            // btnPersonalInfo
            // 
            btnPersonalInfo.BackColor = Color.White;
            btnPersonalInfo.Location = new Point(76, 101);
            btnPersonalInfo.Margin = new Padding(4);
            btnPersonalInfo.Name = "btnPersonalInfo";
            btnPersonalInfo.Size = new Size(139, 72);
            btnPersonalInfo.TabIndex = 0;
            btnPersonalInfo.Text = "个人信息";
            btnPersonalInfo.UseVisualStyleBackColor = false;
            btnPersonalInfo.Click += btnPersonalInfo_Click;
            // 
            // btnClassSchedule
            // 
            btnClassSchedule.BackColor = Color.White;
            btnClassSchedule.Location = new Point(76, 366);
            btnClassSchedule.Margin = new Padding(4);
            btnClassSchedule.Name = "btnClassSchedule";
            btnClassSchedule.Size = new Size(139, 72);
            btnClassSchedule.TabIndex = 3;
            btnClassSchedule.Text = "班级课表";
            btnClassSchedule.UseVisualStyleBackColor = false;
            btnClassSchedule.Click += btnClassSchedule_Click;
            // 
            // btnGradeQuery
            // 
            btnGradeQuery.BackColor = Color.White;
            btnGradeQuery.Location = new Point(462, 101);
            btnGradeQuery.Margin = new Padding(4);
            btnGradeQuery.Name = "btnGradeQuery";
            btnGradeQuery.Size = new Size(139, 72);
            btnGradeQuery.TabIndex = 4;
            btnGradeQuery.Text = "成绩查询";
            btnGradeQuery.UseVisualStyleBackColor = false;
            btnGradeQuery.Click += btnGradeQuery_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.White;
            btnChangePassword.Location = new Point(462, 366);
            btnChangePassword.Margin = new Padding(4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(139, 72);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "修改密码";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
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
            // btnCourseQuery
            // 
            btnCourseQuery.BackColor = Color.White;
            btnCourseQuery.Location = new Point(273, 225);
            btnCourseQuery.Margin = new Padding(4);
            btnCourseQuery.Name = "btnCourseQuery";
            btnCourseQuery.Size = new Size(139, 72);
            btnCourseQuery.TabIndex = 8;
            btnCourseQuery.Text = "所选课程及学分";
            btnCourseQuery.UseVisualStyleBackColor = false;
            btnCourseQuery.Click += btnCourseQuery_Click;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 480);
            Controls.Add(btnCourseQuery);
            Controls.Add(btnChangePassword);
            Controls.Add(btnLogout);
            Controls.Add(btnGradeQuery);
            Controls.Add(btnPersonalInfo);
            Controls.Add(btnClassSchedule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StudentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生主页";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnClassSchedule;
        private System.Windows.Forms.Button btnGradeQuery;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCourseQuery;
    }
}