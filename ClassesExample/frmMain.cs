using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Steps to using the classes in the MyClassLibrary
// ---------------------------------------------------
// 1.) Use "Add Reference" to add a reference to the MyClassLibrary assembly's namespace
// 2.) Import the namespace in order to access the classes
using MyClassLibrary;


namespace ClassesExample
{
    public partial class frmMain : Form
    {
        StudentList students = new StudentList();       // global variable

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void DisplayStudent(Student s)
        {
            if (s != null)
            {
                txtName.Text = s.Name;
                txtStudentID.Text = s.StudentID;
                txtDOB.Text = s.BirthDate.ToShortDateString();
                txtGPA.Text = s.GPA.ToString();
                txtMajor.Text = s.Major;
            }
            else
            {
                ClearDisplay();
                txtName.Text = "No Student to display...";
            }
        }

        private void ClearDisplay()
        {
            txtName.Text = "";
            txtStudentID.Text = "";
            txtDOB.Text = "";
            txtGPA.Text = "";
            txtMajor.Text = "";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student myStudent = new Student();
            double gpa;

            myStudent.Name = txtName.Text;
            myStudent.StudentID = txtStudentID.Text;
            myStudent.BirthDate = DateTime.Parse(txtDOB.Text);
            myStudent.Major = txtMajor.Text;

            if (double.TryParse(txtGPA.Text, out gpa))
                myStudent.GPA = gpa;

            students.AddStudent(myStudent);
            ClearDisplay();

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Student myStudent = students.FindStudentByID(txtStudentID.Text);
            if (myStudent != null)
            {
                students.RemoveStudent(myStudent);
                ClearDisplay();
            }
            else
            {
                MessageBox.Show("That StudentID doesn't exist in the list of students.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student myStudent = students.FindStudentByID(txtStudentID.Text);
            if (myStudent != null)
            {
                double gpa;
                myStudent.Name = txtName.Text;
                myStudent.StudentID = txtStudentID.Text;
                myStudent.BirthDate = DateTime.Parse(txtDOB.Text);
                myStudent.Major = txtMajor.Text;

                if (double.TryParse(txtGPA.Text, out gpa))
                    myStudent.GPA = gpa;

                MessageBox.Show("The changes were successfully saved.");
            }
            else
            {
                MessageBox.Show("That StudentID doesn't exist in the list of students.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayStudent(students.NextStudent());
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DisplayStudent(students.PreviousStudent());
        }

        private void btnWriteDB_Click(object sender, EventArgs e)
        {
            bool success = students.WriteStudentsToDB();
            if (success)
                MessageBox.Show("The changes were successfully saved to the database.");
            else
                MessageBox.Show("The changes failed to save to the database.");
        }

        private void btnReadDB_Click(object sender, EventArgs e)
        {
            students.ReadStudentsFromDB();
            DisplayStudent(students.NextStudent());
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            bool success = students.WriteStudentsToFile();
            if (success)
                MessageBox.Show("The changes were successfully saved to the file.");
            else
                MessageBox.Show("The changes failed to save to the file.");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            students.ReadStudentsFromFile();
            DisplayStudent(students.NextStudent());
        }
    }
}
