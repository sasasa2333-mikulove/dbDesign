using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class AdminStudentManagementForm : Form
    {
        private DataTable studentDataTable;

        public AdminStudentManagementForm(string adminId)
        {
            InitializeComponent();
        }

        private async void AdminStudentManagementForm_Load(object sender, EventArgs e)
        {
            SetEditingControlsEnabled(false);
            await LoadStudentsAsync();
        }

        private async Task LoadStudentsAsync()
        {
            string sql = "SELECT Sno, Sname, Ssex, Sage, Sorig, Ssum, Clno FROM LYZ_Students";
            try
            {
                studentDataTable = await DataAccessHelper.GetDataTableAsync(sql);
                dgvStudents.DataSource = studentDataTable;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载学生列表失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null && dgvStudents.CurrentRow.DataBoundItem is DataRowView rowView)
            {
                SetEditingControlsEnabled(true);
                txtStudentId.Text = rowView["Sno"].ToString();
                txtStudentName.Text = rowView["Sname"].ToString();
                txtSex.Text = rowView["Ssex"].ToString();
                txtAge.Text = rowView["Sage"].ToString();
                txtOrigin.Text = rowView["Sorig"].ToString();
                txtCredits.Text = rowView["Ssum"].ToString();
                txtClassId.Text = rowView["Clno"].ToString();

                txtStudentId.ReadOnly = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtClassId.Text))
            {
                MessageBox.Show("学号、姓名和班级不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("年龄必须是有效的数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtStudentId.ReadOnly)
            {
                string sql = "UPDATE LYZ_Students SET Sname=@Sname, Ssex=@Ssex, Sage=@Sage, Sorig=@Sorig, Clno=@Clno WHERE Sno=@Sno";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Sname", txtStudentName.Text),
                    new MySqlParameter("@Ssex", txtSex.Text),
                    new MySqlParameter("@Sage", int.Parse(txtAge.Text)),
                    new MySqlParameter("@Sorig", txtOrigin.Text),
                    new MySqlParameter("@Clno", txtClassId.Text),
                    new MySqlParameter("@Sno", txtStudentId.Text)
                };
                await ExecuteDbOperation(sql, parameters, "更新");
            }
            else
            {
                string sql = "INSERT INTO LYZ_Students (Sno, Sname, Ssex, Sage, Sorig, Ssum, Clno) VALUES (@Sno, @Sname, @Ssex, @Sage, @Sorig, 0, @Clno)";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Sno", txtStudentId.Text),
                    new MySqlParameter("@Sname", txtStudentName.Text),
                    new MySqlParameter("@Ssex", txtSex.Text),
                    new MySqlParameter("@Sage", int.Parse(txtAge.Text)),
                    new MySqlParameter("@Sorig", txtOrigin.Text),
                    new MySqlParameter("@Clno", txtClassId.Text)
                };
                await ExecuteDbOperation(sql, parameters, "新增");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("请先选择要删除的学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentId = txtStudentId.Text;
            if (MessageBox.Show($"确定要删除学生【{txtStudentName.Text}】(学号: {studentId}) 吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM LYZ_Students WHERE Sno = @Sno";
                var parameter = new MySqlParameter("@Sno", studentId);
                await ExecuteDbOperation(sql, new[] { parameter }, "删除");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearAndEnableEditingControls();
            txtStudentId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                studentDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                studentDataTable.DefaultView.RowFilter = $"Sname LIKE '%{filter}%' OR Sno LIKE '%{filter}%'";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task ExecuteDbOperation(string sql, MySqlParameter[] parameters, string operationName)
        {
            try
            {
                int rowsAffected = await DataAccessHelper.ExecuteNonQueryAsync(sql, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{operationName}成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadStudentsAsync();
                    ClearAndEnableEditingControls(false);
                }
                else
                {
                    MessageBox.Show($"{operationName}失败，没有行受到影响。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException is MySqlException mySqlEx && mySqlEx.Number == 1062)
                {
                    MessageBox.Show($"{operationName}失败: 学号 '{txtStudentId.Text}' 已存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{operationName}失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetEditingControlsEnabled(bool enabled)
        {
            txtStudentId.Enabled = enabled;
            txtStudentName.Enabled = enabled;
            txtSex.Enabled = enabled;
            txtAge.Enabled = enabled;
            txtOrigin.Enabled = enabled;
            txtClassId.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnAddNew.Enabled = true;
        }

        private void ClearAndEnableEditingControls(bool enable = true)
        {
            SetEditingControlsEnabled(enable);
            txtStudentId.ReadOnly = false;
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtSex.Text = "";
            txtAge.Clear();
            txtOrigin.Clear();
            txtCredits.Clear();
            txtClassId.Clear();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvStudents.Columns.Contains("Sno")) dgvStudents.Columns["Sno"].HeaderText = "学号";
            if (dgvStudents.Columns.Contains("Sname")) dgvStudents.Columns["Sname"].HeaderText = "姓名";
            if (dgvStudents.Columns.Contains("Ssex")) dgvStudents.Columns["Ssex"].HeaderText = "性别";
            if (dgvStudents.Columns.Contains("Sage")) dgvStudents.Columns["Sage"].HeaderText = "年龄";
            if (dgvStudents.Columns.Contains("Sorig")) dgvStudents.Columns["Sorig"].HeaderText = "生源地";
            if (dgvStudents.Columns.Contains("Ssum")) dgvStudents.Columns["Ssum"].HeaderText = "所修学分";
            if (dgvStudents.Columns.Contains("Clno")) dgvStudents.Columns["Clno"].HeaderText = "班级编号";
        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}