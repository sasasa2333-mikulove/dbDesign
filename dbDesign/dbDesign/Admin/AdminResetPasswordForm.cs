using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class AdminResetPasswordForm : Form
    {
        public AdminResetPasswordForm(string adminId)
        {
            InitializeComponent();
        }

        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedItem == null)
            {
                MessageBox.Show("请选择要重置密码的用户类型（学生或教师）。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("用户ID和新密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnResetPassword.Enabled = false;
            string userType = cmbUserType.SelectedItem.ToString();
            string userId = txtUserId.Text;
            string newPassword = txtNewPassword.Text;

            string tableName;
            string idColumnName;
            string keyColumnName;

            switch (userType)
            {
                case "学生":
                    tableName = "LYZ_Students_account";
                    idColumnName = "Sno";
                    keyColumnName = "Skey";
                    break;
                case "教师":
                    tableName = "LYZ_Teachers_account";
                    idColumnName = "Tno";
                    keyColumnName = "Tkey";
                    break;
                default:
                    MessageBox.Show("无效的用户类型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnResetPassword.Enabled = true;
                    return;
            }

            try
            {
                string sql = $"UPDATE {tableName} SET {keyColumnName} = @NewPassword WHERE {idColumnName} = @UserId";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@NewPassword", newPassword),
                    new MySqlParameter("@UserId", userId)
                };

                int rowsAffected = await DataAccessHelper.ExecuteNonQueryAsync(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{userType} {userId} 的密码已成功重置！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserId.Clear();
                    txtNewPassword.Clear();
                }
                else
                {
                    MessageBox.Show($"密码重置失败：未在 {userType} 列表中找到ID为 {userId} 的用户。", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败: " + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnResetPassword.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}