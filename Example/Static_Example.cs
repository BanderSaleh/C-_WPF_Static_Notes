using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_W23_Lecture_8_Static.Example
{
    public static class Static_Example
    {
        // static fields
        static string name = "Will";

        // static constructor
        static Static_Example()
        {
            MessageBox.Show("This just ran");
        } // Static_Example()

        // static property
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // static method
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        } // Add

    } // public
}
