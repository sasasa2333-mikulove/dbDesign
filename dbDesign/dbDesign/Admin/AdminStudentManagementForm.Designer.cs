namespace dbDesign
{
    partial class AdminStudentManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentManagementForm));
            txtCredits = new TextBox();
            txtOrigin = new TextBox();
            txtAge = new TextBox();
            txtSex = new TextBox();
            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            txtClassId = new TextBox();
            label7 = new Label();
            dgvStudents = new DataGridView();
            label8 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtCredits
            // 
            txtCredits.BorderStyle = BorderStyle.None;
            txtCredits.Location = new Point(155, 376);
            txtCredits.Margin = new Padding(4);
            txtCredits.Name = "txtCredits";
            txtCredits.ReadOnly = true;
            txtCredits.Size = new Size(121, 23);
            txtCredits.TabIndex = 23;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(155, 304);
            txtOrigin.Margin = new Padding(4);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(121, 30);
            txtOrigin.TabIndex = 22;
            txtOrigin.TextChanged += txtOrigin_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(155, 245);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(121, 30);
            txtAge.TabIndex = 21;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(155, 180);
            txtSex.Margin = new Padding(4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(121, 30);
            txtSex.TabIndex = 20;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(155, 115);
            txtStudentName.Margin = new Padding(4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(121, 30);
            txtStudentName.TabIndex = 19;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(155, 48);
            txtStudentId.Margin = new Padding(4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(121, 30);
            txtStudentId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 375);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 17;
            label6.Text = "已修学分：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 447);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 16;
            label5.Text = "班级编号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 304);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 15;
            label4.Text = "生源地：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 14;
            label3.Text = "年龄：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 13;
            label2.Text = "学号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 12;
            label1.Text = "姓名：";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1484, 28);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1075, 642);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 70);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "删除学生";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(298, 642);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 70);
            btnSave.TabIndex = 1;
            btnSave.Text = "保存信息";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1373, 415);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 72);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtClassId
            // 
            txtClassId.Location = new Point(155, 447);
            txtClassId.Margin = new Padding(4);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(121, 30);
            txtClassId.TabIndex = 25;
            txtClassId.TextChanged += txtClassId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 180);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 24;
            label7.Text = "性别：";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(298, 28);
            dgvStudents.Margin = new Padding(4);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.RowTemplate.Height = 30;
            dgvStudents.Size = new Size(937, 576);
            dgvStudents.TabIndex = 26;
            dgvStudents.Click += dgvStudents_SelectionChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1243, 310);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(226, 24);
            label8.TabIndex = 28;
            label8.Text = "查询学生（请输入学号）：";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1493, 310);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(131, 30);
            txtSearch.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(858, 766);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 30;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(689, 642);
            btnAddNew.Margin = new Padding(4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(160, 70);
            btnAddNew.TabIndex = 31;
            btnAddNew.Text = "添加新学生";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // AdminStudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 742);
            Controls.Add(btnAddNew);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(dgvStudents);
            Controls.Add(txtClassId);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(txtCredits);
            Controls.Add(btnDelete);
            Controls.Add(txtOrigin);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtSex);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminStudentManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生管理";
            Load += AdminStudentManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private Button button1;
        private Button btnAddNew;
    }
}