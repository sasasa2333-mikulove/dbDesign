namespace dbDesign
{
    partial class TeacherGradeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradeManagementForm));
            btnSaveChanges = new Button();
            cmbCourses = new ComboBox();
            label1 = new Label();
            dgvGrades = new DataGridView();
            btnLoadGrades = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(596, 29);
            btnSaveChanges.Margin = new Padding(4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(110, 52);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "保存成绩";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(154, 40);
            cmbCourses.Margin = new Padding(4);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(230, 32);
            cmbCourses.TabIndex = 2;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 3;
            label1.Text = "选择课程：";
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(27, 111);
            dgvGrades.Margin = new Padding(4);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.RowHeadersWidth = 62;
            dgvGrades.RowTemplate.Height = 30;
            dgvGrades.Size = new Size(899, 308);
            dgvGrades.TabIndex = 4;
            dgvGrades.CellValueChanged += dgvGrades_CellValueChanged;
            // 
            // btnLoadGrades
            // 
            btnLoadGrades.Location = new Point(448, 29);
            btnLoadGrades.Margin = new Padding(4);
            btnLoadGrades.Name = "btnLoadGrades";
            btnLoadGrades.Size = new Size(110, 52);
            btnLoadGrades.TabIndex = 5;
            btnLoadGrades.Text = "确认";
            btnLoadGrades.UseVisualStyleBackColor = true;
            btnLoadGrades.Click += btnLoadGrades_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(801, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 6;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // TeacherGradeManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 441);
            Controls.Add(btnBack);
            Controls.Add(btnLoadGrades);
            Controls.Add(dgvGrades);
            Controls.Add(label1);
            Controls.Add(cmbCourses);
            Controls.Add(btnSaveChanges);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherGradeManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "提交学生成绩";
            Load += TeacherGradeManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Button btnLoadGrades;
        private System.Windows.Forms.Button btnBack;
    }
}