using MyClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestsProject
{
    
    
    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
    {


        private TestContext testContextInstance;
        Student student1, student2, student3;
        

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            student1 = null;
            student2 = null;
            student3 = null;
        }
        
        #endregion


        /// <summary>
        ///A test for Student Default Constructor
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest()
        {
            Assert.AreEqual(null, student1);
            
            student1 = new Student();
            Assert.AreNotEqual(null, student1);
            Assert.AreEqual(string.Empty, student1.Name);
            Assert.AreEqual(0, student1.Age);
            Assert.AreEqual(DateTime.Today, student1.BirthDate);
            Assert.AreEqual(0.0, student1.CreditsEarned);
            Assert.AreEqual(0.0, student1.GPA);
            Assert.AreEqual(string.Empty, student1.Major);
            Assert.AreEqual(string.Empty, student1.Minor);
            Assert.AreEqual(false, student1.FullTime);

            student2 = student1;
            Assert.AreSame(student1, student2);

            student3 = new Student();
            Assert.AreNotEqual(null, student1);
            Assert.AreNotSame(student1, student3);
            
        }

        /// <summary>
        ///A test for Student Constructor (string name)
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest2()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            Assert.AreEqual(null, student1);

            student1 = new Student(name1);
            Assert.AreNotEqual(null, student1);
            Assert.AreEqual(name1, student1.Name);
            Assert.AreEqual(0, student1.Age);
            Assert.AreEqual(DateTime.Today, student1.BirthDate);
            Assert.AreEqual(0.0, student1.CreditsEarned);
            Assert.AreEqual(0.0, student1.GPA);
            Assert.AreEqual(string.Empty, student1.Major);
            Assert.AreEqual(string.Empty, student1.Minor);
            Assert.AreEqual(false, student1.FullTime);

            student2 = student1;
            Assert.AreSame(student1, student2);
            student2 = new Student(name2);
            Assert.AreNotSame(student1, student2);
            Assert.AreEqual(name2, student2.Name);
            

            student3 = new Student(name3);
            Assert.AreNotEqual(null, student3);
            Assert.AreNotSame(student1, student3);
            Assert.AreEqual(name3, student3.Name);
            
        }

        /// <summary>
        ///A test for Student Constructor (string name, string id)
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest3()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "Your ID 111", id2 = "Their ID2", id3 = "My ID 3";
            Assert.AreEqual(null, student1);

            student1 = new Student(name1, id1);
            Assert.AreNotEqual(null, student1);
            Assert.AreEqual(name1, student1.Name);
            Assert.AreEqual(id1, student1.StudentID);
            Assert.AreEqual(0, student1.Age);
            Assert.AreEqual(DateTime.Today, student1.BirthDate);
            Assert.AreEqual(0.0, student1.CreditsEarned);
            Assert.AreEqual(0.0, student1.GPA);
            Assert.AreEqual(string.Empty, student1.Major);
            Assert.AreEqual(string.Empty, student1.Minor);
            Assert.AreEqual(false, student1.FullTime);

            student2 = student1;
            Assert.AreSame(student1, student2);
            student2 = new Student(name2, id2);
            Assert.AreNotSame(student1, student2);
            Assert.AreEqual(name2, student2.Name);
            Assert.AreEqual(id2, student2.StudentID);


            student3 = new Student(name3, id3);
            Assert.AreNotEqual(null, student3);
            Assert.AreNotSame(student1, student3);
            Assert.AreEqual(name3, student3.Name);
            Assert.AreEqual(id3, student3.StudentID);
           
        }

        /// <summary>
        ///A test for Student Constructor (string name, string id, string major)
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest4()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "Your ID 111", id2 = "Their ID2", id3 = "My ID 3";
            string major1 = "IST", major2 = "CIS", major3 = "Physics";
            Assert.AreEqual(null, student1);

            student1 = new Student(name1, id1, major1);
            Assert.AreNotEqual(null, student1);
            Assert.AreEqual(name1, student1.Name);
            Assert.AreEqual(id1, student1.StudentID);
            Assert.AreEqual(major1, student1.Major);
            Assert.AreEqual(0, student1.Age);
            Assert.AreEqual(DateTime.Today, student1.BirthDate);
            Assert.AreEqual(0.0, student1.CreditsEarned);
            Assert.AreEqual(0.0, student1.GPA);
            Assert.AreEqual(string.Empty, student1.Minor);
            Assert.AreEqual(false, student1.FullTime);

            student2 = student1;
            Assert.AreSame(student1, student2);
            student2 = new Student(name2, id2, major2);
            Assert.AreNotSame(student1, student2);
            Assert.AreEqual(name2, student2.Name);
            Assert.AreEqual(id2, student2.StudentID);
            Assert.AreEqual(major2, student2.Major);


            student3 = new Student(name3, id3, major3);
            Assert.AreNotEqual(null, student3);
            Assert.AreNotSame(student1, student3);
            Assert.AreEqual(name3, student3.Name);
            Assert.AreEqual(id3, student3.StudentID);
            Assert.AreEqual(major3, student3.Major);
           
        }

        /// <summary>
        ///A test for Student Constructor (string name, string id, DateTime dob)
        ///</summary>
        [TestMethod()]
        public void StudentConstructorTest5()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "Your ID 111", id2 = "Their ID2", id3 = "My ID 3";
            DateTime dob1 = new DateTime(2000, 1, 1);
            DateTime dob2 = new DateTime(1990, 2, 2);
            DateTime dob3 = new DateTime(1985, 12, 31);

            Assert.AreEqual(null, student1);

            student1 = new Student(name1, id1, dob1);
            Assert.AreNotEqual(null, student1);
            Assert.AreEqual(name1, student1.Name);
            Assert.AreEqual(id1, student1.StudentID);
            Assert.AreEqual(dob1, student1.BirthDate);
            Assert.AreEqual(CalculateAge(dob1), student1.Age);
            Assert.AreEqual(0.0, student1.CreditsEarned);
            Assert.AreEqual(0.0, student1.GPA);
            Assert.AreEqual(string.Empty, student1.Major);
            Assert.AreEqual(string.Empty, student1.Minor);
            Assert.AreEqual(false, student1.FullTime);

            student2 = student1;
            Assert.AreSame(student1, student2);
            student2 = new Student(name2, id2, dob2);
            Assert.AreNotSame(student1, student2);
            Assert.AreEqual(name2, student2.Name);
            Assert.AreEqual(id2, student2.StudentID);
            Assert.AreEqual(dob2, student2.BirthDate);
            Assert.AreEqual(CalculateAge(dob2), student2.Age);


            student3 = new Student(name3, id3, dob3);
            Assert.AreNotEqual(null, student3);
            Assert.AreNotSame(student1, student3);
            Assert.AreEqual(name3, student3.Name);
            Assert.AreEqual(id3, student3.StudentID);
            Assert.AreEqual(dob3, student3.BirthDate);
            Assert.AreEqual(CalculateAge(dob3), student3.Age);
        }

        /// <summary>
        ///A test for AddCourseGrade
        ///</summary>
        [TestMethod()]
        public void AddCourseGradeTest()
        {
            // This method is tested in GetCourseGradesTest
        }

        /// <summary>
        ///A test for GetCourseGrades
        ///</summary>
        [TestMethod()]
        public void GetCourseGradesTest()
        {
            string course1 = "CIS3309", course2 = "CIS3342", course3 = "CIS4376", course4 = "CIS0835";
            string grade1 = "A+", grade2 = "B+", grade3 = "A", grade4 = "B";
            SortedList<string, string> courses;

            student1 = new Student();
            student1.AddCourseGrade(course1, grade1);
            student1.AddCourseGrade(course2, grade2);
            student1.AddCourseGrade(course3, grade3);
            student1.AddCourseGrade(course4, grade4);

            courses = student1.GetCourseGrades();

            Assert.AreEqual(4, courses.Count);
            Assert.IsTrue(courses.ContainsKey(course1));
            Assert.IsTrue(courses.ContainsValue(grade1));
            Assert.AreEqual(grade1, courses[course1]);

            Assert.IsTrue(courses.ContainsKey(course2));
            Assert.IsTrue(courses.ContainsValue(grade2));
            Assert.AreEqual(grade2, courses[course2]);

            Assert.IsTrue(courses.ContainsKey(course3));
            Assert.IsTrue(courses.ContainsValue(grade3));
            Assert.AreEqual(grade3, courses[course3]);

            Assert.IsTrue(courses.ContainsKey(course4));
            Assert.IsTrue(courses.ContainsValue(grade4));
            Assert.AreEqual(grade4, courses[course4]);
        }

        /// <summary>
        ///A test for CreditsEarned
        ///</summary>
        [TestMethod()]
        public void CreditsEarnedTest()
        {
            double initialCredits = 0.0, credits2 = 60.5, credits3 = 120.0;

            student1 = new Student();
            Assert.AreEqual(initialCredits, student1.CreditsEarned);
            student1.CreditsEarned = credits2;
            Assert.AreEqual(credits2, student1.CreditsEarned);
            student1.CreditsEarned = credits3;
            Assert.AreEqual(credits3, student1.CreditsEarned);

            student2 = new Student();
            Assert.AreEqual(initialCredits, student2.CreditsEarned);
            student2.CreditsEarned = student1.CreditsEarned;
            Assert.AreEqual(student1.CreditsEarned, student2.CreditsEarned);
   
        }

        /// <summary>
        ///A test for FullTime
        ///</summary>
        [TestMethod()]
        public void FullTimeTest()
        {
            student1 = new Student();
            Assert.AreEqual(false, student1.FullTime);
            student1.FullTime = true;
            Assert.AreEqual(true, student1.FullTime);
            student1.FullTime = false;
            Assert.AreEqual(false, student1.FullTime);
            
        }

        /// <summary>
        ///A test for GPA
        ///</summary>
        [TestMethod()]
        public void GPATest()
        {
            double initialGPA = 0.0, gpa2 = 3.3, gpa3 = 4.0, gpa4 = -1, gpa5 = 5.5;

            student1 = new Student();
            Assert.AreEqual(initialGPA, student1.GPA);
            student1.GPA = gpa2;
            Assert.AreEqual(gpa2, student1.GPA);
            student1.GPA = gpa3;
            Assert.AreEqual(gpa3, student1.GPA);

            try
            {
                student1.GPA = gpa4;    // code should cause exception
                Assert.Fail();          // this code shouldn't be reached. Otherwise, it failed.
            }
            catch (ArgumentException ex)
            {
                // GPA shouldn't have changed for the student
                Assert.AreEqual(gpa3, student1.GPA);
            }

            try
            {
                student1.GPA = gpa5;    // code should cause exception
                Assert.Fail();          // this code shouldn't be reached. Otherwise, it failed.
            }
            catch (ArgumentException ex)
            {
                // GPA shouldn't have changed for the student
                Assert.AreEqual(gpa3, student1.GPA);
            }

        }

        /// <summary>
        ///A test for Major
        ///</summary>
        [TestMethod()]
        public void MajorTest()
        {
            string major1 = "IST", major2 = "CIS", major3 = "Physics";
            student1 = new Student();
            Assert.AreEqual(string.Empty, student1.Major);
            student1.Major = major1;
            Assert.AreEqual(major1, student1.Major);
            student1.Major = major2;
            Assert.AreEqual(major2, student1.Major);
            student1.Major = major3;
            Assert.AreEqual(major3, student1.Major);

            student2 = new Student();
            Assert.AreEqual(string.Empty, student2.Major);
            student1.Major = major1;
            student2.Major = student1.Major;
            Assert.AreEqual(student1.Major, student2.Major);
                       
        }

        /// <summary>
        ///A test for Minor
        ///</summary>
        [TestMethod()]
        public void MinorTest()
        {
            string minor1 = "IST", minor2 = "CIS", minor3 = "Physics";
            student1 = new Student();
            Assert.AreEqual(string.Empty, student1.Minor);
            student1.Minor = minor1;
            Assert.AreEqual(minor1, student1.Minor);
            student1.Minor = minor2;
            Assert.AreEqual(minor2, student1.Minor);
            student1.Minor = minor3;
            Assert.AreEqual(minor3, student1.Minor);

            student2 = new Student();
            Assert.AreEqual(string.Empty, student2.Minor);
            student1.Minor = minor1;
            student2.Minor = student1.Minor;
            Assert.AreEqual(student1.Minor, student2.Minor);
           
        }

        /// <summary>
        ///A test for StudentID
        ///</summary>
        [TestMethod()]
        public void StudentIDTest()
        {
            string id1 = "ST111", id2 = "ID2", id3 = "My ID 3";
            student1 = new Student();
            Assert.AreEqual(string.Empty, student1.StudentID);
            student1.StudentID = id1;
            Assert.AreEqual(id1, student1.StudentID);
            student1.StudentID = id2;
            Assert.AreEqual(id2, student1.StudentID);
            student1.StudentID = id3;
            Assert.AreEqual(id3, student1.StudentID);

            student2 = new Student();
            Assert.AreEqual(string.Empty, student2.StudentID);
            student1.StudentID = id1;
            student2.StudentID = student1.StudentID;
            Assert.AreEqual(student1.StudentID, student2.StudentID);
           
        }

        // Private helper method used to calculate an age
        private int CalculateAge(DateTime theDob)
        {
            int years = 0;

            // Calculate the difference in years
            years = DateTime.Now.Year - theDob.Year;

            // Subtract another year if the Person's birthday didn't come yet.
            if (DateTime.Now.Month < theDob.Month ||
               (DateTime.Now.Month == theDob.Month && DateTime.Now.Day < theDob.Day))
                years = years - 1;

            return years;
        }

    }
}
