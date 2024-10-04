using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Address;

        // Constructor 1: Default constructor
        public Person() : this("Unknown", 0) // Chaining to Constructor 2
        {
            Console.WriteLine("Default constructor called.");
        }

        // Constructor 2: Constructor with two parameters
        public Person(string name, int age) : this(name, age, "Not provided") // Chaining to Constructor 3
        {
            Console.WriteLine($"Constructor with name and age called. Name: {name}, Age: {age}");
        }

        // Constructor 3: Constructor with three parameters (main constructor)
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
            Console.WriteLine($"Constructor with all parameters called. Name: {name}, Age: {age}, Address: {address}");
        }
    }
    public class Chaining
    {
        public static void Main()
        {
            // Using the default constructor
            Person person1 = new Person();
            Console.WriteLine($"Person1 -> Name: {person1.Name}, Age: {person1.Age}, Address: {person1.Address}\n");

            // Using the constructor with two parameters
            Person person2 = new Person("Alice", 30);
            Console.WriteLine($"Person2 -> Name: {person2.Name}, Age: {person2.Age}, Address: {person2.Address}\n");

            // Using the constructor with all parameters
            Person person3 = new Person("Bob", 40, "123 Street");
            Console.WriteLine($"Person3 -> Name: {person3.Name}, Age: {person3.Age}, Address: {person3.Address}");
        }
    }
}
