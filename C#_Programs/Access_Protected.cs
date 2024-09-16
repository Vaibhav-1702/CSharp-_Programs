using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs
{
    class Student
    {
        protected string name = "Vaibhav"; //accessible within the same class, or in a class that is inherited from this class
    }
    class Student2 : Student
    {
        public void print()
        {
            Console.WriteLine("Name = " + name);
        }
    }
    public class Access_Protected
    {
        static void Main(string[] args)
        {
            Student2 s1 = new Student2();
            s1.print();
            
        }
    }
}
