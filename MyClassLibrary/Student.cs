using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace MyClassLibrary
{
    public class Student : Person
    {
        private string studentID;
        private string major;
        private string minor;
        private double gpa;
        private double creditsEarned;
        private bool fullTime;
        private SortedList<string, string> courseGradeList;

        // Default constructor
        public Student()
        {
            studentID = "";
            major = "";
            minor = "";
            gpa = 0.0;
            creditsEarned = 0.0;
            fullTime = false;
            courseGradeList = new SortedList<string, string>();

        }

        // Parameterized constructor
        public Student(string name) : base(name)    
        {
            // The ": base(name)" calls the Person(string) constructor
            // and passes the string name as its parameter to set the fullName field
            // Otherwise, you would need to use the public inherited property to do this:
            // this.Name = name;
            
            studentID = "";
            major = "";
            minor = "";
            gpa = 0.0;
            creditsEarned = 0.0;
            fullTime = false;
            courseGradeList = new SortedList<string, string>();
        }

        // Parameterized contstructor
        public Student(string name, string id) : base(name)     
        {
            // The ": base(name)" calls the Person(string) constructor
            // and passes the string name as its parameter to set the fullName field
            // Otherwise, you would need to use the public inherited property to do this:
            // this.Name = name;

            studentID = id;
            major = "";
            minor = "";
            gpa = 0.0;
            creditsEarned = 0.0;
            fullTime = false;
            courseGradeList = new SortedList<string, string>();
        }

        // Parameterized contstructor
        public Student(string name, string id, string major) : base(name)
        {
            // The ": base(name)" calls the Person(string) constructor
            // and passes the string name as its parameter to set the fullName field
            // Otherwise, you would need to use the public inherited property to do this:
            // this.Name = name;

            studentID = id;
            this.major = major;
            minor = "";
            gpa = 0.0;
            creditsEarned = 0.0;
            fullTime = false;
            courseGradeList = new SortedList<string, string>();
        }

        // Parameterized contstructor
        public Student(string name, string id, DateTime dob) : base(name, dob)
        {
            // The ": base(name, dob)" calls the Person(string, DateTime) constructor
            // and passes the string name and DateTime dob as its parameters to set the fullName field
            // and the birthDate field.
            // Otherwise, you would need to use the public inherited property to do this:
            // this.Name = name;
            // this.BirthDate = dob;

            studentID = id;
            major = "";
            minor = "";
            gpa = 0.0;
            creditsEarned = 0.0;
            fullTime = false;
            courseGradeList = new SortedList<string, string>();
        }

        // Accessor/Mutator for studentID field
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        // Accessor/Mutator for major field
        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        // Accessor/Mutator for minor field
        public string Minor
        {
            get { return minor; }
            set { minor = value; }
        }

        // Accessor/Mutator for gpa field
        public double GPA
        {
            get { return gpa; }
            set 
            {
                if (value > 4.0 || value < 0)
                    throw new ArgumentException("Invalid GPA value.");

                gpa = value; 
            }
        }

        // Accessor/Mutator for creditsEarned field
        public double CreditsEarned
        {
            get { return creditsEarned; }
            set { creditsEarned = value; }
        }

        // Accessor/Mutator for fullTime field
        public bool FullTime
        {
            get { return fullTime; }
            set { fullTime = value; }
        }

        // Method that adds a course grade to the courseGradeList collection
        public bool AddCourseGrade(string course, string grade)
        {
            try
            {
                courseGradeList.Add(course, grade);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Method returns a deep-copy of the courseGradesList collection
        public SortedList<string, string> GetCourseGrades()
        {
            SortedList<string, string> gradelist = new SortedList<string, string>();

            foreach (KeyValuePair<string, string> course in courseGradeList)
            {
                gradelist.Add(course.Key, course.Value);
            }

            return gradelist;
        }

        // Method returns an Enumerator that can be used to iterate through.
        //public IEnumerator<KeyValuePair<string, string>> GetCourseGrades()
        //{
        //    return courseGradeList.GetEnumerator();
        //}

    }
}
