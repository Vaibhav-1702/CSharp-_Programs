//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Game
//{
//    using System;

//    class SnakeAndLadderGame
//    {
//        const int WINNING_POSITION = 100; // The winning position on the board
//        static Random random = new Random(); // Random number generator

//        static void Main(string[] args)
//        {
//            // Case 1: Single Player Starts at Position 0
//            int playerPosition = 0;
//            int diceRollCount = 0;

//            Console.WriteLine("Welcome to Snake and Ladder Game!");
//            Console.WriteLine("Starting position: " + playerPosition);

//            // Case 4: Repeat till the player reaches the winning position 100
//            while (playerPosition < WINNING_POSITION)
//            {
//                // Case 2: The Player rolls the die to get a number between 1 to 6
//                int dieRoll = RollDie();
//                diceRollCount++;
//                Console.WriteLine("Dice rolled: " + dieRoll);

//                // Case 3: Check for No Play, Ladder, or Snake
//                int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake
//                switch (option)
//                {
//                    case 0: // No Play
//                        Console.WriteLine("No Play: Player stays at position " + playerPosition);
//                        break;

//                    case 1: // Ladder
//                        Console.WriteLine("Ladder: Player moves ahead by " + dieRoll);
//                        playerPosition += dieRoll;
//                        break;

//                    case 2: // Snake
//                        Console.WriteLine("Snake: Player moves behind by " + dieRoll);
//                        playerPosition -= dieRoll;
//                        break;
//                }

//                // Case 4: If the player position moves below 0, restart from 0
//                if (playerPosition < 0)
//                {
//                    playerPosition = 0;
//                    Console.WriteLine("Player's position reset to 0");
//                }

//                // Case 5: Ensure the player gets to the exact winning position 100
//                if (playerPosition > WINNING_POSITION)
//                {
//                    playerPosition -= dieRoll; // Stay at the same position if overshoot
//                    Console.WriteLine("Overshoot! Player stays at position " + playerPosition);
//                }

//                // Reporting the current position after each die roll
//                Console.WriteLine("Player is now at position " + playerPosition);
//            }

//            // Case 6: Reporting the total number of dice rolls taken to win the game
//            Console.WriteLine("Congratulations! You reached the winning position 100.");
//            Console.WriteLine("Total dice rolls to win the game: " + diceRollCount);
//        }

//        // Method to simulate a die roll between 1 and 6
//        static int RollDie()
//        {
//            return random.Next(1, 7); // Generates a random number between 1 and 6
//        }
//    }

//}
