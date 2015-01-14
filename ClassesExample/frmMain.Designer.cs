namespace ClassesExample
{
    partial class frmMain
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWriteDB = new System.Windows.Forms.Button();
            this.btnReadDB = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtStudentID);
            this.GroupBox1.Controls.Add(this.txtGPA);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.btnLast);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.btnNext);
            this.GroupBox1.Controls.Add(this.txtMajor);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtDOB);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(538, 175);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Student Information";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(149, 54);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(193, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(149, 134);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(75, 20);
            this.txtGPA.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(85, 57);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "StudentID:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(400, 57);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(115, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "Previous Student";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(111, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "GPA:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(400, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Student";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(149, 108);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(75, 20);
            this.txtMajor.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(107, 111);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Major:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(149, 80);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(75, 20);
            this.txtDOB.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(74, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(105, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDeleteStudent);
            this.groupBox2.Controls.Add(this.btnAddStudent);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student List Controls";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(108, 72);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteStudent.TabIndex = 15;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 72);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(88, 23);
            this.btnAddStudent.TabIndex = 14;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWriteDB);
            this.groupBox3.Controls.Add(this.btnReadDB);
            this.groupBox3.Controls.Add(this.btnReadFile);
            this.groupBox3.Controls.Add(this.btnWriteFile);
            this.groupBox3.Location = new System.Drawing.Point(350, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 154);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "External Resource Controls";
            // 
            // btnWriteDB
            // 
            this.btnWriteDB.Location = new System.Drawing.Point(29, 22);
            this.btnWriteDB.Name = "btnWriteDB";
            this.btnWriteDB.Size = new System.Drawing.Size(142, 23);
            this.btnWriteDB.TabIndex = 18;
            this.btnWriteDB.Text = "Write Data to Database";
            this.btnWriteDB.UseVisualStyleBackColor = true;
            this.btnWriteDB.Click += new System.EventHandler(this.btnWriteDB_Click);
            // 
            // btnReadDB
            // 
            this.btnReadDB.Location = new System.Drawing.Point(29, 51);
            this.btnReadDB.Name = "btnReadDB";
            this.btnReadDB.Size = new System.Drawing.Size(142, 23);
            this.btnReadDB.TabIndex = 17;
            this.btnReadDB.Text = "Read Data from Database";
            this.btnReadDB.UseVisualStyleBackColor = true;
            this.btnReadDB.Click += new System.EventHandler(this.btnReadDB_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(43, 121);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(118, 23);
            this.btnReadFile.TabIndex = 16;
            this.btnReadFile.Text = "Read Data from File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(43, 92);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(118, 23);
            this.btnWriteFile.TabIndex = 15;
            this.btnWriteFile.Text = "Write Data to File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmMain";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtStudentID;
        internal System.Windows.Forms.TextBox txtGPA;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox txtMajor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDOB;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnDeleteStudent;
        internal System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnWriteDB;
        internal System.Windows.Forms.Button btnReadDB;
        internal System.Windows.Forms.Button btnReadFile;
        internal System.Windows.Forms.Button btnWriteFile;
    }
}

