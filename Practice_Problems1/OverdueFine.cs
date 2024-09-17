using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems1
{
    public class OverdueFine
    {
        static void Main()
        {
            // Fine rate and grace period
            double finePerDay = 0.50;
            int gracePeriod = 7;

            // Input: Number of days overdue
            Console.Write("Enter the number of days the book is overdue: ");
            int overdueDays = int.Parse(Console.ReadLine());

            // Calculate the fine based on the overdue days
            double fine = CalculateFine(overdueDays, gracePeriod, finePerDay);

            // Output the fine
            if (fine == 0)
            {
                Console.WriteLine("No fine, the book is returned within the grace period.");
            }
            else
            {
                Console.WriteLine($"The fine for {overdueDays} overdue days is: ${fine:F2}");
            }
        }

        // Method to calculate the fine
        static double CalculateFine(int overdueDays, int gracePeriod, double finePerDay)
        {
            if (overdueDays <= gracePeriod)
            {
                return 0; // No fine within the grace period
            }
            else
            {
                // Calculate fine for days beyond the grace period
                int chargeableDays = overdueDays - gracePeriod;
                return chargeableDays * finePerDay;
            }
        }
    }

}

