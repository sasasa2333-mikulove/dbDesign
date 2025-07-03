using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherGradeViewForm : Form
    {
        private readonly string teacherId;

        public TeacherGradeViewForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void TeacherGradeViewForm_Load(object sender, EventArgs e)
        {
            await PopulateCoursesComboBoxAsync();
        }

        private async Task PopulateCoursesComboBoxAsync()
        {
            string sql = @"
                SELECT T2.Cno, T2.Cname 
                FROM LYZ_Tea_Cour AS T1 
                JOIN LYZ_Courses AS T2 ON T1.Cno = T2.Cno 
                WHERE T1.Tno = @Tno";
            var parameter = new MySqlParameter("@Tno", teacherId);

            try
            {
                DataTable coursesTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);

                if (coursesTable.Rows.Count > 0)
                {
                    cmbCourses.DataSource = coursesTable;
                    cmbCourses.DisplayMember = "Cname";
                    cmbCourses.ValueMember = "Cno";
                }
                else
                {
                    MessageBox.Show("您当前没有教授任何课程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnViewGrades.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载您的课程列表失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnViewGrades_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedValue == null)
            {
                MessageBox.Show("请先从列表中选择一门课程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedCourseId = cmbCourses.SelectedValue.ToString();

            string sql = "SELECT Cno, 平均分 FROM 每门平均成绩 WHERE Cno = @Cno";
            var parameter = new MySqlParameter("@Cno", selectedCourseId);

            try
            {
                DataTable avgGradeTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);
                dgvGrades.DataSource = avgGradeTable;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询平均分失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvGrades.Columns.Contains("Cno")) dgvGrades.Columns["Cno"].HeaderText = "课程编号";
            if (dgvGrades.Columns.Contains("平均分")) dgvGrades.Columns["平均分"].HeaderText = "课程平均分";
        }
    }
}