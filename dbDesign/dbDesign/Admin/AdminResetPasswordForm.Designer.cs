namespace dbDesign
{
    partial class AdminResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminResetPasswordForm));
            cmbUserType = new ComboBox();
            txtUserId = new TextBox();
            txtNewPassword = new TextBox();
            btnResetPassword = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbUserType
            // 
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "学生", "教师" });
            cmbUserType.Location = new Point(262, 64);
            cmbUserType.Margin = new Padding(4);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(147, 32);
            cmbUserType.TabIndex = 0;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(262, 137);
            txtUserId.Margin = new Padding(4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(147, 30);
            txtUserId.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(262, 212);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(147, 30);
            txtNewPassword.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(105, 296);
            btnResetPassword.Margin = new Padding(4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(114, 45);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.Text = "确认修改";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(293, 296);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 45);
            btnBack.TabIndex = 4;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 5;
            label1.Text = "选择身份：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 6;
            label2.Text = "账号：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 7;
            label3.Text = "重置密码：";
            // 
            // AdminResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 397);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnResetPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtUserId);
            Controls.Add(cmbUserType);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "重置教师学生密码";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}