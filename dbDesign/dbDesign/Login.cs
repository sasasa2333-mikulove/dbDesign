using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();
            string password = textBox2.Text;
            string userType = comboBox1.Text;

            if (string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户身份、账号或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            button1.Enabled = false;
            button1.Text = "登录中...";

            try
            {
                bool loginSuccess = await AuthenticateUserAsync(userType, userId, password);

                if (loginSuccess)
                {
                    MessageBox.Show("登录验证成功！");
                    this.Hide();

                    switch (userType)
                    {
                        case "学生":
                            var studentForm = new StudentDashboardForm(userId);
                            studentForm.FormClosed += (s, args) => this.Show();
                            studentForm.Show();
                            break;
                        case "教师":
                            var teacherForm = new TeacherDashboardForm(userId);
                            teacherForm.FormClosed += (s, args) => this.Show();
                            teacherForm.Show();
                            break;
                        case "管理员":
                            var adminForm = new AdminDashboardForm(userId);
                            adminForm.FormClosed += (s, args) => this.Show();
                            adminForm.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("输入的身份、账号或密码有误！请重新输入！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录过程中发生错误: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button1.Enabled = true;
                button1.Text = "登录";
            }
        }

        private async Task<bool> AuthenticateUserAsync(string userType, string userId, string password)
        {
            string sql;
            string idColumn;
            string keyColumn;
            string tableName;

            switch (userType)
            {
                case "学生":
                    tableName = "LYZ_Students_account";
                    idColumn = "Sno";
                    keyColumn = "Skey";
                    break;
                case "教师":
                    tableName = "LYZ_Teachers_account";
                    idColumn = "Tno";
                    keyColumn = "Tkey";
                    break;
                case "管理员":
                    tableName = "LYZ_Admin_account";
                    idColumn = "Ano";
                    keyColumn = "Akey";
                    break;
                default:
                    return false;
            }

            sql = $"SELECT COUNT(1) FROM {tableName} WHERE {idColumn} = @id AND {keyColumn} = @key";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.VarChar) { Value = userId },
                new MySqlParameter("@key", MySqlDbType.VarChar) { Value = password }
            };

            var result = await DataAccessHelper.ExecuteScalarAsync(sql, parameters);

            return result != null && Convert.ToInt32(result) > 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Login_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}