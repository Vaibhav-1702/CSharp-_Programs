using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeAndLadder_2Players
    {
        const int WINNING_POSITION = 100;
        static Random random = new Random();

        static void Main(string[] args)
        {
            // Case 7: Two Player Game
            int player1Position = 0;
            int player2Position = 0;
            int diceRollsPlayer1 = 0;
            int diceRollsPlayer2 = 0;
            bool player1Turn = true; // Player 1 starts

            Console.WriteLine("Starting Snake and Ladder Game with 2 Players...");

            while (player1Position < WINNING_POSITION && player2Position < WINNING_POSITION)
            {
                if (player1Turn)
                {
                    Console.WriteLine("Player 1's Turn:");
                    player1Position = PlayTurn(player1Position, ref diceRollsPlayer1);
                    if (player1Position < WINNING_POSITION)
                    {
                        player1Turn = false; // Switch to Player 2 if Player 1 doesn't get a ladder
                    }
                }
                else
                {
                    Console.WriteLine("Player 2's Turn:");
                    player2Position = PlayTurn(player2Position, ref diceRollsPlayer2);
                    if (player2Position < WINNING_POSITION)
                    {
                        player1Turn = true; // Switch back to Player 1 if Player 2 doesn't get a ladder
                    }
                }
            }

            // Case 7: Determine the winner
            if (player1Position == WINNING_POSITION)
            {
                Console.WriteLine("Player 1 Wins! Total Dice Rolls: " + diceRollsPlayer1);
            }
            else
            {
                Console.WriteLine("Player 2 Wins! Total Dice Rolls: " + diceRollsPlayer2);
            }
        }

        // Function to handle each player's turn
        static int PlayTurn(int position, ref int diceRolls)
        {
            // Case 2: Roll the die
            int dieRoll = RollDie();
            diceRolls++;
            Console.WriteLine("Rolled a " + dieRoll);

            // Case 3: Check for No Play, Ladder, or Snake
            int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play: Player stays at position " + position);
                    break;

                case 1:
                    Console.WriteLine("Ladder: Player moves ahead by " + dieRoll);
                    position += dieRoll;
                    break;

                case 2:
                    Console.WriteLine("Snake: Player moves behind by " + dieRoll);
                    position -= dieRoll;
                    break;
            }

            // Case 4: If position goes below 0, reset to 0
            if (position < 0)
            {
                position = 0;
            }

            // Case 5: Ensure player reaches exactly 100 to win
            if (position > WINNING_POSITION)
            {
                position -= dieRoll; // Stay at the same position
            }

            Console.WriteLine("Player is now at position " + position);
            return position;
        }

        // Function to simulate a die roll between 1 and 6
        static int RollDie()
        {
            return random.Next(1, 7); // Die roll between 1 and 6
        }
    }
}
