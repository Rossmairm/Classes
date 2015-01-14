using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.OleDb;
using System.IO;

namespace MyClassLibrary
{
    public class StudentList
    {
        private ArrayList students;
        private int currentPosition;

        public StudentList()
        {
            students = new ArrayList();
            currentPosition = -1;
        }

        public int Count
        {
            get { return students.Count; }
        }

        // Returns the index of the newly added Student object
        public int AddStudent(Student s)
        {
            return students.Add(s);
        }

        public bool AddStudent(Student s, int index)
        {
            if (index >= 0 && index <= students.Count)
            {
                students.Insert(index, s);
                return true;
            }

            return false;
        }

        public bool RemoveStudent(Student s)
        {
            int countBeforeRemoval = students.Count;
            students.Remove(s);

            if (countBeforeRemoval > students.Count)
            {
                currentPosition = -1;   // reset the current position in the list
                return true;
            }

            return false;
        }

        public bool RemoveStudent(int index)
        {
            if (index < 0 || index > students.Count - 1)
                return false;

            int countBeforeRemoval = students.Count;
            students.RemoveAt(index);

            if (countBeforeRemoval > students.Count)
            {
                currentPosition = -1;   // reset the current position in the list
                return true;
            }

            return false;
        }

        public Student GetStudent(Student s)
        {
            int index = students.IndexOf(s);

            if (index == -1)
                return null;

            return (Student)students[index];
        }

        public Student GetStudent(int index)
        {
            if (index > students.Count - 1 || index < 0)
                return null;

            return (Student)students[index];
        }

        public Student NextStudent()
        {
            if (students.Count == 0)
                return null;

            if (currentPosition < students.Count - 1)
                currentPosition++;

            return (Student)students[currentPosition];
        }

        public Student PreviousStudent()
        {
            if (students.Count == 0)
                return null;

            if (currentPosition == -1)
                return null;

            if (currentPosition > 0)
                currentPosition--;

            return (Student)students[currentPosition];
        }

        // Method returns a new ArrayList with all the references from the original ArrayList
        // Shallow-Copy of items ArrayList
        public ArrayList GetStudents()
        {
            ArrayList theList = new ArrayList();
            foreach (object item in students)
            {
                theList.Add(item);
            }

            return theList;
        }

        public void ClearStudents()
        {
            students.Clear();
            currentPosition = -1;
        }

        public Student FindStudentByID(string id)
        {
            foreach (Student s in students)
            {
                if (s.StudentID == id)
                    return s;
            }

            return null;
        }

        public bool WriteStudentsToFile()
        {
            try
            {
                FileStream fs = new FileStream("StudentFile.txt", FileMode.Create, FileAccess.Write);
                StreamWriter textWriter = new StreamWriter(fs);

                foreach (Student theStudent in students)
                {
                    textWriter.WriteLine(theStudent.StudentID);
                    textWriter.WriteLine(theStudent.Name);
                    textWriter.WriteLine(theStudent.BirthDate);
                    textWriter.WriteLine(theStudent.Major);
                    textWriter.WriteLine(theStudent.GPA);
                }

                textWriter.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return false;
            }
        }

        public void ReadStudentsFromFile()
        {
            try
            {
                FileStream fs = new FileStream("StudentFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader textReader = new StreamReader(fs);

                students.Clear();

                while (!textReader.EndOfStream)
                {
                    Student theStudent = new Student();
                    theStudent.StudentID = textReader.ReadLine();
                    theStudent.Name = textReader.ReadLine();
                    theStudent.BirthDate = DateTime.Parse(textReader.ReadLine());
                    theStudent.Major = textReader.ReadLine();
                    theStudent.GPA = double.Parse(textReader.ReadLine());

                    AddStudent(theStudent);
                }

                textReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: the file wasn't found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public bool WriteStudentsToDB()
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=School.accdb;";
            string strSQL = "";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();

                foreach (Student theStudent in students)
                {
                    strSQL = "INSERT INTO Students (StudentID, Name, Major) " +
                         "VALUES ('" + theStudent.StudentID + "','" + theStudent.Name + "','" + theStudent.Major + "')";

                    myCommand.CommandText = strSQL;
                    myCommand.CommandType = System.Data.CommandType.Text;
                    myCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public void ReadStudentsFromDB()
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=School.accdb;";
            string strSQL = "SELECT StudentID, Name, Major FROM Students";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            OleDbDataReader myDataReader;

            students.Clear();

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    Student theStudent = new Student();
                    theStudent.StudentID = myDataReader["StudentID"].ToString();
                    theStudent.Name = myDataReader["Name"].ToString();
                    theStudent.Major = myDataReader["Major"].ToString();

                    AddStudent(theStudent);
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }

    }
}
