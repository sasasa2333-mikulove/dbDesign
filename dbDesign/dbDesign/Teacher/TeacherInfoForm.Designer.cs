namespace dbDesign
{
    partial class TeacherInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfoForm));
            label7 = new Label();
            txtPhone = new TextBox();
            txtPosition = new TextBox();
            txtAge = new TextBox();
            txtSex = new TextBox();
            txtName = new TextBox();
            txtTeacherId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 198);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 53;
            label7.Text = "性别：";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Location = new Point(181, 394);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(121, 23);
            txtPhone.TabIndex = 52;
            // 
            // txtPosition
            // 
            txtPosition.BorderStyle = BorderStyle.None;
            txtPosition.Location = new Point(181, 323);
            txtPosition.Margin = new Padding(4);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(121, 23);
            txtPosition.TabIndex = 51;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Location = new Point(181, 263);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(121, 23);
            txtAge.TabIndex = 50;
            // 
            // txtSex
            // 
            txtSex.BorderStyle = BorderStyle.None;
            txtSex.Location = new Point(181, 198);
            txtSex.Margin = new Padding(4);
            txtSex.Name = "txtSex";
            txtSex.ReadOnly = true;
            txtSex.Size = new Size(121, 23);
            txtSex.TabIndex = 49;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(181, 134);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 48;
            // 
            // txtTeacherId
            // 
            txtTeacherId.BorderStyle = BorderStyle.None;
            txtTeacherId.Location = new Point(181, 67);
            txtTeacherId.Margin = new Padding(4);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.ReadOnly = true;
            txtTeacherId.Size = new Size(121, 23);
            txtTeacherId.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 393);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 46;
            label6.Text = "联系方式：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 323);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 44;
            label4.Text = "职称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 263);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 43;
            label3.Text = "年龄：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 42;
            label2.Text = "教师编号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 41;
            label1.Text = "教师姓名：";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(181, 472);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 55);
            btnBack.TabIndex = 40;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // TeacherInfoForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 550);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(txtPosition);
            Controls.Add(txtAge);
            Controls.Add(txtSex);
            Controls.Add(txtName);
            Controls.Add(txtTeacherId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "个人信息";
            Load += TeacherInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox txtPhone;
        private TextBox txtPosition;
        private TextBox txtAge;
        private TextBox txtSex;
        private TextBox txtName;
        private TextBox txtTeacherId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
    }
}