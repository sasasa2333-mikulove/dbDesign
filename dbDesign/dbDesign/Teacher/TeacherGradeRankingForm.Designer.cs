namespace dbDesign
{
    partial class TeacherGradeRankingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradeRankingForm));
            cmbCourses = new ComboBox();
            btnBack = new Button();
            btnViewRanking = new Button();
            label1 = new Label();
            dgvRankedGrades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRankedGrades).BeginInit();
            SuspendLayout();
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(181, 52);
            cmbCourses.Margin = new Padding(4);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(252, 32);
            cmbCourses.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(727, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewRanking
            // 
            btnViewRanking.Location = new Point(502, 42);
            btnViewRanking.Margin = new Padding(4);
            btnViewRanking.Name = "btnViewRanking";
            btnViewRanking.Size = new Size(99, 53);
            btnViewRanking.TabIndex = 0;
            btnViewRanking.Text = "确定";
            btnViewRanking.UseVisualStyleBackColor = true;
            btnViewRanking.Click += btnViewRanking_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 2;
            label1.Text = "选择课程：";
            // 
            // dgvRankedGrades
            // 
            dgvRankedGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankedGrades.Location = new Point(22, 117);
            dgvRankedGrades.Margin = new Padding(4);
            dgvRankedGrades.Name = "dgvRankedGrades";
            dgvRankedGrades.RowHeadersWidth = 62;
            dgvRankedGrades.RowTemplate.Height = 30;
            dgvRankedGrades.Size = new Size(825, 325);
            dgvRankedGrades.TabIndex = 3;
            // 
            // TeacherGradeRankingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 468);
            Controls.Add(btnBack);
            Controls.Add(dgvRankedGrades);
            Controls.Add(btnViewRanking);
            Controls.Add(label1);
            Controls.Add(cmbCourses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherGradeRankingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "所任课程学生成绩排名";
            Load += TeacherGradeRankingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRankedGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewRanking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRankedGrades;
    }
}