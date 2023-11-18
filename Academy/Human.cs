using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine("HConstructor:\t" + GetHashCode());
        }
        public Human(Human other)
        {
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine("HCopyConstructor:\t" + GetHashCode());
        }
        ~Human()
        {
            Console.WriteLine("HDestructor:\t" + GetHashCode());
        }
        public void Info()
        {
            Console.WriteLine($"{LastName} {FirstName} {Age} лет");
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age} лет";
        }
    }
}
