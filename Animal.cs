using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_8_Static
{
    // * Error: It cannot derive from static class 'shelter'
    // This is beacause a STATIC class, is SEALED
    public class Animal
    {
        // Static

        // Fields
        string _name;
        string _shelterLocation;

        // Add a static field
        public static string Type = "Cat";
        public static int NumberOfAnimal = 0;

        // * The static fields, are shared between ALL instance objects

        // Constructor
        public Animal(string name, string shelterLocation)
        {
            _name = name;
            _shelterLocation = shelterLocation;
            NumberOfAnimal++; // Increments the number of animal by 1
        }

        // Properties
        public string Name { get => _name; set => _name = value; }
        public string ShelterLocation { get => _shelterLocation; set => _shelterLocation = value; }






        // Method

    }
}
