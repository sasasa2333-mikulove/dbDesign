using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class StudentGradesForm : Form
    {
        private readonly string studentId;
        private DataTable gradesDataTable;

        public StudentGradesForm(string userId)
        {
            InitializeComponent();
            studentId = userId;
        }

        private async void StudentGradesForm_Load(object sender, EventArgs e)
        {
            await LoadAllGradesAsync();
        }

        private async Task LoadAllGradesAsync()
        {
            string sql = @"
                SELECT Cname, Clname, Tname, Ccredit, Cdate, Score 
                FROM 学生成绩统计 
                WHERE Sno = @Sno";

            var parameter = new MySqlParameter("@Sno", studentId);

            try
            {
                gradesDataTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);
                dgvGrades.DataSource = gradesDataTable;

                PopulateSemesterFilter();
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载成绩失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateSemesterFilter()
        {
            cmbSemesterFilter.Items.Clear();
            cmbSemesterFilter.Items.Add("全部学期");

            if (gradesDataTable != null)
            {
                var distinctSemesters = gradesDataTable.AsEnumerable()
                                                      .Select(row => row.Field<string>("Cdate"))
                                                      .Distinct()
                                                      .OrderBy(semester => semester);

                cmbSemesterFilter.Items.AddRange(distinctSemesters.ToArray());
            }

            cmbSemesterFilter.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (gradesDataTable == null) return;

            string selectedSemester = cmbSemesterFilter.SelectedItem.ToString();

            if (selectedSemester == "全部学期")
            {
                gradesDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                gradesDataTable.DefaultView.RowFilter = $"Cdate = '{selectedSemester}'";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvGrades.Columns.Contains("Cname")) dgvGrades.Columns["Cname"].HeaderText = "课程名称";
            if (dgvGrades.Columns.Contains("Clname")) dgvGrades.Columns["Clname"].HeaderText = "班级名称";
            if (dgvGrades.Columns.Contains("Tname")) dgvGrades.Columns["Tname"].HeaderText = "任课教师";
            if (dgvGrades.Columns.Contains("Ccredit")) dgvGrades.Columns["Ccredit"].HeaderText = "学分";
            if (dgvGrades.Columns.Contains("Cdate")) dgvGrades.Columns["Cdate"].HeaderText = "学期";
            if (dgvGrades.Columns.Contains("Score")) dgvGrades.Columns["Score"].HeaderText = "成绩";
        }
    }
}