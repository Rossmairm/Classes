using MyClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestsProject
{
    
    
    /// <summary>
    ///This is a test class for StudentListTest and is intended
    ///to contain all StudentListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentListTest
    {


        private TestContext testContextInstance;

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
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StudentList Constructor
        ///</summary>
        [TestMethod()]
        public void StudentListConstructorTest()
        {
            StudentList students = new StudentList();
            Assert.IsNotNull(students);
            Assert.AreEqual(0, students.Count);
        }

        /// <summary>
        ///A test for AddStudent
        ///</summary>
        [TestMethod()]
        public void AddStudentTest()
        {
            StudentList students = new StudentList();
            Student s1 = new Student("Chris");
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, students.Count);
            students.AddStudent(s1);
            expectedCount++;
            Assert.AreEqual(expectedCount, students.Count);
            Assert.AreEqual("Chris", students.GetStudent(0).Name);


            for (int i = 1; i < 12; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s);
                expectedCount++;
                Assert.AreEqual(expectedCount, students.Count);
                Assert.AreEqual(i.ToString(), students.GetStudent(i).Name);
            }
            
            
        }

        /// <summary>
        ///A test for AddStudent (Student, int index)
        ///</summary>
        [TestMethod()]
        public void AddStudentTest2()
        {
            StudentList students = new StudentList();
            int StartValue = 1;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, students.Count);

            // Test adding students at index 0
            for (int i = StartValue; i <= 20; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s, 0);
                expectedCount++;

                // Test current student i was inserted at index 0
                Assert.AreEqual(expectedCount, students.Count);
                Assert.AreEqual(i.ToString(), students.GetStudent(0).Name);

                // Test that the previous item that was at index 0 is now at 1
                if (i != StartValue)
                    Assert.AreEqual((i - 1).ToString(), students.GetStudent(1).Name);
            }

            // Test adding students at index 5
            StartValue = 50;
            for (int i = StartValue; i <= 100; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s, 5);
                expectedCount++;

                // Test current student i was inserted at index 5
                Assert.AreEqual(i.ToString(), students.GetStudent(5).Name);
                Assert.AreEqual(expectedCount, students.Count);

                // Test that the previous item that was at index 5 is now at 6
                if (i != StartValue)
                    Assert.AreEqual((i - 1).ToString(), students.GetStudent(6).Name);
            }
            
        }

        /// <summary>
        ///A test for ClearStudents
        ///</summary>
        [TestMethod()]
        public void ClearStudentsTest()
        {
            StudentList students = new StudentList();
            int StartValue = 1;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, students.Count);

            // Add some students to the list
            for (int i = StartValue; i <= 20; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s);
                expectedCount++;
            }

            Assert.AreEqual(expectedCount, students.Count);
            students.ClearStudents();
            expectedCount = 0;
            Assert.AreEqual(expectedCount, students.Count);

            // Add some more students to the list
            StartValue = 100;
            for (int i = StartValue; i <= 150; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s);
                expectedCount++;
            }

            Assert.AreEqual(expectedCount, students.Count);
            students.ClearStudents();
            expectedCount = 0;
            Assert.AreEqual(expectedCount, students.Count);  
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            StudentList students = new StudentList();
            int StartValue = 25;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, students.Count);

            // Add some students to the list
            for (int i = StartValue; i <= 75; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s);
                expectedCount++;
            }

            Assert.AreEqual(expectedCount, students.Count);
            students = new StudentList();
            expectedCount = 0;
            Assert.AreEqual(expectedCount, students.Count);

            StartValue = 0;
            for (int i = StartValue; i <= 30; i++)
            {
                Student s = new Student(i.ToString());
                students.AddStudent(s);
                expectedCount++;
            }

            Assert.AreEqual(expectedCount, students.Count);
            students = new StudentList();
            expectedCount = 0;
            Assert.AreEqual(expectedCount, students.Count);
        }

        /// <summary>
        ///A test for FindStudentByID
        ///</summary>
        [TestMethod()]
        public void FindStudentByIDTest()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew", name4 = "John", name5 = "Frank";
            string id1 = "111", id2 = "222", id3 = "333", id4 = "444", id5 = "555";

            StudentList students = new StudentList();
            Student s1 = new Student(name1, id1);
            Student s2 = new Student(name2, id2);
            Student s3 = new Student(name3, id3);
            Student s4 = new Student(name4, id4);
            Student s5 = new Student(name5, id5);

            students.AddStudent(s1);
            students.AddStudent(s2);
            students.AddStudent(s3);
            students.AddStudent(s4);
            students.AddStudent(s5);

            Student actual = students.FindStudentByID(id1);
            Assert.AreEqual(s1.Name, actual.Name);
            Assert.AreEqual(s1.StudentID, actual.StudentID);
            Assert.AreSame(s1, actual);         // test that object returned is the same object

            actual = students.FindStudentByID(id2);
            Assert.AreEqual(s2.Name, actual.Name);
            Assert.AreEqual(s2.StudentID, actual.StudentID);
            Assert.AreSame(s2, actual);         // test that object returned is the same object

            actual = students.FindStudentByID(id3);
            Assert.AreEqual(s3.Name, actual.Name);
            Assert.AreEqual(s3.StudentID, actual.StudentID);
            Assert.AreSame(s3, actual);         // test that object returned is the same object

            actual = students.FindStudentByID(id4);
            Assert.AreEqual(s4.Name, actual.Name);
            Assert.AreEqual(s4.StudentID, actual.StudentID);
            Assert.AreSame(s4, actual);         // test that object returned is the same object

            actual = students.FindStudentByID(id5);
            Assert.AreEqual(s5.Name, actual.Name);
            Assert.AreEqual(s5.StudentID, actual.StudentID);
            Assert.AreSame(s5, actual);         // test that object returned is the same object
        }

        /// <summary>
        ///A test for GetItems
        ///</summary>
        [TestMethod()]
        public void GetStudentsTest()
        {
            StudentList students = new StudentList();
            ArrayList listOfStudents = new ArrayList();
            int count = 20;

            for (int i = 0; i < count; i++)
                students.AddStudent(new Student(i.ToString()));

            Assert.AreEqual(count, students.Count);

            listOfStudents = students.GetStudents();
            Assert.AreEqual(listOfStudents.Count, students.Count);

            for (int i = 0; i < count; i++)
            {
                Student s = (Student)listOfStudents[i];
                Assert.AreEqual(s.Name, students.GetStudent(i).Name);
            }
            
        }

        /// <summary>
        ///A test for GetStudent
        ///</summary>
        [TestMethod()]
        public void GetStudentTest()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "111", id2 = "222", id3 = "333";

            StudentList students = new StudentList();
            Student s1 = new Student(name1, id1);
            Student s2 = new Student(name2, id2);
            Student s3 = new Student(name3, id3);

            students.AddStudent(s1);
            students.AddStudent(s2);
            students.AddStudent(s3);

            Student actual = students.GetStudent(0);
            Assert.AreEqual(s1.Name, actual.Name);
            Assert.AreEqual(s1.StudentID, actual.StudentID);
            Assert.AreSame(s1, actual);         // test that object returned is the same object

            actual = students.GetStudent(1);
            Assert.AreEqual(s2.Name, actual.Name);
            Assert.AreEqual(s2.StudentID, actual.StudentID);
            Assert.AreSame(s2, actual);         // test that object returned is the same object

            actual = students.GetStudent(2);
            Assert.AreEqual(s3.Name, actual.Name);
            Assert.AreEqual(s3.StudentID, actual.StudentID);
            Assert.AreSame(s3, actual);

            actual = students.GetStudent(333);
            Assert.AreEqual(null, actual);
        }

        /// <summary>
        ///A test for GetStudent
        ///</summary>
        [TestMethod()]
        public void GetStudentTest2()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "111", id2 = "222", id3 = "333";

            StudentList students = new StudentList();
            Student s1 = new Student(name1, id1);
            Student s2 = new Student(name2, id2);
            Student s3 = new Student(name3, id3);

            students.AddStudent(s1);
            students.AddStudent(s2);
            students.AddStudent(s3);

            Student actual = students.GetStudent(s1);
            Assert.AreEqual(s1.Name, actual.Name);
            Assert.AreEqual(s1.StudentID, actual.StudentID);
            Assert.AreSame(s1, actual);         // test that object returned is the same object

            actual = students.GetStudent(s2);
            Assert.AreEqual(s2.Name, actual.Name);
            Assert.AreEqual(s2.StudentID, actual.StudentID);
            Assert.AreSame(s2, actual);         // test that object returned is the same object

            actual = students.GetStudent(s3);
            Assert.AreEqual(s3.Name, actual.Name);
            Assert.AreEqual(s3.StudentID, actual.StudentID);
            Assert.AreSame(s3, actual);

            actual = students.GetStudent(new Student("Not in list", "333"));
            Assert.AreEqual(null, actual);
        }

        /// <summary>
        ///A test for NextStudent
        ///</summary>
        [TestMethod()]
        public void NextStudentTest()
        {
            StudentList students = new StudentList();
            Student s;
            int count = 30;

            // Test that the method returns null on an empty list
            s = students.NextStudent();
            Assert.AreEqual(null, s);

            // Add some students to the list
            for (int i = 1; i <= count; i++)
            {
                students.AddStudent(new Student(i.ToString(), i.ToString()));
            }

            // Test all elements are found in order
            for (int i = 1; i <= count; i++)
            {
                s = students.NextStudent();
                Assert.AreEqual(i.ToString(), s.Name);
                Assert.AreEqual(i.ToString(), s.StudentID);
            }

            // Test that the method continues to return the last student in the list 
            // when positioned at the end
            for (int i = 1; i < 10; i++)
            {
                s = students.NextStudent();
                Assert.AreEqual(count.ToString(), s.Name);
                Assert.AreEqual(count.ToString(), s.StudentID);
            }
        }

        /// <summary>
        ///A test for PreviousStudent
        ///</summary>
        [TestMethod()]
        public void PreviousStudentTest()
        {
            StudentList students = new StudentList();
            Student s;
            int count = 40;

            // Test that the method returns null on an empty list
            s = students.PreviousStudent();
            Assert.AreEqual(null, s);

            // Add some students to the list
            for (int i = 1; i <= count; i++)
            {
                students.AddStudent(new Student(i.ToString(), i.ToString()));
            }

            // Test all elements are found in order and position the "cursor" at the end of the list
            for (int i = 1; i <= count; i++)
            {
                s = students.NextStudent();
                Assert.AreEqual(i.ToString(), s.Name);
                Assert.AreEqual(i.ToString(), s.StudentID);
            }

            // Test that for the end of the list, which should return the last element
            for (int i = 1; i < 10; i++)
            {
                s = students.NextStudent();
                Assert.AreEqual(count.ToString(), s.Name);
                Assert.AreEqual(count.ToString(), s.StudentID);
            }

            // Test that all elements are found in order using the PreviousStudent method
            for (int i = count - 1; i > 0; i--)
            {
                s = students.PreviousStudent();
                Assert.AreEqual(i.ToString(), s.Name);
                Assert.AreEqual(i.ToString(), s.StudentID);
            }

            // Test that all subsequent calls to PreviousStudent return the first student
            int first = 1;
            for (int i = 0; i < 10; i++)
            {

                s = students.PreviousStudent();
                Assert.AreEqual(first.ToString(), s.Name);
                Assert.AreEqual(first.ToString(), s.StudentID);
            }
        }

        /// <summary>
        ///A test for RemoveStudent
        ///</summary>
        [TestMethod()]
        public void RemoveStudentTest()
        {
            string name1 = "Chris", name2 = "Mike", name3 = "Matthew";
            string id1 = "111", id2 = "222", id3 = "333";

            StudentList students = new StudentList();
            Student s1 = new Student(name1, id1);
            Student s2 = new Student(name2, id2);
            Student s3 = new Student(name3, id3);
            int expectedCount = 3;

            students.AddStudent(s1);
            students.AddStudent(s2);
            students.AddStudent(s3);

            // remove each student from the beginning of the list and test
            Assert.AreEqual(expectedCount, students.Count);
            Assert.AreEqual(true, students.RemoveStudent(0));
            expectedCount--;
            Assert.AreEqual(expectedCount, students.Count);

            Assert.AreEqual(expectedCount, students.Count);
            Assert.AreEqual(true, students.RemoveStudent(0));
            expectedCount--;
            Assert.AreEqual(expectedCount, students.Count);

            Assert.AreEqual(expectedCount, students.Count);
            Assert.AreEqual(true, students.RemoveStudent(0));
            expectedCount--;
            Assert.AreEqual(expectedCount, students.Count);

            // try to remove a student from the empty list
            Assert.AreEqual(expectedCount, students.Count);
            Assert.AreEqual(false, students.RemoveStudent(0));
            Assert.AreEqual(expectedCount, students.Count);
            
            
        }

        /// <summary>
        ///A test for RemoveStudent
        ///</summary>
        [TestMethod()]
        public void RemoveStudentTest2()
        {
            StudentList students = new StudentList();
            List<Student> list = new List<Student>();

            int expectedCount = 0;

            // Add some students to the list
            for (int i = 1; i < 50; i++)
            {
                Student s = new Student(i.ToString(), i.ToString());
                students.AddStudent(s);
                list.Add(s);
                expectedCount++;
            }

            // Remove each student and test
            for (int i = 0; i < list.Count; i++)
            {
                Student s = list[i];
                Assert.AreEqual(true, students.RemoveStudent(s));
                expectedCount--;
                Assert.AreEqual(expectedCount, students.Count);
            }

            // test that the list is empty
            Assert.AreEqual(0, students.Count);

            // try to remove one more item
            Assert.AreEqual(false, students.RemoveStudent(list[0]));

        }

    }
}
