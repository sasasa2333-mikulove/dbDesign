using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherGradeManagementForm : Form
    {
        private readonly string teacherId;
        private string teacherName;
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();

        public TeacherGradeManagementForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void TeacherGradeManagementForm_Load(object sender, EventArgs e)
        {
            await LoadTeacherInfoAndCoursesAsync();
        }

        private async Task LoadTeacherInfoAndCoursesAsync()
        {
            // 获取教师姓名
            try
            {
                var nameResult = await DataAccessHelper.ExecuteScalarAsync("SELECT Tname FROM LYZ_Teachers WHERE Tno = @Tno", new MySqlParameter("@Tno", teacherId));
                if (nameResult != null) teacherName = nameResult.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法获取您的教师信息: " + ex.Message);
                this.Close();
                return;
            }

            // 填充课程下拉框
            string sql = @"SELECT T2.Cno, T2.Cname FROM LYZ_Tea_Cour AS T1 JOIN LYZ_Courses AS T2 ON T1.Cno = T2.Cno WHERE T1.Tno = @Tno";
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
                    MessageBox.Show("您当前没有教授任何课程。");
                    btnLoadGrades.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载课程列表失败: " + ex.Message);
            }
        }

        private async void btnLoadGrades_Click(object sender, EventArgs e)
        {
            await LoadGradesForCourseAsync();
        }

        private async Task LoadGradesForCourseAsync()
        {
            if (cmbCourses.SelectedValue == null) return;
            string courseId = cmbCourses.SelectedValue.ToString();

            // **核心修正：这才是正确的SQL查询，它能找到所有应该上这门课的学生**
            string sql = @"
                SELECT s.Sno, s.Sname, r.Score
                FROM LYZ_Students s
                INNER JOIN LYZ_Class_Cour cc ON s.Clno = cc.Clno
                LEFT JOIN LYZ_Reports r ON s.Sno = r.Sno AND r.Cno = cc.Cno
                WHERE cc.Cno = @Cno";

            var parameter = new MySqlParameter("@Cno", courseId);

            try
            {
                modifiedRows.Clear();
                DataTable dt = await DataAccessHelper.GetDataTableAsync(sql, parameter);
                dgvGrades.DataSource = dt;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载学生成绩列表失败: " + ex.Message);
            }
        }

        private void dgvGrades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow changedRow = dgvGrades.Rows[e.RowIndex];
            if (!modifiedRows.Contains(changedRow))
            {
                modifiedRows.Add(changedRow);
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (modifiedRows.Count == 0)
            {
                MessageBox.Show("没有任何成绩被修改，无需保存。");
                return;
            }

            string courseId = cmbCourses.SelectedValue.ToString();
            int successCount = 0;

            foreach (DataGridViewRow row in modifiedRows)
            {
                string studentId = row.Cells["Sno"].Value.ToString();
                if (!float.TryParse(Convert.ToString(row.Cells["Score"].Value), out float score))
                {
                    MessageBox.Show($"学号 {studentId} 的成绩无效，已跳过。");
                    continue;
                }

                string procedureName = "输入成绩自动生成学分";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("p_Sno", studentId),
                    new MySqlParameter("p_Cno", courseId),
                    new MySqlParameter("p_Score", score),
                    new MySqlParameter("p_Date", DateTime.Now.ToString("yyyy-MM-dd")),
                    new MySqlParameter("p_Tname", this.teacherName)
                };

                try
                {
                    await DataAccessHelper.ExecuteNonQueryAsync(procedureName, parameters, CommandType.StoredProcedure);
                    successCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存学号 {studentId} 的成绩时失败: {ex.Message}");
                }
            }

            MessageBox.Show($"处理完成！共成功保存 {successCount} 条被修改的成绩记录。", "操作成功");
            modifiedRows.Clear();
            await LoadGradesForCourseAsync(); // 刷新列表
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvGrades.Columns.Contains("Sno")) dgvGrades.Columns["Sno"].HeaderText = "学号";
            if (dgvGrades.Columns.Contains("Sname")) dgvGrades.Columns["Sname"].HeaderText = "姓名";
            if (dgvGrades.Columns.Contains("Score")) dgvGrades.Columns["Score"].HeaderText = "成绩";
            if (dgvGrades.Columns.Contains("Sno")) dgvGrades.Columns["Sno"].ReadOnly = true;
            if (dgvGrades.Columns.Contains("Sname")) dgvGrades.Columns["Sname"].ReadOnly = true;
            if (dgvGrades.Columns.Contains("Score")) dgvGrades.Columns["Score"].ReadOnly = false;
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}