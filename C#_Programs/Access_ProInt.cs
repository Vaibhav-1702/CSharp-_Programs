using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs
{ 
    class Student
    {
        protected internal string msg = "Hello";
    }
    public class Access_ProInt
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();   
            Console.WriteLine(s1.msg);
        }
    }
}
