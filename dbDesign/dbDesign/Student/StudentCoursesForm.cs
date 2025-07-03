using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class StudentCoursesForm : Form
    {
        private readonly string studentId;

        public StudentCoursesForm(string userId)
        {
            InitializeComponent();
            studentId = userId;
        }

        private async void StudentCoursesForm_Load(object sender, EventArgs e)
        {
            await LoadCourseDataAsync();
        }

        private async Task LoadCourseDataAsync()
        {
            string sql = "SELECT Cname, Ccredit FROM 课程和学分统计 WHERE Sno = @Sno";
            var parameter = new MySqlParameter("@Sno", studentId);

            try
            {
                DataTable coursesDataTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);

                dgvCourses.DataSource = coursesDataTable;
                BeautifyColumnHeaders();

                if (coursesDataTable != null && coursesDataTable.Rows.Count > 0)
                {
                    decimal totalCredits = coursesDataTable.AsEnumerable()
                                                         .Sum(row => Convert.ToDecimal(row["Ccredit"]));

                    txtTotalCredits.Text = totalCredits.ToString("F1");
                }
                else
                {
                    txtTotalCredits.Text = "0.0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载课程数据失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalCredits.Text = "加载失败";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvCourses.Columns.Contains("Cname")) dgvCourses.Columns["Cname"].HeaderText = "课程名";
            if (dgvCourses.Columns.Contains("Ccredit")) dgvCourses.Columns["Ccredit"].HeaderText = "学分";
        }
    }
}