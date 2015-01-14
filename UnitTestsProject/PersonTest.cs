using MyClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsProject
{
    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonTest
    {


        private TestContext testContextInstance;

        Person person1, person2, person3;
        string name1 = "Chris Pascucci", name2 = "Mike Cherry", name3 = "Matthew Grape";
        DateTime dob1 = new DateTime(2000, 1, 1);
        DateTime dob2 = new DateTime(1990, 2, 2);
        DateTime dob3 = new DateTime(1985, 12, 31);
        DateTime dob4 = new DateTime(2014, 1, 5);
        DateTime dob5 = new DateTime(2011, 10, 1);
        DateTime dob6 = new DateTime(2001, 4, 10);
        int age1, age2, age3, age4, age5, age6;

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
        
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            age1 = CalculateAge(dob1);
            age2 = CalculateAge(dob2);
            age3 = CalculateAge(dob3);
            age4 = CalculateAge(dob4);
            age5 = CalculateAge(dob5);
            age6 = CalculateAge(dob6);
        }
        
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            person1 = null;
            person2 = null;
            person3 = null;
        }
        
        #endregion


        /// <summary>
        ///A test for Person Default Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest()
        {
            Assert.AreEqual(null, person1);
            
            person1 = new Person();
            Assert.AreNotEqual(null, person1);
            Assert.AreEqual(string.Empty, person1.Name);
            Assert.AreEqual(string.Empty, person1.FirstName);
            Assert.AreEqual(string.Empty, person1.LastName);
            Assert.AreEqual(0, person1.Age);
            Assert.AreEqual(DateTime.Today, person1.BirthDate);
        }

        /// <summary>
        ///A test for Person Constructor (string)
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest2()
        {
            Assert.AreEqual(null, person1);

            person1 = new Person(name1);
            Assert.AreNotEqual(null, person1);
            Assert.AreEqual(name1, person1.Name);
            Assert.AreEqual(string.Empty, person1.FirstName);
            Assert.AreEqual(string.Empty, person1.LastName);
            Assert.AreEqual(0, person1.Age);
            Assert.AreEqual(DateTime.Today, person1.BirthDate);

            person2 = new Person(name2);
            Assert.AreNotEqual(null, person2);
            Assert.AreEqual(name2, person2.Name);
            Assert.AreEqual(string.Empty, person2.FirstName);
            Assert.AreEqual(string.Empty, person2.LastName);
            Assert.AreEqual(0, person2.Age);
            Assert.AreEqual(DateTime.Today, person2.BirthDate);

            person3 = new Person(name3);
            Assert.AreNotEqual(null, person3);
            Assert.AreEqual(name3, person3.Name);
            Assert.AreEqual(string.Empty, person3.FirstName);
            Assert.AreEqual(string.Empty, person3.LastName);
            Assert.AreEqual(0, person3.Age);
            Assert.AreEqual(DateTime.Today, person3.BirthDate);
        }

        /// <summary>
        ///A test for Person Constructor (string, DateTime)
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest3()
        {
            Assert.AreEqual(null, person1);

            person1 = new Person(name1, dob1);
            Assert.AreNotEqual(null, person1);
            Assert.AreEqual(name1, person1.Name);
            Assert.AreEqual(string.Empty, person1.FirstName);
            Assert.AreEqual(string.Empty, person1.LastName);
            Assert.AreEqual(age1, person1.Age);
            Assert.AreEqual(dob1, person1.BirthDate);

            person2 = new Person(name2, dob2);
            Assert.AreNotEqual(null, person2);
            Assert.AreEqual(name2, person2.Name);
            Assert.AreEqual(string.Empty, person2.FirstName);
            Assert.AreEqual(string.Empty, person2.LastName);
            Assert.AreEqual(age2, person2.Age);
            Assert.AreEqual(dob2, person2.BirthDate);

            person3 = new Person(name3, dob3);
            Assert.AreNotEqual(null, person3);
            Assert.AreEqual(name3, person3.Name);
            Assert.AreEqual(string.Empty, person3.FirstName);
            Assert.AreEqual(string.Empty, person3.LastName);
            Assert.AreEqual(age3, person3.Age);
            Assert.AreEqual(dob3, person3.BirthDate);
           
        }

        /// <summary>
        ///A test for Address
        ///</summary>
        [TestMethod()]
        public void AddressTest()
        {
            string add1 = "101 Here Street";
            string add2 = "333 Broad Street";
            string add3 = "1 Market Street";

            person1 = new Person();
            Assert.AreEqual(string.Empty, person1.Address);
            person1.Address = add1;
            Assert.AreEqual(add1, person1.Address);
            person1.Address = add2;
            Assert.AreEqual(add2, person1.Address);
            person1.Address = add3;
            Assert.AreEqual(add3, person1.Address);

            person2 = new Person();
            person2.Address = person1.Address;
            Assert.AreEqual(person1.Address, person2.Address);
        }

        /// <summary>
        ///A test for Age
        ///</summary>
        [TestMethod()]
        public void AgeTest()
        {
            person1 = new Person(name1, dob1);
            person2 = new Person(name2, dob2);
            person3 = new Person(name3, dob3);

            Assert.AreEqual(age1, person1.Age);

            person1.BirthDate = dob5;
            Assert.AreEqual(age5, person1.Age);

            Assert.AreEqual(age2, person2.Age);
            Assert.AreEqual(age3, person3.Age);

            person2.BirthDate = dob4;
            Assert.AreEqual(age4, person2.Age);

            person3.BirthDate = dob5;
            Assert.AreEqual(age5, person3.Age);

            person3.BirthDate = DateTime.Today;
            Assert.AreEqual(0, person3.Age);

        }

        /// <summary>
        ///A test for BirthDate
        ///</summary>
        [TestMethod()]
        public void BirthDateTest()
        {
            person1 = new Person(name1, dob1);
            person2 = new Person();
            person3 = new Person();

            Assert.AreEqual(dob1, person1.BirthDate);
            Assert.AreEqual(new DateTime(dob1.Year, dob1.Month, dob1.Day), person1.BirthDate);
            
            person2.BirthDate = dob2;
            Assert.AreEqual(dob2, person2.BirthDate);
            Assert.AreEqual(new DateTime(dob2.Year, dob2.Month, dob2.Day), person2.BirthDate);

            Assert.AreEqual(DateTime.Today, person3.BirthDate);
            person3.BirthDate = dob3;
            Assert.AreEqual(dob3, person3.BirthDate);

            try
            {
                person3.BirthDate = new DateTime(2100, 1, 1);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(dob3, person3.BirthDate);
            }

        }

        /// <summary>
        ///A test for City
        ///</summary>
        [TestMethod()]
        public void CityTest()
        {
            string city1 = "Philadelphia";
            string city2 = "Las Vegas";
            string city3 = "Atlantic City";

            person1 = new Person();
            Assert.AreEqual(string.Empty, person1.City);
            person1.City = city1;
            Assert.AreEqual(city1, person1.City);
            person1.City = city2;
            Assert.AreEqual(city2, person1.City);
            person1.City = city3;
            Assert.AreEqual(city3, person1.City);

            person2 = new Person();
            person2.City = person1.City;
            Assert.AreEqual(person1.City, person2.City);
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            string fn1 = "Maryanne", fn2 = "Kristin", fn3 = "Ida";
            person1 = new Person();
            person2 = new Person();
            person3 = new Person();
            person1.FirstName = fn1;
            person2.FirstName = fn2;
            person3.FirstName = fn3;

            Assert.AreEqual(fn1, person1.FirstName);
            Assert.AreEqual(fn2, person2.FirstName);
            Assert.AreEqual(fn3, person3.FirstName);

            person1.FirstName = person2.FirstName;
            Assert.AreEqual(fn2, person1.FirstName);

            person2.FirstName = string.Empty;
            Assert.AreEqual(string.Empty, person2.FirstName);
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            string ln1 = "Grape", ln2 = "Tea", ln3 = "Cherry";
            person1 = new Person();
            person2 = new Person();
            person3 = new Person();
            person1.LastName = ln1;
            person2.LastName = ln2;
            person3.LastName = ln3;

            Assert.AreEqual(ln1, person1.LastName);
            Assert.AreEqual(ln2, person2.LastName);
            Assert.AreEqual(ln3, person3.LastName);

            person1.LastName = person2.LastName;
            Assert.AreEqual(ln2, person1.LastName);

            person2.LastName = string.Empty;
            Assert.AreEqual(string.Empty, person2.LastName);
        }
                        

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            person1 = new Person(name1, dob1);
            person2 = new Person(name2);
            person3 = new Person();
            person3.Name = name3;

            Assert.AreEqual(name1, person1.Name);
            Assert.AreEqual(name2, person2.Name);
            Assert.AreEqual(name3, person3.Name);

            person1.Name = person2.Name;
            Assert.AreEqual(name2, person1.Name);

            person3.Name = string.Empty;
            Assert.AreEqual(string.Empty, person3.Name);

        }

        /// <summary>
        ///A test for State
        ///</summary>
        [TestMethod()]
        public void StateTest()
        {
            string state1 = "Pennsylvania";
            string state2 = "Nevada";
            string state3 = "New Jersey";

            person1 = new Person();
            Assert.AreEqual(string.Empty, person1.State);
            person1.State = state1;
            Assert.AreEqual(state1, person1.State);
            person1.State = state2;
            Assert.AreEqual(state2, person1.State);
            person1.State = state3;
            Assert.AreEqual(state3, person1.State);

            person2 = new Person();
            person2.State = person1.State;
            Assert.AreEqual(person1.State, person2.State);
        }

        /// <summary>
        ///A test for ZipCode
        ///</summary>
        [TestMethod()]
        public void ZipCodeTest()
        {
            int zip1 = 19122;
            int zip2 = 89109;
            
            person1 = new Person();
            Assert.AreEqual(0, person1.ZipCode);
            person1.ZipCode = zip1;
            Assert.AreEqual(zip1, person1.ZipCode);
            person1.ZipCode = zip2;
            Assert.AreEqual(zip2, person1.ZipCode);

            person2 = new Person();
            person2.ZipCode = person1.ZipCode;
            Assert.AreEqual(person1.ZipCode, person2.ZipCode);
          
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
