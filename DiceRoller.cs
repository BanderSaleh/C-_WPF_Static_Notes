using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_W23_Lecture_8_Static
{
    static class DiceRoller
    {
        // D4, D6, D8, D10, D12, D20, D100
        // Random rand = new Random();
        // rand.Next(1, 7); 1 - 6
        public static int RollDie(int maxValue)
        {
            Random rand = new Random();
            int actualNumber = maxValue + 1;
            int diceRoll = rand.Next(1, actualNumber);
            return diceRoll;
        }

        // Extension Method
        // Extension methods are used to add functionality to classes that have already been built

        // Add this. in front of the first paremeter
        public static int RollThisDie(this int maxValue)
        {
       
            Random rand = new Random();
            int actualNumber = maxValue + 1;
            int diceRoll = rand.Next(1, actualNumber);
            return diceRoll;
        }


        // Exension method that returns a parsed int
        public static int ParseInt(this string value)
        {
            return int.Parse(value);
        }

        
    }
}
