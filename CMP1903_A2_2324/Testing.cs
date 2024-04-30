using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    internal class Testing
    {
        public static void Test()
        {
            Console.WriteLine("The testing mode will let you know if any errors occur while the game play out.");
            Console.WriteLine("The testing mode tests the version of the game against the computer, as the gamemodes use the same base mechanics.");
            Console.WriteLine("Start game? [Y/N]");
            string startGame = Console.ReadLine();
            int Winner = 0;
            while (startGame == "Y")
            {
                while (Winner == 0)
                {
                    int playerOneRoll = SevensOutPlayerOne.SevensPlayerOne();
                    int playerTwoRoll = SevensOutPlayerTwo.SevensPlayerTwo();
                    if (playerOneRoll != 7 && playerTwoRoll != 7)
                    {

                        Console.WriteLine("Player One rolled..." + playerOneRoll);
                        Console.WriteLine("Computer rolled..." + playerTwoRoll);
                        Debug.Assert(playerOneRoll != 7 && playerTwoRoll != 7, "The sum of the rolls was displayed incorrectly!");
                    }
                    if (playerOneRoll == 7 && playerTwoRoll != 7)
                    {
                        Console.WriteLine("Player One rolled..." + playerOneRoll);
                        Statistics.PlayerOneWins++;
                        Winner = 1;
                        Debug.Assert(playerOneRoll == 7 && playerTwoRoll != 7, "The sum of the rolls was displayed incorrectly!");
                    }
                    if (playerOneRoll != 7 && playerTwoRoll == 7)
                    {
                        Console.WriteLine("Computer rolled..." + playerTwoRoll);
                        Statistics.ComputerWins++;
                        Winner = 2;
                        Debug.Assert(playerOneRoll != 7 && playerTwoRoll == 7, "The sum of the rolls was displayed incorrectly!");
                    }
                    if (playerOneRoll == 7 && playerTwoRoll == 7)
                    {
                        Console.WriteLine("Player One rolled..." + playerOneRoll);
                        Console.WriteLine("Computer rolled..." + playerTwoRoll);
                        Statistics.Draws++;
                        Debug.Assert(playerOneRoll == 7 && playerTwoRoll == 7, "The sum of the rolls was displayed incorrectly!");
                        Winner = 3;
                    }
                    if (Winner == 1)
                    {
                        Winner = 0;
                        Console.WriteLine("Player One Wins!");
                        Console.WriteLine("Keep playing? [Y/N]");
                        string keepPlaying = Console.ReadLine();
                        if (keepPlaying == "Y")
                        {
                            Console.WriteLine("Restarting. Enjoy!");
                            Winner = 0;
                            startGame = "Y";
                        }
                        if (keepPlaying != "Y")
                        {
                            Console.WriteLine("See you next time!");
                            startGame = "N";
                            break;

                        }
                    }
                    if (Winner == 2)
                    {
                        Console.WriteLine("Computer Wins!");
                        Console.WriteLine("Keep playing? [Y/N]");
                        string keepPlaying = Console.ReadLine();
                        if (keepPlaying == "Y")
                        {
                            Console.WriteLine("Restarting. Enjoy!");
                            Winner = 0;
                            startGame = "Y";
                        }
                        if (keepPlaying != "Y")
                        {
                            Console.WriteLine("See you next time!");
                            startGame = "N";
                            break;

                        }
                    }
                    if (Winner == 3)
                    {
                        Winner = 0;
                        Console.WriteLine("Draw!");
                        Console.WriteLine("Keep playing? [Y/N]");
                        string keepPlaying = Console.ReadLine();
                        if (keepPlaying == "Y")
                        {
                            Console.WriteLine("Restarting. Enjoy!");
                            Winner = 0;
                            startGame = "Y";
                        }
                        if (keepPlaying != "Y")
                        {
                            Console.WriteLine("See you next time!");
                            startGame = "N";
                            break;

                        }
                    }
                }
            }

        }
    }
}