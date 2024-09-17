using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Loops
{
    public class WhileLoop
    {
        static void Main(string[] args)
        {
            int i, n, j, k;
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            Console.Write($"{i} {j}");

            k = i + j;
            while (k <= n) //print the Fibonacci series up to that number using a while loop
            {
                Console.Write($" {k}");

                i = j;
                j = k;
                k = i + j;
            }
        }
    }
}
