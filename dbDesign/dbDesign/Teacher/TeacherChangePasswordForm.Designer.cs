namespace dbDesign
{
    partial class TeacherChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherChangePasswordForm));
            btnBack = new Button();
            btnSaveChanges = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(266, 299);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 45);
            btnBack.TabIndex = 37;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(78, 299);
            btnSaveChanges.Margin = new Padding(4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(114, 45);
            btnSaveChanges.TabIndex = 36;
            btnSaveChanges.Text = "确认修改";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(235, 215);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(163, 30);
            txtConfirmPassword.TabIndex = 35;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(235, 140);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(163, 30);
            txtNewPassword.TabIndex = 34;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(235, 67);
            txtOldPassword.Margin = new Padding(4);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(163, 30);
            txtOldPassword.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 215);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 32;
            label1.Text = "确认新密码：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 140);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 31;
            label5.Text = "新密码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 67);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 30;
            label6.Text = "旧密码：";
            // 
            // TeacherChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 383);
            Controls.Add(btnBack);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TeacherChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSaveChanges;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label label1;
        private Label label5;
        private Label label6;
    }
}