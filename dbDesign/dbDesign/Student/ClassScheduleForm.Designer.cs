namespace dbDesign
{
    partial class ClassScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassScheduleForm));
            btnBack = new Button();
            dgvSchedule = new DataGridView();
            lblClassNameInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(788, 13);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(22, 87);
            dgvSchedule.Margin = new Padding(4);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 62;
            dgvSchedule.RowTemplate.Height = 30;
            dgvSchedule.Size = new Size(873, 363);
            dgvSchedule.TabIndex = 5;
            // 
            // lblClassNameInfo
            // 
            lblClassNameInfo.AutoSize = true;
            lblClassNameInfo.BackColor = Color.White;
            lblClassNameInfo.Location = new Point(31, 31);
            lblClassNameInfo.Name = "lblClassNameInfo";
            lblClassNameInfo.Size = new Size(52, 24);
            lblClassNameInfo.TabIndex = 6;
            lblClassNameInfo.Text = "label";
            // 
            // ClassScheduleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(941, 479);
            Controls.Add(lblClassNameInfo);
            Controls.Add(btnBack);
            Controls.Add(dgvSchedule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ClassScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "班级课表";
            Load += ClassScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private Label lblClassNameInfo;
    }
}