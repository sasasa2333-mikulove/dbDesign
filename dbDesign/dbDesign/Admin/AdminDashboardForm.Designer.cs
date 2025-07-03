namespace dbDesign
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(572, 25);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(140, 40);
            button5.TabIndex = 4;
            button5.Text = "退出";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(76, 101);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(139, 72);
            button1.TabIndex = 0;
            button1.Text = "教师管理";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(462, 366);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(139, 72);
            button4.TabIndex = 3;
            button4.Text = "修改管理员密码";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(462, 101);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(139, 72);
            button2.TabIndex = 1;
            button2.Text = "学生管理";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(273, 225);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(139, 72);
            button3.TabIndex = 2;
            button3.Text = "生源地统计";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(76, 366);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(139, 72);
            button6.TabIndex = 5;
            button6.Text = "教师或学生密码重置";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 480);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "管理员主页";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button6;
    }
}