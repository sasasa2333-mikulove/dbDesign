namespace dbDesign
{
    partial class StudentGradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradesForm));
            label1 = new Label();
            cmbSemesterFilter = new ComboBox();
            btnFilter = new Button();
            btnBack = new Button();
            dgvGrades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "学期选择";
            // 
            // cmbSemesterFilter
            // 
            cmbSemesterFilter.FormattingEnabled = true;
            cmbSemesterFilter.Location = new Point(244, 43);
            cmbSemesterFilter.Name = "cmbSemesterFilter";
            cmbSemesterFilter.Size = new Size(246, 32);
            cmbSemesterFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(566, 34);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(125, 49);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "确定";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(830, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(26, 105);
            dgvGrades.Margin = new Padding(4);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.RowHeadersWidth = 62;
            dgvGrades.RowTemplate.Height = 30;
            dgvGrades.Size = new Size(925, 361);
            dgvGrades.TabIndex = 5;
            // 
            // StudentGradesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 513);
            Controls.Add(cmbSemesterFilter);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnFilter);
            Controls.Add(dgvGrades);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StudentGradesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "成绩查询";
            Load += StudentGradesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemesterFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvGrades;
    }
}