using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    public class SevensOutPlayerOne // Creating the class for the Sevens out game.
    {
        public static int SevensPlayerOne() // Creating the player one method
        {
            Die die = new Die();
            int valueOnePlayerOne = die.DieRoll();
            int valueTwoPlayerOne = die.DieRoll(); // rolls the die to create the values
            int totalPlayerOne = valueOnePlayerOne + valueTwoPlayerOne; // creates the total roll value
            if (valueOnePlayerOne == valueTwoPlayerOne) { totalPlayerOne = (valueOnePlayerOne + valueTwoPlayerOne)*2; }; // checks for doubles and implements the x2 rule
            return totalPlayerOne; // returns to integer
            
        }

    }
    public class SevensOutPlayerTwo
    {
        public static int SevensPlayerTwo() // Player two method
        {
            Die die = new Die();
            int valueOnePlayerTwo = die.DieRoll();
            int valueTwoPlayerTwo = die.DieRoll();
            int totalPlayerTwo = valueOnePlayerTwo + valueTwoPlayerTwo;
            if (valueOnePlayerTwo == valueTwoPlayerTwo) { totalPlayerTwo = (valueOnePlayerTwo + valueTwoPlayerTwo) * 2; };
            return totalPlayerTwo; // same code as other class but tweaked
        }

    }
}