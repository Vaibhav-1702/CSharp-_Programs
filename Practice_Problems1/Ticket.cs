//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Problems1
//{
//    public class Ticket
//    {
//        static void Main()
//        {
            
//            Console.Write("Enter the customer's age: ");
//            int age = int.Parse(Console.ReadLine());

            
//            Console.Write("Enter the time of the movie (24-hour format, e.g., 14 for 2 PM): ");
//            int time = int.Parse(Console.ReadLine());

//            double ticketPrice;

            
//            if (age < 12)
//            {
//                ticketPrice = 100.00; // for children
//            }
//            else if (age >= 65)
//            {
//                ticketPrice = 150.00; //  for seniors citizen
//            }
//            else
//            {
//                ticketPrice = 200.00; // for adult
//            }

//            // Apply matinee discount if the time is before 5 PM (17:00)
//            if (time < 17)
//            {
//                ticketPrice -= 50.00; // Matinee discount of 50
//            }

//            // Output final ticket price
//            Console.WriteLine($"The price of the movie ticket is: ${ticketPrice:F2}");
//        }
//    }
//}
