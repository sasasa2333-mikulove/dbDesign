using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherInfoForm : Form
    {
        private readonly string teacherId;

        public TeacherInfoForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void TeacherInfoForm_Load(object sender, EventArgs e)
        {
            await LoadTeacherInfoAsync();
        }

        private async Task LoadTeacherInfoAsync()
        {
            string sql = "SELECT * FROM LYZ_Teachers WHERE Tno = @Tno";
            var parameter = new MySqlParameter("@Tno", teacherId);

            try
            {
                DataTable teacherDataTable = await DataAccessHelper.GetDataTableAsync(sql, parameter);

                if (teacherDataTable != null && teacherDataTable.Rows.Count > 0)
                {
                    DataRow teacherRow = teacherDataTable.Rows[0];

                    txtTeacherId.Text = teacherRow["Tno"].ToString();
                    txtName.Text = teacherRow["Tname"].ToString();
                    txtSex.Text = teacherRow["Tsex"].ToString();
                    txtAge.Text = teacherRow["Tage"].ToString();
                    txtPosition.Text = teacherRow["Tpos"].ToString();
                    txtPhone.Text = teacherRow["Tpho"].ToString();
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
    }
}