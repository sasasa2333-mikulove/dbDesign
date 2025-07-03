namespace dbDesign
{
    partial class StudentChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentChangePasswordForm));
            btnBack = new Button();
            btnSaveChanges = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(271, 292);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 45);
            btnBack.TabIndex = 29;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(83, 292);
            btnSaveChanges.Margin = new Padding(4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(114, 45);
            btnSaveChanges.TabIndex = 28;
            btnSaveChanges.Text = "确认修改";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(240, 208);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(163, 30);
            txtConfirmPassword.TabIndex = 27;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(240, 133);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(163, 30);
            txtNewPassword.TabIndex = 26;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(240, 60);
            txtOldPassword.Margin = new Padding(4);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(163, 30);
            txtOldPassword.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 23;
            label4.Text = "确认新密码：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 22;
            label3.Text = "新密码：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 21;
            label2.Text = "旧密码：";
            // 
            // StudentChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 396);
            Controls.Add(btnBack);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StudentChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSaveChanges;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}