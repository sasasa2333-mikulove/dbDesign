using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace dbDesign
{
    public partial class AdminStudentOriginStatsForm : Form
    {
        private DataTable statsDataTable;

        public AdminStudentOriginStatsForm(string adminId)
        {
            InitializeComponent();
        }

        private async void AdminStudentOriginStatsForm_Load(object sender, EventArgs e)
        {
            await LoadOriginStatsAsync();
        }

        private async Task LoadOriginStatsAsync()
        {
            string sql = "SELECT Sorig, 数量 FROM 生源地人员统计";
            try
            {
                statsDataTable = await DataAccessHelper.GetDataTableAsync(sql);
                dgvStats.DataSource = statsDataTable;

                PopulateFilterComboBox();
                BeautifyColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载生源地统计数据失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFilterComboBox()
        {
            cmbOriginFilter.Items.Clear();
            cmbOriginFilter.Items.Add("全部地区");

            if (statsDataTable != null)
            {
                var distinctOrigins = statsDataTable.AsEnumerable()
                                                    .Select(row => row.Field<string>("Sorig"))
                                                    .Distinct()
                                                    .OrderBy(origin => origin);

                cmbOriginFilter.Items.AddRange(distinctOrigins.ToArray());
            }

            cmbOriginFilter.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (statsDataTable == null)
            {
                MessageBox.Show("没有可供筛选的数据。");
                return;
            }

            if (cmbOriginFilter.SelectedItem == null)
            {
                MessageBox.Show("请先从下拉框中选择一个地区。");
                return;
            }

            string selectedOrigin = cmbOriginFilter.SelectedItem.ToString();

            if (selectedOrigin == "全部地区")
            {
                statsDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                statsDataTable.DefaultView.RowFilter = $"Sorig = '{selectedOrigin}'";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeautifyColumnHeaders()
        {
            if (dgvStats.Columns.Contains("Sorig"))
            {
                dgvStats.Columns["Sorig"].HeaderText = "地区";
            }
            if (dgvStats.Columns.Contains("数量"))
            {
                dgvStats.Columns["数量"].HeaderText = "总数";
            }
        }
    }
}