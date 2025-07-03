using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class ClassScheduleForm : Form
    {
        private readonly string studentId;

        public ClassScheduleForm(string userId)
        {
            InitializeComponent();
            studentId = userId;
        }

        private async void ClassScheduleForm_Load(object sender, EventArgs e)
        {
            await LoadClassScheduleAsync();
        }

        private async Task LoadClassScheduleAsync()
        {
            try
            {
                string findClassSql = @"
                    SELECT T2.Clno, T2.Clname 
                    FROM LYZ_Students AS T1 
                    JOIN LYZ_Class AS T2 ON T1.Clno = T2.Clno 
                    WHERE T1.Sno = @Sno";

                var studentParam = new MySqlParameter("@Sno", studentId);
                DataTable classInfoTable = await DataAccessHelper.GetDataTableAsync(findClassSql, studentParam);

                if (classInfoTable == null || classInfoTable.Rows.Count == 0)
                {
                    lblClassNameInfo.Text = "未能找到你的班级信息";
                    return;
                }

                string classId = classInfoTable.Rows[0]["Clno"].ToString();
                string className = classInfoTable.Rows[0]["Clname"].ToString();
                lblClassNameInfo.Text = $"{className} 的课程表";

                string scheduleSql = "SELECT Cno, Cname, Cdate, Ccredit, Chour FROM 班级课表 WHERE Clno = @Clno";
                var classParam = new MySqlParameter("@Clno", classId);
                DataTable scheduleTable = await DataAccessHelper.GetDataTableAsync(scheduleSql, classParam);

                dgvSchedule.DataSource = scheduleTable;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载班级课表失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvSchedule.Columns.Contains("Cno")) dgvSchedule.Columns["Cno"].HeaderText = "课程编号";
            if (dgvSchedule.Columns.Contains("Cname")) dgvSchedule.Columns["Cname"].HeaderText = "课程名称";
            if (dgvSchedule.Columns.Contains("Cdate")) dgvSchedule.Columns["Cdate"].HeaderText = "开课学期";
            if (dgvSchedule.Columns.Contains("Ccredit")) dgvSchedule.Columns["Ccredit"].HeaderText = "学分";
            if (dgvSchedule.Columns.Contains("Chour")) dgvSchedule.Columns["Chour"].HeaderText = "学时";
        }
    }
}