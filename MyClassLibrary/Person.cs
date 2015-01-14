using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

   

    public class Person
    {
        private string fullName;        // Person's full name
        private string firstName;       // Person's first name
        private string lastName;        // Person's last name
        private int age;                // Person's age
        private DateTime birthDate;     // Person's date of birth
        private string city;            // Person's city of residence
        private string state;           // Person's state of residence
        private string address;         // Person's street address
        private int zip;                // Person's zip code
        
        public delegate void BirthdayChangedHandler(object obj);
        public event BirthdayChangedHandler BirthdayChanged;

        // Default constructor
        public Person()
        {
            fullName = "";
            firstName = "";
            lastName = "";
            age = 0;
            birthDate = DateTime.Today;
            city = "";
            state = "";
            address = "";
            zip = 0;
        }

        // Parameterized constructor
        public Person(string name) // : this()
        {
            this.Name = name;       // using the property to set the fullName field
            firstName = "";
            lastName = "";
            age = 0; ;
            birthDate = DateTime.Today;
            city = "";
            state = "";
            address = "";
            zip = 0;
        }

        // Parameterized constructor
        public Person(string name, DateTime dob)
        {
            this.Name = name;       // using the property
            this.BirthDate = dob;   // using the property
            firstName = "";
            lastName = "";
            city = "";
            state = "";
            address = "";
            zip = 0;
        }

        // Accessor/Mutator for fullName field
        public string Name
        {
            get { return fullName; }
            set { fullName = value; }
        }

        // Accessor/Mutator for birth date field
        // the set procedure calculates and sets the age field
        public DateTime BirthDate
        {
            get { return new DateTime(birthDate.Year, birthDate.Month, birthDate.Day); }
            set
            {
                // check that the dob isn't a future date
                if (value > DateTime.Now)
                    throw new ArgumentException("Date of birth cannot be a future date.");

                if (BirthdayChanged != null)
                    if (birthDate != value)
                        BirthdayChanged(this);
            

                birthDate = value;
                age = CalculateAge();

            }
        }

        // Accessor for age field
        public int Age
        {
            get { return age; }
        }

        // Accessor/Mutator for firstName field
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Accessor/Mutator for lastName field
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Accessor/Mutator for city field
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // Accessor/Mutator for state field
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        // Accessor/Mutator for address field
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Accessor/Mutator for zip field
        public int ZipCode
        {
            get { return zip; }
            set { zip = value; }
        }

        // private helper method that calculates and returns the age of a Person
        private int CalculateAge()
        {
            int years = 0;

            // Calculate the difference in years
            years = DateTime.Now.Year - birthDate.Year;

            // Subtract another year if the Person's birthday didn't come yet.
            if (DateTime.Now.Month < birthDate.Month ||
               (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
                years = years - 1;

            return years;
        }
    }
}
