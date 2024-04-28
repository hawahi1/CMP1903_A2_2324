using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324
{
    internal class SevensOut
    {
       public static void Sevens()
        {
            Die die = new Die();
            int valueOne = die.DieRoll();
            int valueTwo = die.DieRoll();
            int totalValue = valueOne + valueTwo;
            if (valueOne == valueTwo) { totalValue = (valueOne + valueTwo)*2; };
        }
    }
}