//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace Regular_Expression
//{
//    public class Password
//    {
//        static void Main()
//        {
//            // Regex pattern for password validation
//            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$";
//            int attempts = 3;
//            bool isPasswordValid = false;

//            while (attempts > 0 && !isPasswordValid)
//            {
//                try
//                {
//                    Console.Write("Enter your password: ");
//                    string password = Console.ReadLine();

//                    // Validate password with regex
//                    if (Regex.IsMatch(password, pattern))
//                    {
//                        Console.WriteLine("Password is valid. Access granted!");
//                        isPasswordValid = true;  // Exit loop
//                    }
//                    else
//                    {
//                        throw new InvalidPasswordException("Invalid password format. Please try again.");
//                    }
//                }
//                catch (InvalidPasswordException ex)
//                {
//                    attempts--;  // Reduce attempt count
//                    Console.WriteLine($"{ex.Message} Attempts left: {attempts}");

//                    if (attempts == 0)
//                    {
//                        Console.WriteLine("Account locked due to too many invalid attempts.");
//                    }
//                }
//            }
//        }
//    }


//    // Custom exception class for invalid password
//    public class InvalidPasswordException : Exception
//    {
//        public InvalidPasswordException(string message) : base(message) { }
//    }
//}

