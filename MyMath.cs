using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_8_Static
{
    // Creating our own Math Class


    public static class MyMath
    {

        public static double PI = Math.PI;

        public static double Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static double Subtract(int number1, int number2)
        {
            return number1 - number2;
        }


        public static double Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Divide(int number1, int number2)
        {
            return number2 / number1;
        }

    }
}
