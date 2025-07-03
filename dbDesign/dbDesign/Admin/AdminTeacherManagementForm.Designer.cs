namespace dbDesign
{
    partial class AdminTeacherManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTeacherManagementForm));
            txtPhone = new TextBox();
            txtPosition = new TextBox();
            txtAge = new TextBox();
            txtSex = new TextBox();
            txtTeacherName = new TextBox();
            txtTeacherId = new TextBox();
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
            dgvTeachers = new DataGridView();
            label7 = new Label();
            txtSearch = new TextBox();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(186, 399);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 30);
            txtPhone.TabIndex = 23;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(186, 329);
            txtPosition.Margin = new Padding(4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(121, 30);
            txtPosition.TabIndex = 22;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(186, 259);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(121, 30);
            txtAge.TabIndex = 21;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(186, 189);
            txtSex.Margin = new Padding(4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(121, 30);
            txtSex.TabIndex = 20;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(186, 119);
            txtTeacherName.Margin = new Padding(4);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(121, 30);
            txtTeacherName.TabIndex = 19;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(186, 49);
            txtTeacherId.Margin = new Padding(4);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(121, 30);
            txtTeacherId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 399);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 17;
            label6.Text = "联系电话：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 329);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 16;
            label5.Text = "教师职称：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 15;
            label4.Text = "教师年龄：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 14;
            label3.Text = "教师性别：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 13;
            label2.Text = "教师姓名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 12;
            label1.Text = "教师编号：";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Location = new Point(1479, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1092, 628);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 70);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "删除教师";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(315, 628);
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
            btnSearch.Location = new Point(1384, 419);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 72);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(315, 13);
            dgvTeachers.Margin = new Padding(4);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.RowHeadersWidth = 62;
            dgvTeachers.RowTemplate.Height = 30;
            dgvTeachers.Size = new Size(937, 576);
            dgvTeachers.TabIndex = 24;
            dgvTeachers.Click += dgvTeachers_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1260, 286);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(226, 24);
            label7.TabIndex = 25;
            label7.Text = "查询教师（请输入编号）：";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1494, 286);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 30);
            txtSearch.TabIndex = 27;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(710, 628);
            btnAddNew.Margin = new Padding(4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(160, 70);
            btnAddNew.TabIndex = 28;
            btnAddNew.Text = "添加新教师";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // AdminTeacherManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 742);
            Controls.Add(btnAddNew);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(dgvTeachers);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtPhone);
            Controls.Add(btnDelete);
            Controls.Add(txtPosition);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtSex);
            Controls.Add(txtTeacherName);
            Controls.Add(txtTeacherId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminTeacherManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师管理";
            Load += AdminTeacherManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvTeachers;
    }
}