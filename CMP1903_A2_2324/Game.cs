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
            while (gameOn > 0)
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
                        Console.WriteLine("Loading complete!");
                        Console.WriteLine("Start game? [Y/N]");
                        string startGame = Console.ReadLine();
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
                                }
                                if (playerOneRoll == 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Statistics.PlayerOneWins++;
                                    Winner = 1;
                                }
                                if (playerOneRoll != 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Computer rolled..." + playerTwoRoll);
                                    Statistics.ComputerWins++;
                                    Winner = 2;
                                }
                                if (playerOneRoll == 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Computer rolled..." + playerTwoRoll);
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
                                if (playerOneInput == "R")
                                {
                                    playerOneRoll = SevensOutPlayerOne.SevensPlayerOne();
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
                                }

                                if (playerOneRoll != 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Console.WriteLine("Player Two rolled..." + playerTwoRoll);
                                }
                                if (playerOneRoll == 7 && playerTwoRoll != 7)
                                {
                                    Console.WriteLine("Player One rolled..." + playerOneRoll);
                                    Statistics.PlayerOneWins++;
                                    Winner = 1;
                                }
                                if (playerOneRoll != 7 && playerTwoRoll == 7)
                                {
                                    Console.WriteLine("Player Two rolled..." + playerTwoRoll);
                                    Statistics.ComputerWins++;
                                    Winner = 2;
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
                    int GameDraws = Statistics.Draws;
                    Console.WriteLine("\n Times played: " + GameTimesPlayed);
                    Console.WriteLine("\n Player One wins: " + GamePlayerOneWins);
                    Console.WriteLine("\n Player Two wins: " + GamePlayerTwoWins);
                    Console.WriteLine("\n Computer wins: " + GameComputerWins);
                    Console.WriteLine("\n Draws: " + GameDraws);
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
                    }

                }
                if(PlayerResponse == "5")
                {
                    break;
                }
            }
        }
    }
}
            

