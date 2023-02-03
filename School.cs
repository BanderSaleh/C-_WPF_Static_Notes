using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Prog_124_W23_Lecture_8_Static
{
    // Created a class called School
    class School
    {
        // Static Field
        static string _name = "Renton Technical College"; // string defined
        static string _address = "3000 NE 4th St"; // string defined
        static string _city = "Renton"; // string defined
        static string _state = "WA"; // string defined
        static string _zipcode = "98056"; // string defined


        // Static Constructor is automatically called
        // * a static constructor cannot be made public
        // * it is automatically private

        // * static constructors CAN'T TAKE PARAMETERS

        // * the Static Constructor is AUTOMATICALLY CALLED when any member from a class with the static constructor is accessed
        static School()
        {

            // This code toggles a popup message for the user to see data stored within this Static Method
            MessageBox.Show($"The static constructor in the School Class just ran");

        }


        // Static Properties
        public static string school_name
        {
            // get the value inputed in the textbox by the User
            get => _name;
            // set the string _name value for School class with the updated text inputed
            set => _name = value;
        }


        // Static Method that formats the the information to return a string of School
        public static string SchoolInformation()
        {
            // Return the current instance of the School object in a specified format
            // to be displayed in the RichTextBox
            return $"" + 
                $"School Name - {School._name}\n" +
                $"Address - {School._address}\n" +
                $"City - {School._city}\n" +
                $"State - {School._state}\n" +
                $"Zipcode - {School._zipcode}\n";
        }
    }
}
