namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            DateTime = new DateTimePicker();
            EmpName = new TextBox();
            EmpSalary = new TextBox();
            empDept = new ComboBox();
            EmpDesig = new ComboBox();
            Save = new Button();
            Edit = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            EmpCode = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 106);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 38);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 106);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Designation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 167);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 224);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Basic Salary";
            // 
            // DateTime
            // 
            DateTime.Location = new Point(553, 43);
            DateTime.Name = "DateTime";
            DateTime.Size = new Size(189, 27);
            DateTime.TabIndex = 9;
            // 
            // EmpName
            // 
            EmpName.Location = new Point(205, 103);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(125, 27);
            EmpName.TabIndex = 10;
            // 
            // EmpSalary
            // 
            EmpSalary.Location = new Point(205, 217);
            EmpSalary.Name = "EmpSalary";
            EmpSalary.Size = new Size(125, 27);
            EmpSalary.TabIndex = 11;
            // 
            // empDept
            // 
            empDept.FormattingEnabled = true;
            empDept.Items.AddRange(new object[] { "HR", "Accounting", "Sales", "Marketing", "Finance" });
            empDept.Location = new Point(205, 167);
            empDept.Name = "empDept";
            empDept.Size = new Size(125, 28);
            empDept.TabIndex = 12;
            empDept.SelectedIndexChanged += empDept_SelectedIndexChanged;
            // 
            // EmpDesig
            // 
            EmpDesig.FormattingEnabled = true;
            EmpDesig.Items.AddRange(new object[] { "Software Developer", "Assistant System Engineer", "Project Manager", "Team Leaad", "Full Stack Developer", "Software Architect", "Analyst" });
            EmpDesig.Location = new Point(553, 98);
            EmpDesig.Name = "EmpDesig";
            EmpDesig.Size = new Size(189, 28);
            EmpDesig.TabIndex = 13;
            // 
            // Save
            // 
            Save.Location = new Point(128, 293);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 14;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(513, 293);
            Edit.Name = "Edit";
            Edit.Size = new Size(94, 29);
            Edit.TabIndex = 15;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(405, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 101);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 20;
            label1.Text = "Employee Code";
            // 
            // EmpCode
            // 
            EmpCode.Location = new Point(205, 50);
            EmpCode.Name = "EmpCode";
            EmpCode.Size = new Size(125, 27);
            EmpCode.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 437);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 188);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 634);
            Controls.Add(dataGridView1);
            Controls.Add(EmpCode);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(EmpDesig);
            Controls.Add(empDept);
            Controls.Add(EmpSalary);
            Controls.Add(EmpName);
            Controls.Add(DateTime);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private DateTimePicker DateTime;
        private TextBox EmpName;
        private TextBox EmpSalary;
        private ComboBox empDept;
        private ComboBox EmpDesig;
        private Button Save;
        private Button Edit;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox EmpCode;
        private DataGridView dataGridView1;
    }
}
