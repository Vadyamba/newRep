namespace FormsApp_Abstraction_Hive
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AssignJob = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_workerBeeJob = new System.Windows.Forms.ComboBox();
            this.button_NextShift = new System.Windows.Forms.Button();
            this.textBox_Report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AssignJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // button_AssignJob
            // 
            this.button_AssignJob.Location = new System.Drawing.Point(6, 81);
            this.button_AssignJob.Name = "button_AssignJob";
            this.button_AssignJob.Size = new System.Drawing.Size(437, 30);
            this.button_AssignJob.TabIndex = 2;
            this.button_AssignJob.Text = "Assign this job to a bee";
            this.button_AssignJob.UseVisualStyleBackColor = true;
            this.button_AssignJob.Click += new System.EventHandler(this.button_AssignJob_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(323, 52);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 22);
            this.shifts.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job";
            // 
            // comboBox_workerBeeJob
            // 
            this.comboBox_workerBeeJob.FormattingEnabled = true;
            this.comboBox_workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBox_workerBeeJob.Location = new System.Drawing.Point(6, 50);
            this.comboBox_workerBeeJob.Name = "comboBox_workerBeeJob";
            this.comboBox_workerBeeJob.Size = new System.Drawing.Size(311, 24);
            this.comboBox_workerBeeJob.TabIndex = 1;
            // 
            // button_NextShift
            // 
            this.button_NextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.button_NextShift.Location = new System.Drawing.Point(467, 22);
            this.button_NextShift.Name = "button_NextShift";
            this.button_NextShift.Size = new System.Drawing.Size(205, 105);
            this.button_NextShift.TabIndex = 2;
            this.button_NextShift.Text = "Work the next shift";
            this.button_NextShift.UseVisualStyleBackColor = true;
            this.button_NextShift.Click += new System.EventHandler(this.button_NextShift_Click);
            // 
            // textBox_Report
            // 
            this.textBox_Report.Location = new System.Drawing.Point(12, 151);
            this.textBox_Report.Multiline = true;
            this.textBox_Report.Name = "textBox_Report";
            this.textBox_Report.Size = new System.Drawing.Size(654, 369);
            this.textBox_Report.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 532);
            this.Controls.Add(this.textBox_Report);
            this.Controls.Add(this.button_NextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_workerBeeJob;
        private System.Windows.Forms.Button button_AssignJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_NextShift;
        private System.Windows.Forms.TextBox textBox_Report;
    }
}

