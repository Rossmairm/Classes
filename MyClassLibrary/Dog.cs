using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public delegate void BarkedHandler(object sender);

    public class Dog
    {
        private string name;
        private string breed;
        private int age;
        private static int dogCount;

        // Declare an event
        public event BarkedHandler Barked;

        // Default constructor
        public Dog()
        {
            dogCount++;
        }

        // Parameterized constructor
        public Dog(string name)
        {
            this.name = name;
            dogCount++;
        }

        // Parameterized constructor
        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
            dogCount++;
        }

        // Parameterized constructor
        public Dog(string name, int age, string breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            dogCount++;
        }

        // Property to Access/Mutate the name field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property to Access/Mutate the breed field
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        // Property to Access/Mutate the age field
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Bark()
        {
            Console.WriteLine(name + ": woof, woof, woof");
            Barked(this);   // raise the event
        }

        public void Bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(name + ": woof, woof, woof");
            }
            Barked(this);   // raise the event
        }

        public void Bark(string message, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(name + ": " + message);
            }
            Barked(this);   // raise the event
        }

        public override string ToString()
        {
            return name + ", " + age + ", " + breed;
        }

    }
}
