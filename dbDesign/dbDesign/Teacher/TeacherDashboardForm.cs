using System;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherDashboardForm : Form
    {
        private readonly string teacherId;

        public TeacherDashboardForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private void OpenForm(Form formToOpen)
        {
            formToOpen.FormClosed += (s, args) => this.Show();

            this.Hide();
            formToOpen.Show();
        }


        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherInfoForm(teacherId));
        }

        private void btnCourseInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherCoursesForm(teacherId));
        }

        private void btnGradeQuery_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherGradeViewForm(teacherId));
        }

        private void btnGradeRanking_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherGradeRankingForm(teacherId));
        }

        private void btnSubmitGrades_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherGradeManagementForm(teacherId));
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenForm(new TeacherChangePasswordForm(teacherId));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}