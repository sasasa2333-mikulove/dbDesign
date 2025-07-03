using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class TeacherChangePasswordForm : Form
    {
        private readonly string teacherId;

        public TeacherChangePasswordForm(string userId)
        {
            InitializeComponent();
            teacherId = userId;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("所有密码字段都不能为空！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("新密码和确认密码不匹配，请重新输入。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
                txtNewPassword.Focus();
                return;
            }

            if (newPassword == oldPassword)
            {
                MessageBox.Show("新密码不能与旧密码相同。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSaveChanges.Enabled = false;

            try
            {
                bool isOldPasswordCorrect = await VerifyCurrentPasswordAsync(oldPassword);

                if (!isOldPasswordCorrect)
                {
                    MessageBox.Show("原密码错误，请重新输入。", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.SelectAll();
                    txtOldPassword.Focus();
                    return;
                }

                int rowsAffected = await UpdatePasswordInDatabaseAsync(newPassword);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("密码修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改失败，未知的错误。", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("处理密码修改时发生错误: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSaveChanges.Enabled = true;
            }
        }

        private async Task<bool> VerifyCurrentPasswordAsync(string password)
        {
            string sql = "SELECT COUNT(1) FROM LYZ_Teachers_account WHERE Tno = @Tno AND Tkey = @Tkey";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Tno", teacherId),
                new MySqlParameter("@Tkey", password)
            };

            var result = await DataAccessHelper.ExecuteScalarAsync(sql, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }

        private async Task<int> UpdatePasswordInDatabaseAsync(string newPassword)
        {
            string sql = "UPDATE LYZ_Teachers_account SET Tkey = @NewTkey WHERE Tno = @Tno";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@NewTkey", newPassword),
                new MySqlParameter("@Tno", teacherId)
            };

            return await DataAccessHelper.ExecuteNonQueryAsync(sql, parameters);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}