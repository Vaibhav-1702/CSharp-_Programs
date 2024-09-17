//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Problems1
//{
//    public class StonePaperScissor
//    {
//        static void Main()
//        {
//            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

//            // Prompt the user to enter their choice
//            Console.WriteLine("Enter your choice (rock, paper, scissors): ");
//            string userChoice = Console.ReadLine().ToLower();

//            // Validate user input
//            if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
//            {
//                Console.WriteLine("Invalid choice. Please choose rock, paper, or scissors.");
//                return;
//            }

//            // Generate computer's choice randomly
//            string[] choices = { "rock", "paper", "scissors" };
//            Random random = new Random();
//            string computerChoice = choices[random.Next(0, 3)];

//            // Display the computer's choice
//            Console.WriteLine($"Computer chose: {computerChoice}");

//            // Determine the winner using conditional statements
//            if (userChoice == computerChoice)
//            {
//                Console.WriteLine("It's a tie!");
//            }
//            else if ((userChoice == "rock" && computerChoice == "scissors") ||
//                     (userChoice == "scissors" && computerChoice == "paper") ||
//                     (userChoice == "paper" && computerChoice == "rock"))
//            {
//                Console.WriteLine("You win!");
//            }
//            else
//            {
//                Console.WriteLine("You lose!");
//            }
//        }
//    }
//}
