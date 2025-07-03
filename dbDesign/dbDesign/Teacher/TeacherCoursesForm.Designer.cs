namespace dbDesign
{
    partial class TeacherCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherCoursesForm));
            label1 = new Label();
            cmbSemesterFilter = new ComboBox();
            btnBack = new Button();
            btnFilter = new Button();
            dgvCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "学年：";
            // 
            // cmbSemesterFilter
            // 
            cmbSemesterFilter.FormattingEnabled = true;
            cmbSemesterFilter.Location = new Point(126, 34);
            cmbSemesterFilter.Margin = new Padding(4);
            cmbSemesterFilter.Name = "cmbSemesterFilter";
            cmbSemesterFilter.Size = new Size(280, 32);
            cmbSemesterFilter.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(724, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(471, 26);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(109, 48);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "查询";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(28, 93);
            dgvCourses.Margin = new Padding(4);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.RowTemplate.Height = 30;
            dgvCourses.Size = new Size(821, 397);
            dgvCourses.TabIndex = 3;
            // 
            // TeacherCoursesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 517);
            Controls.Add(btnBack);
            Controls.Add(dgvCourses);
            Controls.Add(btnFilter);
            Controls.Add(cmbSemesterFilter);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherCoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "任课信息查询";
            Load += TeacherCoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemesterFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}