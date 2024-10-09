using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,9,3,5,6,7,1,9};
            List<string> list1 = new List<string>() { };
            List<int> list2 = new List<int>() {3,5,7 };


            Console.WriteLine(" ");

            foreach (var x in list)
            {
                Console.Write(x + " ");
            }


            //Filtering
            var evenNo = list.Where(x=> x % 2 == 0).ToList();
            var oddNo= list.Where(x=> x %2 != 0).ToList();

            //Distinct
            var distinct = list.Distinct().ToList();

            //Order
            var ascOrder = list.OrderBy(x=>x).ToList();
            var desOrder = list.OrderByDescending(x=>x).ToList();

            //first and firstdefault
            var first = list.First();
            var firstD = list1.FirstOrDefault();

            //Any
            var evenNo1 = list.Any(x => x % 2 == 0);
            var evenNo2 = list2.Any(x => x % 2 == 0);

            //All
            var checkEven = list.All(x => x % 2 == 0);
            var checkOdd = list2.All(x => x % 2 != 0);

            //skip and take 
            var TakeFirst = list.Take(4).ToList();
            var SkipFirst = list.Skip(4).ToList();

            //Aggregate
            var sum = list2.Sum(x => x);
            var count = list.Count();
            var min = list.Min(x => x);
            var max = list.Max(x => x);
            var avg = list.Average(x => x);






            foreach (var x in evenNo) 
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(" ");

            foreach (var x in oddNo)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(" ");

            foreach (var x in distinct)
            {
                Console.Write(x + " ");
            }


            Console.WriteLine(" ");

            foreach (var x in ascOrder)
            {
                Console.Write(x + " ");
            }


            Console.WriteLine(" ");

            foreach (var x in desOrder)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(first);
            Console.WriteLine(" ");
            Console.WriteLine(firstD);

            Console.WriteLine(" ");
            Console.WriteLine(evenNo1);
            Console.WriteLine(" ");
            Console.WriteLine(evenNo2);

            Console.WriteLine(" ");
            Console.WriteLine(checkEven);
            Console.WriteLine(" ");
            Console.WriteLine(checkOdd);


            Console.WriteLine(" ");

            foreach (var x in TakeFirst)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(" ");

            foreach (var x in SkipFirst)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of list 2 is : {sum}");
            Console.WriteLine();
            Console.WriteLine($"Count of list 1 is : {count}"); 
            Console.WriteLine();
            Console.WriteLine($"Minimum of list  is : {min}"); 
            Console.WriteLine();
            Console.WriteLine($"Maximum of list  is : {max}"); 
            Console.WriteLine();
            Console.WriteLine($"Average of list  is : {avg}"); 
        }
    }
}
