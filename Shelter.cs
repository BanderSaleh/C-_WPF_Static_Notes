using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Prog_124_W23_Lecture_8_Static
{
    // Static class

    public static class Shelter
    {
        // Static Field
        public static string ShelterLocation = "Kent Pet Shelter";
        public static string Address = "1234 Kent Way";
        public static string City = "Kent";
        static string _state = "Wa";
        public static int NumberOfShelters = 0;

        public static DateTime _programRuns;


        // static constructor
        // * a static constructor cannot be made public
        // * it is automatically private

        // * static constructors CAN'T TAKE PARAMETERS

        // * the Static Constructor is AUTOMATICALLY CALLED when any member from a class with the static constructor is accessed
        static Shelter()
        {
            _programRuns = DateTime.Now;
            MessageBox.Show($"The static constructor just ran at {_programRuns}");
            
        }

        // Static Properties
        public static string State
        {
            get => _state;
            set => _state = value;
        }

        // Static Method
        public static string ShelterInformation()
        {
                    return $"" +
                         $"Shelter Name - {Shelter.ShelterLocation}\n" +
                         $"Shelter Address - {Shelter.Address}\n" +
                         $"Shelter City - {Shelter.City}\n" +
                         $"Shelter State - {Shelter.State}\n" +
                         $"Date First Accesed - {_programRuns.ToShortTimeString()}";
        }

        // * A instanced field shouldn't be called inside of a static method
        public static void DisplayAnimals(List<Animal> list)
        {
           
        }
    }
}
