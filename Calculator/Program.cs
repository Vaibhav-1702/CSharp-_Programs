using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
     public class Program
    {
        static void Main(string[] args)
        {
            Calculation c1= new Calculation();
            Console.Write("Enter First No : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second No : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Addition of {a} and {b} is : "+c1.Addition(a,b));
            Console.WriteLine($"Subtraction of {a} and {b} is : " + c1.Subtraction(a,b));
            Console.WriteLine($"Multiplication of {a} and {b} is : " + c1.Multiplication(a,b));
            Console.WriteLine($"Division of {a} by {b} is : " + c1.Division(a,b));
            Console.ReadLine();


        }
    }
}
