using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDesign
{
    public partial class AdminTeacherManagementForm : Form
    {
        private DataTable teacherDataTable;

        public AdminTeacherManagementForm(string adminId)
        {
            InitializeComponent();
        }

        private async void AdminTeacherManagementForm_Load(object sender, EventArgs e)
        {
            SetEditingControlsEnabled(false);
            await LoadTeachersAsync();
        }

        private async Task LoadTeachersAsync()
        {
            string sql = "SELECT Tno, Tname, Tsex, Tage, Tpos, Tpho FROM LYZ_Teachers";

            try
            {
                teacherDataTable = await DataAccessHelper.GetDataTableAsync(sql);
                dgvTeachers.DataSource = teacherDataTable;
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载教师列表失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null && dgvTeachers.CurrentRow.DataBoundItem is DataRowView rowView)
            {
                SetEditingControlsEnabled(true);
                txtTeacherId.Text = rowView["Tno"].ToString();
                txtTeacherName.Text = rowView["Tname"].ToString();
                txtSex.Text = rowView["Tsex"].ToString();
                txtAge.Text = rowView["Tage"].ToString();
                txtPosition.Text = rowView["Tpos"].ToString();
                txtPhone.Text = rowView["Tpho"].ToString();

                txtTeacherId.ReadOnly = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrWhiteSpace(txtTeacherId.Text) || string.IsNullOrWhiteSpace(txtTeacherName.Text))
            {
                MessageBox.Show("教师编号和姓名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("年龄必须是有效的数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTeacherId.ReadOnly)
            {
                string sql = "UPDATE LYZ_Teachers SET Tname=@Tname, Tsex=@Tsex, Tage=@Tage, Tpos=@Tpos, Tpho=@Tpho WHERE Tno=@Tno";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Tname", txtTeacherName.Text),
                    new MySqlParameter("@Tsex", txtSex.Text),
                    new MySqlParameter("@Tage", int.Parse(txtAge.Text)),
                    new MySqlParameter("@Tpos", txtPosition.Text),
                    new MySqlParameter("@Tpho", txtPhone.Text),
                    new MySqlParameter("@Tno", txtTeacherId.Text)
                };
                await ExecuteDbOperation(sql, parameters, "更新");
            }
            else
            {
                string sql = "INSERT INTO LYZ_Teachers (Tno, Tname, Tsex, Tage, Tpos, Tpho) VALUES (@Tno, @Tname, @Tsex, @Tage, @Tpos, @Tpho)";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Tno", txtTeacherId.Text),
                    new MySqlParameter("@Tname", txtTeacherName.Text),
                    new MySqlParameter("@Tsex", txtSex.Text),
                    new MySqlParameter("@Tage", int.Parse(txtAge.Text)),
                    new MySqlParameter("@Tpos", txtPosition.Text),
                    new MySqlParameter("@Tpho", txtPhone.Text)
                };
                await ExecuteDbOperation(sql, parameters, "新增");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null)
            {
                MessageBox.Show("请先选择要删除的教师！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherId = txtTeacherId.Text;
            if (MessageBox.Show($"确定要删除教师【{txtTeacherName.Text}】(编号: {teacherId}) 吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM LYZ_Teachers WHERE Tno = @Tno";
                var parameter = new MySqlParameter("@Tno", teacherId);
                await ExecuteDbOperation(sql, new[] { parameter }, "删除");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearAndEnableEditingControls();
            txtTeacherId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                teacherDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                teacherDataTable.DefaultView.RowFilter = $"Tname LIKE '%{filter}%' OR Tno LIKE '%{filter}%'";
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
                    await LoadTeachersAsync();
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
                    MessageBox.Show($"{operationName}失败: 教师编号 '{txtTeacherId.Text}' 已存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{operationName}失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetEditingControlsEnabled(bool enabled)
        {
            txtTeacherId.Enabled = enabled;
            txtTeacherName.Enabled = enabled;
            txtSex.Enabled = enabled;
            txtAge.Enabled = enabled;
            txtPosition.Enabled = enabled;
            txtPhone.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnDelete.Enabled = enabled;
        }

        private void ClearAndEnableEditingControls(bool enable = true)
        {
            SetEditingControlsEnabled(enable);
            txtTeacherId.ReadOnly = false;
            txtTeacherId.Clear();
            txtTeacherName.Clear();
            txtSex.Text = "";
            txtAge.Clear();
            txtPosition.Clear();
            txtPhone.Clear();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvTeachers.Columns["Tno"] != null) dgvTeachers.Columns["Tno"].HeaderText = "教师编号";
            if (dgvTeachers.Columns["Tname"] != null) dgvTeachers.Columns["Tname"].HeaderText = "姓名";
            if (dgvTeachers.Columns["Tsex"] != null) dgvTeachers.Columns["Tsex"].HeaderText = "性别";
            if (dgvTeachers.Columns["Tage"] != null) dgvTeachers.Columns["Tage"].HeaderText = "年龄";
            if (dgvTeachers.Columns["Tpos"] != null) dgvTeachers.Columns["Tpos"].HeaderText = "职称";
            if (dgvTeachers.Columns["Tpho"] != null) dgvTeachers.Columns["Tpho"].HeaderText = "联系方式";
        }
    }
}