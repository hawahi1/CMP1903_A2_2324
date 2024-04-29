using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    internal class ThreePlayerOne // creating class for player one, i plan on doing all of the looping within the game class
    {
        public void ThreePlayerOneMain()
        {
            Die die = new Die();
            List<int> list = new List<int>();
            int valueOne = die.DieRoll();
            int valueTwo = die.DieRoll();
            int valueThree = die.DieRoll();
            int valueFour = die.DieRoll();
            int valueFive = die.DieRoll();
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);
            foreach (int i in list)
            {
                if i == valueOne && i == valueTwo && i == valueThree{
                    Console.WriteLine("You have rolled 3 of the same! Roll all the die again or roll the remaining die again?")
                }
            }
        }


    }
    internal class ThreePlayerTwo // creating class for player two.
    {

    }
}