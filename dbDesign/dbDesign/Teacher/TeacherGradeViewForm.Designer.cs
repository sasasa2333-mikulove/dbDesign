namespace dbDesign
{
    partial class TeacherGradeViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradeViewForm));
            btnBack = new Button();
            dgvGrades = new DataGridView();
            cmbCourses = new ComboBox();
            选择课程 = new Label();
            btnViewGrades = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(579, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(27, 137);
            dgvGrades.Margin = new Padding(4);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.RowHeadersWidth = 62;
            dgvGrades.RowTemplate.Height = 30;
            dgvGrades.Size = new Size(673, 338);
            dgvGrades.TabIndex = 1;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(166, 50);
            cmbCourses.Margin = new Padding(4);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(147, 32);
            cmbCourses.TabIndex = 2;
            // 
            // 选择课程
            // 
            选择课程.Location = new Point(0, 0);
            选择课程.Name = "选择课程";
            选择课程.Size = new Size(100, 23);
            选择课程.TabIndex = 5;
            // 
            // btnViewGrades
            // 
            btnViewGrades.Location = new Point(379, 40);
            btnViewGrades.Margin = new Padding(4);
            btnViewGrades.Name = "btnViewGrades";
            btnViewGrades.Size = new Size(125, 51);
            btnViewGrades.TabIndex = 4;
            btnViewGrades.Text = "查询";
            btnViewGrades.UseVisualStyleBackColor = true;
            btnViewGrades.Click += btnViewGrades_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 6;
            label1.Text = "课程选择：";
            // 
            // TeacherGradeViewForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 499);
            Controls.Add(label1);
            Controls.Add(btnViewGrades);
            Controls.Add(选择课程);
            Controls.Add(cmbCourses);
            Controls.Add(dgvGrades);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherGradeViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "所任课程平均分查询";
            Load += TeacherGradeViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label 选择课程;
        private System.Windows.Forms.Button btnViewGrades;
        private Label label1;
    }
}