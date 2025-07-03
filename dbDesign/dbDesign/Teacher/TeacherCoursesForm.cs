using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherCoursesForm : Form
    {
        private readonly string teacherId;
        private DataTable coursesDataTable;

        public TeacherCoursesForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void TeacherCoursesForm_Load(object sender, EventArgs e)
        {
            await LoadTeacherCoursesAsync();
        }

        private async Task LoadTeacherCoursesAsync()
        {
            string sql = @"
                SELECT T2.Cno, T2.Cname, T2.Ccredit, T2.Chour, T2.Cdate 
                FROM LYZ_Tea_Cour AS T1
                JOIN LYZ_Courses AS T2 ON T1.Cno = T2.Cno
                WHERE T1.Tno = @Tno";

            var parameter = new MySqlParameter("@Tno", teacherId);

            try
            {
                coursesDataTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);
                dgvCourses.DataSource = coursesDataTable;

                PopulateSemesterFilter();
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载任课信息失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateSemesterFilter()
        {
            cmbSemesterFilter.Items.Clear();
            cmbSemesterFilter.Items.Add("全部学期");

            if (coursesDataTable != null)
            {
                var distinctSemesters = coursesDataTable.AsEnumerable()
                                                      .Select(row => row.Field<string>("Cdate"))
                                                      .Distinct()
                                                      .OrderBy(semester => semester);

                cmbSemesterFilter.Items.AddRange(distinctSemesters.ToArray());
            }

            cmbSemesterFilter.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (coursesDataTable == null) return;

            string selectedSemester = cmbSemesterFilter.SelectedItem.ToString();

            if (selectedSemester == "全部学期")
            {
                coursesDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                coursesDataTable.DefaultView.RowFilter = $"Cdate = '{selectedSemester}'";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvCourses.Columns.Contains("Cno")) dgvCourses.Columns["Cno"].HeaderText = "课程编号";
            if (dgvCourses.Columns.Contains("Cname")) dgvCourses.Columns["Cname"].HeaderText = "课程名称";
            if (dgvCourses.Columns.Contains("Ccredit")) dgvCourses.Columns["Ccredit"].HeaderText = "学分";
            if (dgvCourses.Columns.Contains("Chour")) dgvCourses.Columns["Chour"].HeaderText = "学时";
            if (dgvCourses.Columns.Contains("Cdate")) dgvCourses.Columns["Cdate"].HeaderText = "开课学期";
        }
    }
}