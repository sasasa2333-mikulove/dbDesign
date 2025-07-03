using System;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class AdminDashboardForm : Form
    {
        private readonly string adminId;

        public AdminDashboardForm(string userId)
        {
            InitializeComponent();
            adminId = userId;
        }

        private void OpenForm(Form formToOpen)
        {
            formToOpen.FormClosed += (s, args) => this.Show();
            this.Hide();
            formToOpen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminTeacherManagementForm(adminId));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminStudentManagementForm(adminId));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminStudentOriginStatsForm(adminId));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminChangePasswordForm(adminId));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminResetPasswordForm(adminId));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}