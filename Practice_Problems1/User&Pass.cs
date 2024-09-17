//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Problems1
//{
//    public class User_Pass
//    {
//        static string storedUsername = "user123";
//        static string storedPassword = "password123";
//        static int maxAttempts = 2;

//        static void Main()
//        {
//            int attempts = 0;
//            bool isLoggedIn = false;

//            while (attempts < maxAttempts && !isLoggedIn)
//            {
//                // Get the username and password from the user
//                Console.Write("Enter your username: ");
//                string username = Console.ReadLine();

//                Console.Write("Enter your password: ");
//                string password = Console.ReadLine();

//                // Check if the username is correct
//                if (username != storedUsername)
//                {
//                    Console.WriteLine("Incorrect username.");
//                }
//                // Check if the password is correct
//                else if (password != storedPassword)
//                {
//                    Console.WriteLine("Incorrect password.");
//                }
//                // If both username and password are correct, login is successful
//                else
//                {
//                    Console.WriteLine("Login successful!");
//                    isLoggedIn = true; // Breaks the loop
//                }

//                attempts++;

//                // If max attempts are reached, account is locked
//                if (attempts == maxAttempts && !isLoggedIn)
//                {
//                    Console.WriteLine("Account locked. Too many failed login attempts.");
//                }
//            }
//        }
//    }
//}
