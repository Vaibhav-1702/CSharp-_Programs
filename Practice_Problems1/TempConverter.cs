//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Problems1
//{
//    public class TempConverter
//    {
//        static void Main()
//        {
//            Console.WriteLine("Temperature Converter");
//            Console.WriteLine("1. Convert Fahrenheit to Celsius");
//            Console.WriteLine("2. Convert Celsius to Fahrenheit");
//            Console.Write("Choose an option (1 or 2): ");

//            int choice = int.Parse(Console.ReadLine());

//            if (choice == 1)
//            {
//                // Fahrenheit to Celsius
//                Console.Write("Enter temperature in Fahrenheit: ");
//                double fahrenheit = double.Parse(Console.ReadLine());

//                double celsius = (fahrenheit - 32) * 5 / 9;
//                Console.WriteLine($"Temperature in Celsius: {celsius:F2}°C");
//            }
//            else if (choice == 2)
//            {
//                // Celsius to Fahrenheit
//                Console.Write("Enter temperature in Celsius: ");
//                double celsius = double.Parse(Console.ReadLine());

//                double fahrenheit = (celsius * 9 / 5) + 32;
//                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}°F");
//            }
//            else
//            {
//                Console.WriteLine("Invalid choice! Please enter 1 or 2.");
//            }
//        }
//    }
//}
