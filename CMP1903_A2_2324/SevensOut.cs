using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    internal class SevensOutPlayerOne // Creating the class for the Sevens out game.
    {
        public static int SevensPlayerOne() // Creating the player one method
        {
            Die die = new Die();
            int valueOnePlayerOne = die.DieRoll();
            int valueTwoPlayerOne = die.DieRoll();
            int totalPlayerOne = valueOnePlayerOne + valueTwoPlayerOne;
            if (valueOnePlayerOne == valueTwoPlayerOne) { totalPlayerOne = (valueOnePlayerOne + valueTwoPlayerOne)*2; };
            return totalPlayerOne;
            
        }

    }
    internal class SevensOutPlayerTwo
    {
        public static int SevensPlayerTwo() // Player two method
        {
            Die die = new Die();
            int valueOnePlayerTwo = die.DieRoll();
            int valueTwoPlayerTwo = die.DieRoll();
            int totalPlayerTwo = valueOnePlayerTwo + valueTwoPlayerTwo;
            if (valueOnePlayerTwo == valueTwoPlayerTwo) { totalPlayerTwo = (valueOnePlayerTwo + valueTwoPlayerTwo) * 2; };
            return totalPlayerTwo;
        }

    }
    internal class SevensGameLoop
    {
        SevensOutPlayerOne SevensOne = new SevensOutPlayerOne();
        SevensOutPlayerTwo SevensTwo = new SevensOutPlayerTwo();
        public static void GameLoop(SevensOutPlayerTwo, SevensOutPlayerOne)
        {

        }
    }
}