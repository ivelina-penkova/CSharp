/*Define a class Person that has name, age and email. The name and age are mandatory. 
The email is optional. Define properties that accept non-empty name and age in the range [1 ... 100].
In case of invalid arguments, throw an exception. Define a property for the email that accepts either null or 
non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email.
The second constructor should take name and age only and call the first constructor. 
Implement the ToString() method to enable printing persons at the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age,"example@gmail.com")
        {
        }

        public override string ToString()
        {
            string result = "Name: " + this.Name + "\nAge: " + this.Age + "\nEmail: " + this.Email;
            return result;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;

            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if(string.IsNullOrEmpty(value) || !(value.Contains('@')))
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.email = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan",22);
            Console.WriteLine(person.ToString());
        }
    }
}
