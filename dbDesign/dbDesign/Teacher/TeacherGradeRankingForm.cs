using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherGradeRankingForm : Form
    {
        private readonly string teacherId;

        public TeacherGradeRankingForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void TeacherGradeRankingForm_Load(object sender, EventArgs e)
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
                    btnViewRanking.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载您的课程列表失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnViewRanking_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedValue == null)
            {
                MessageBox.Show("请先从列表中选择一门课程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedCourseId = cmbCourses.SelectedValue.ToString();

            string sql = @"
                SELECT Sno, Sname, Score 
                FROM 学生成绩统计 
                WHERE Cno = @Cno 
                ORDER BY Score DESC";

            var parameter = new MySqlParameter("@Cno", selectedCourseId);

            try
            {
                DataTable rankingTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);

                rankingTable.Columns.Add("排名", typeof(int)).SetOrdinal(0);
                for (int i = 0; i < rankingTable.Rows.Count; i++)
                {
                    rankingTable.Rows[i]["排名"] = i + 1;
                }

                dgvRankedGrades.DataSource = rankingTable;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询成绩排名失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvRankedGrades.Columns.Contains("排名")) dgvRankedGrades.Columns["排名"].HeaderText = "排名";
            if (dgvRankedGrades.Columns.Contains("Sno")) dgvRankedGrades.Columns["Sno"].HeaderText = "学号";
            if (dgvRankedGrades.Columns.Contains("Sname")) dgvRankedGrades.Columns["Sname"].HeaderText = "姓名";
            if (dgvRankedGrades.Columns.Contains("Score")) dgvRankedGrades.Columns["Score"].HeaderText = "成绩";
        }
    }
}