using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    public class Game
    {
        public static void Main(string[] args)
        {
            int gameOn = 1;
            while (gameOn > 0)                                              // Creating while loop so that user is able to go back to the menu
            {
                Console.WriteLine("Welcome to the Sebastian's cool games!");
                Console.WriteLine("Prompts are CAPS SENSITIVE!");
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine(" SevensOut [1] ; ThreeOrMore [2] (COMING SOON!); Statistics [3]; Testing [4] ; Exit [5]");
                string PlayerResponse = Console.ReadLine();
                if (PlayerResponse == "1")
                {
                    Console.WriteLine("Play with computer [1], or against friend? [2]: ");
                    string CoopChoice = Console.ReadLine();
                    if (CoopChoice == "1")
                    {
                        Console.WriteLine("Loading...");
                        Statistics.TimesPlayed++;
                        int Winner = 0;
                        int playerOneScore = 0; int playerTwoScore = 0; // creating the scores for the players
                        Console.WriteLine("Loading complete!");
                        Console.WriteLine("Start game? [Y/N]");
                        string startGame = Console.ReadLine();
                        while (startGame == "Y")                                                // Creating menu system using print, while loops and if statements
                        {
                            while (Winner == 0)
                            {
                                int playerOneRoll = SevensOutPlayerOne.SevensPlayerOne();
                                int playerTwoRoll = SevensOutPlayerTwo.SevensPlayerTwo(); // Creating roll objects
                                playerOneScore = playerOneScore + playerOneRoll;
                                playerTwoScore = playerTwoScore + playerTwoRoll; // Creating logic for the score
                                if (playerOneRoll != 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Computer rolled..." + playerTwoRoll);        // rolling the die
                                }
                                if (playerOneRoll == 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Player One Score is: " + playerOneScore);
                                    Console.WriteLine("Computer Score is: " + playerTwoScore);
                                    Statistics.PlayerOneWins++;
                                    if (playerOneScore > playerTwoScore)
                                    {
                                        Winner = 1;
                                    }
                                    if(playerTwoScore > playerOneScore)
                                    {
                                        Winner = 2;                                             // checking for winners if either player rolls 7 using if statments
                                    }
                                    
                                }
                                if (playerOneRoll != 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Computer rolled..." + playerTwoRoll);
                                    Console.WriteLine("Player One Score is: " + playerOneScore);
                                    Console.WriteLine("Computer Score is: " + playerTwoScore);
                                    Statistics.ComputerWins++;
                                    if (playerOneScore > playerTwoScore)
                                    {
                                        Winner = 1;
                                    }
                                    if (playerTwoScore > playerOneScore)
                                    {
                                        Winner = 2;
                                    }
                                    
                                }
                                if (playerOneRoll == 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Computer rolled..." + playerTwoRoll);
                                    Statistics.Draws++;
                                    Winner = 3;
                                }

                            }
                            if (Winner == 1)                                            // Using an integer value to determine the winner and if statements to display the correct messages. 
                            {
                                Winner = 0;
                                Console.WriteLine("Player One Wins!");
                                Console.WriteLine("Keep playing? [Y/N]");
                                string keepPlaying = Console.ReadLine();
                                if (keepPlaying == "Y")
                                {
                                    Console.WriteLine("Restarting. Enjoy!");
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
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
                                    Console.WriteLine("Restarting. Enjoy!");        // Gives the player the option to keep playing or return to menu
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
                                    Winner = 0;
                                    startGame = "Y";
                                }
                                if (keepPlaying != "Y")
                                {
                                    Console.WriteLine("See you next time!");
                                    Winner = 0;
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
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
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
                    if (CoopChoice == "2")
                    {
                        Console.WriteLine("Loading...");
                        Statistics.TimesPlayed++;
                        int Winner = 0;
                        int playerOneScore = 0;
                        int playerTwoScore = 0;
                        Console.WriteLine("Loading complete!");
                        Console.WriteLine("Start game? [Y/N]");
                        string startGame = Console.ReadLine();
                        while (startGame == "Y")
                        {
                            while (Winner == 0)
                            {
                                int playerOneRoll = 0;
                                int playerTwoRoll = 0;
                                Console.WriteLine("Player One, press R to roll!");
                                string playerOneInput = Console.ReadLine();
                                if (playerOneInput == "R")                                  // Uses strings and if statements to add player interaction in the 2 player mode, otherwise, the gamemodes are identical.
                                {
                                    playerOneRoll = SevensOutPlayerOne.SevensPlayerOne();
                                    playerOneScore = playerOneScore + playerOneRoll;
                                }
                                if (playerOneInput != "R")
                                {
                                    Console.WriteLine("Wrong input!");
                                    Winner = 0;
                                }
                                Console.WriteLine("Player Two, press R to roll!");
                                string playerTwoInput = Console.ReadLine();
                                if (playerTwoInput == "R")
                                {
                                    playerTwoRoll = SevensOutPlayerTwo.SevensPlayerTwo();
                                    playerTwoScore = playerTwoScore + playerTwoRoll;
                                }
                                if (playerTwoInput != "R")
                                {
                                    Console.WriteLine("Wrong input!");
                                    Winner = 0;
                                }

                                if (playerOneRoll != 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Player Two rolled..." + playerTwoRoll);
                                }
                                if (playerOneRoll == 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Player One Score is: " + playerOneScore);
                                    Console.WriteLine("Player Two Score is: " + playerTwoScore);
                                    if (playerOneScore > playerTwoScore)
                                    {
                                        Statistics.PlayerOneWins++; Winner = 1;
                                    }
                                    if (playerTwoScore > playerOneScore)
                                    {
                                        Statistics.PlayerTwoWins++; Winner = 2;
                                    }
                                }
                                if (playerOneRoll != 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Player Two rolled..." + playerTwoRoll);
                                    Console.WriteLine("Player One Score is: " + playerOneScore);
                                    Console.WriteLine("Player Two Score is: " + playerTwoScore);
                                    if (playerOneScore > playerTwoScore)
                                    {
                                        Statistics.PlayerOneWins++; Winner = 1;
                                    }
                                    if (playerTwoScore > playerOneScore)
                                    {
                                        Statistics.PlayerTwoWins++; Winner = 2;
                                    }
                                }
                                if (playerOneRoll == 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Player Two rolled..." + playerTwoRoll);
                                    Statistics.Draws++;
                                    Winner = 3;
                                }

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
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
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
                                Console.WriteLine("Player Two Wins!");
                                Console.WriteLine("Keep playing? [Y/N]");
                                string keepPlaying = Console.ReadLine();
                                if (keepPlaying == "Y")
                                {
                                    Console.WriteLine("Restarting. Enjoy!");
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
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
                                    playerOneScore = 0;
                                    playerTwoScore = 0;
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
                if(PlayerResponse == "3")
                {
                    int GameTimesPlayed = Statistics.TimesPlayed;
                    int GamePlayerOneWins = Statistics.PlayerOneWins;
                    int GameComputerWins = Statistics.ComputerWins;
                    int GamePlayerTwoWins = Statistics.PlayerTwoWins;
                    int GameDraws = Statistics.Draws;                   // Uses the statistics values in integer variables to be displayed
                    Console.WriteLine("\n Times played: " + GameTimesPlayed);
                    Console.WriteLine("\n Player One wins: " + GamePlayerOneWins);
                    Console.WriteLine("\n Player Two wins: " + GamePlayerTwoWins);
                    Console.WriteLine("\n Computer wins: " + GameComputerWins);
                    Console.WriteLine("\n Draws: " + GameDraws);                    // Displays statistics
                    Console.WriteLine("\n Return to menu? [Y/N]");
                    string returnToMenu = Console.ReadLine();
                    if (returnToMenu == "Y")
                    {
                        gameOn = 1;
                    }
                    if (returnToMenu != "Y")
                    {
                        break;
                    }
                }
                if(PlayerResponse == "4") 
                {
                    Testing tester = new Testing();
                    Testing.Test();
                    Console.WriteLine("Return to menu? [Y/N]");
                    string returnMenu = Console.ReadLine();
                    if (returnMenu == "Y")
                    {
                        gameOn = 1;
                    }
                    if (returnMenu!= "Y")
                    {
                        break;
                    }                                               // Testing class

                }
                if(PlayerResponse == "5")
                {
                    break;                      // for quitting graciously
                }
            }
        }
    }
}
            

