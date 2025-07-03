using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class StudentInfoForm : Form
    {
        private readonly string studentId;

        public StudentInfoForm(string userId)
        {
            InitializeComponent();
            studentId = userId;
        }

        private async void StudentInfoForm_Load(object sender, EventArgs e)
        {
            await LoadStudentInfoAsync();
        }

        private async Task LoadStudentInfoAsync()
        {
            string sql = "SELECT * FROM LYZ_Students WHERE Sno = @Sno";
            var parameter = new MySqlParameter("@Sno", studentId);

            try
            {
                DataTable studentDataTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);

                if (studentDataTable != null && studentDataTable.Rows.Count > 0)
                {
                    DataRow studentRow = studentDataTable.Rows[0];

                    txtStudentId.Text = studentRow["Sno"].ToString();
                    txtName.Text = studentRow["Sname"].ToString();
                    txtSex.Text = studentRow["Ssex"].ToString();
                    txtAge.Text = studentRow["Sage"].ToString();
                    txtOrigin.Text = studentRow["Sorig"].ToString();
                    txtCredits.Text = studentRow["Ssum"].ToString();
                    txtClassId.Text = studentRow["Clno"].ToString();
                }
                else
                {
                    MessageBox.Show("未能找到你的个人信息，请联系管理员。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载个人信息失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}