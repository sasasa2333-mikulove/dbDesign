using System;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class StudentDashboardForm : Form
    {
        private readonly string studentId;

        public StudentDashboardForm(string userId)
        {
            InitializeComponent();
            studentId = userId;
        }

        private void OpenForm(Form formToOpen)
        {
            formToOpen.FormClosed += (s, args) => this.Show();
            this.Hide();
            formToOpen.Show();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentInfoForm(studentId));
        }

        private void btnCourseQuery_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentCoursesForm(studentId));
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new ClassScheduleForm(studentId));
        }

        private void btnGradeQuery_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentGradesForm(studentId));
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentChangePasswordForm(studentId));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}