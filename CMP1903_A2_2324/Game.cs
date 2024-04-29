using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    public class Game
    {
        public void Main()
        {
            Console.WriteLine("Welcome to the Sebastian's cool games!");
            Console.WriteLine("Please choose one of the following: ");
            Console.WriteLine(" SevensOut [1] ; ThreeOrMore [2] (COMING SOON!); Statistics [3]; Testing [4] ; Exit [5]");
            string PlayerResponse = Console.ReadLine();
            if (PlayerResponse == "1")
            {
                Console.WriteLine("Play with friend [1], or against computer? [2]: ");
                string CoopChoice = Console.ReadLine();
                if (CoopChoice == "1")
                {
                    Console.WriteLine("Loading...");
                    SevensOutPlayerOne sevensOne = new SevensOutPlayerOne();
                    SevensOutPlayerTwo sevensTwo = new SevensOutPlayerTwo();
                    int TotalScorePlayerOne = 0;
                    int TotalScorePlayerTwo = 0;
                    int Winner = 0;
                    Console.WriteLine("Loading complete!");
                    while (true)
                    {
                        Console.WriteLine("Press R to roll!");
                        try
                        {
                            string playerOneInput = Console.ReadLine();
                            if (playerOneInput == "R")
                            {
                                while (Winner == 0 && TotalScorePlayerOne < 7 && TotalScorePlayerTwo < 7)
                                {
                                    int playerOneRoll = sevensOne.SevensPlayerOne();
                                    int playerTwoRoll = sevensTwo.SevensPlayerTwo();
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
    }
}