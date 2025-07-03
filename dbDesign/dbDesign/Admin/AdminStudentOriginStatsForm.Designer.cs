namespace dbDesign
{
    partial class AdminStudentOriginStatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentOriginStatsForm));
            label1 = new Label();
            cmbOriginFilter = new ComboBox();
            btnFilter = new Button();
            btnBack = new Button();
            dgvStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 0;
            label1.Text = "选择生源地：";
            // 
            // cmbOriginFilter
            // 
            cmbOriginFilter.FormattingEnabled = true;
            cmbOriginFilter.Items.AddRange(new object[] { "浙江", "江苏", "江西", "安徽", "北京", "福建", "湖南" });
            cmbOriginFilter.Location = new Point(203, 48);
            cmbOriginFilter.Margin = new Padding(4);
            cmbOriginFilter.Name = "cmbOriginFilter";
            cmbOriginFilter.Size = new Size(147, 32);
            cmbOriginFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(418, 37);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(138, 53);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "查询";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(600, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvStats
            // 
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Location = new Point(30, 123);
            dgvStats.Margin = new Padding(4);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 62;
            dgvStats.RowTemplate.Height = 30;
            dgvStats.Size = new Size(574, 307);
            dgvStats.TabIndex = 6;
            // 
            // AdminStudentOriginStatsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 470);
            Controls.Add(dgvStats);
            Controls.Add(btnBack);
            Controls.Add(btnFilter);
            Controls.Add(cmbOriginFilter);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminStudentOriginStatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "生源地统计";
            Load += AdminStudentOriginStatsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOriginFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvStats;
    }
}