namespace dbDesign
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            btnBack = new Button();
            txtClassId = new TextBox();
            label7 = new Label();
            txtCredits = new TextBox();
            txtOrigin = new TextBox();
            txtAge = new TextBox();
            txtSex = new TextBox();
            txtName = new TextBox();
            txtStudentId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(172, 497);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 55);
            btnBack.TabIndex = 12;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtClassId
            // 
            txtClassId.BorderStyle = BorderStyle.None;
            txtClassId.Location = new Point(172, 430);
            txtClassId.Margin = new Padding(4);
            txtClassId.Name = "txtClassId";
            txtClassId.ReadOnly = true;
            txtClassId.Size = new Size(121, 23);
            txtClassId.TabIndex = 39;
            txtClassId.TextChanged += txtClassId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 162);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 38;
            label7.Text = "性别：";
            // 
            // txtCredits
            // 
            txtCredits.BorderStyle = BorderStyle.None;
            txtCredits.Location = new Point(172, 358);
            txtCredits.Margin = new Padding(4);
            txtCredits.Name = "txtCredits";
            txtCredits.ReadOnly = true;
            txtCredits.Size = new Size(121, 23);
            txtCredits.TabIndex = 37;
            // 
            // txtOrigin
            // 
            txtOrigin.BorderStyle = BorderStyle.None;
            txtOrigin.Location = new Point(172, 287);
            txtOrigin.Margin = new Padding(4);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.ReadOnly = true;
            txtOrigin.Size = new Size(121, 23);
            txtOrigin.TabIndex = 36;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Location = new Point(172, 227);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(121, 23);
            txtAge.TabIndex = 35;
            // 
            // txtSex
            // 
            txtSex.BorderStyle = BorderStyle.None;
            txtSex.Location = new Point(172, 162);
            txtSex.Margin = new Padding(4);
            txtSex.Name = "txtSex";
            txtSex.ReadOnly = true;
            txtSex.Size = new Size(121, 23);
            txtSex.TabIndex = 34;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(172, 98);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 33;
            // 
            // txtStudentId
            // 
            txtStudentId.BorderStyle = BorderStyle.None;
            txtStudentId.Location = new Point(172, 31);
            txtStudentId.Margin = new Padding(4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.ReadOnly = true;
            txtStudentId.Size = new Size(121, 23);
            txtStudentId.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 357);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 31;
            label6.Text = "已修学分：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 429);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 30;
            label5.Text = "班级编号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 287);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 29;
            label4.Text = "生源地：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 227);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 28;
            label3.Text = "年龄：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 27;
            label2.Text = "学号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 26;
            label1.Text = "姓名：";
            // 
            // StudentInfoForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 572);
            Controls.Add(txtClassId);
            Controls.Add(label7);
            Controls.Add(txtCredits);
            Controls.Add(txtOrigin);
            Controls.Add(txtAge);
            Controls.Add(txtSex);
            Controls.Add(txtName);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StudentInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "个人信息";
            Load += StudentInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private TextBox txtClassId;
        private Label label7;
        private TextBox txtCredits;
        private TextBox txtOrigin;
        private TextBox txtAge;
        private TextBox txtSex;
        private TextBox txtName;
        private TextBox txtStudentId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}