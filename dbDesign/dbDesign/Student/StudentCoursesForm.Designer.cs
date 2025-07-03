namespace dbDesign
{
    partial class StudentCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCoursesForm));
            btnBack = new Button();
            dgvCourses = new DataGridView();
            label1 = new Label();
            txtTotalCredits = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(649, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(23, 89);
            dgvCourses.Margin = new Padding(4);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.RowTemplate.Height = 30;
            dgvCourses.Size = new Size(753, 377);
            dgvCourses.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 2;
            label1.Text = "总学分：";
            // 
            // txtTotalCredits
            // 
            txtTotalCredits.BorderStyle = BorderStyle.None;
            txtTotalCredits.Location = new Point(155, 30);
            txtTotalCredits.Margin = new Padding(4);
            txtTotalCredits.Name = "txtTotalCredits";
            txtTotalCredits.ReadOnly = true;
            txtTotalCredits.Size = new Size(121, 23);
            txtTotalCredits.TabIndex = 3;
            // 
            // StudentCoursesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 512);
            Controls.Add(txtTotalCredits);
            Controls.Add(label1);
            Controls.Add(dgvCourses);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StudentCoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "所选课程及学分查询";
            Load += StudentCoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCredits;
    }
}