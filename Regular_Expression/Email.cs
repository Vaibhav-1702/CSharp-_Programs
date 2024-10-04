using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    public class Email
    {
        static void Main()
        {
            // Regex pattern for a valid email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Test email addresses
            string[] emails = {
            "john.doe@example.com",
            "john@sub.example.org",
            "invalid-email@.com",
            "name@domain.c",
            "user@domain.com",
            "username@domain..com"
        };

            foreach (string email in emails)
            {
                if (Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine($"{email} is a valid email address.");
                }
                else
                {
                    Console.WriteLine($"{email} is not a valid email address.");
                }
            }
        }
    }
}
