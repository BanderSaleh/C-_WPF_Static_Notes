using Prog_124_W23_Lecture_8_Static.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_8_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define a new Instance of School Class to run
            School sc = new School();


            // get and set the Text formatted variable runDisplay using the current ShelterInformation object active 
            // runDisplay.Text = Shelter.ShelterInformation();

            // How to Add a new window to our project
            // Right click like you are adding a class
            // Selected Window ( WPF )

        }



        public void Example()
        {

            // Instance

            Animal animal = new Animal("Mochi", Shelter.ShelterLocation);

            MessageBox.Show(animal.ShelterLocation);

            // How do you access a static member?
            // You use the dot operator on the TYPE, not the instance object
            //MessageBox.Show(Animal.Type);

            // static keyword

        }

        private void btnOpenWindow_Click(object sender, RoutedEventArgs e)
        {
            // To open another window in your project
            // You need to create a NEW instance of the window.
            // to create a new instance, use the NEW keyword


            Shelter_Information shelter_Information = new Shelter_Information();

            // To show our new window, you need to use the .Show() method on our window instance
            shelter_Information.Show();

        } // btnOpenWindow_Click()

        private void btnRefreshInformation_Click(object sender, RoutedEventArgs e)
        {
            // * Changing information in a static field changes it for the entire project
            runDisplay.Text = Shelter.ShelterInformation();


        }

        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            string shelterName = txtShelterName.Text;
            
            Shelter.ShelterLocation = shelterName;
        }

        private void btnCreateNewShelter_Click(object sender, RoutedEventArgs e)
        {
            //Shelter shelter = new Shelter();
           // Animal animal = new Animal("Mochi", Shelter.ShelterLocation);
            MessageBox.Show(Shelter.NumberOfShelters.ToString()) ;
        }

        private void btnDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            string usersNumber = txtNumber.Text;
            // Chain my extension methods
            //int diceRoll = usersNumber.ParseInt().RollThisDie();

            // int parse = int.Parse(usersNumber);
            // int diceroll = RollDie(parse);
            // MessageBox(diceRoll);

            MessageBox.Show(usersNumber.ParseInt().RollThisDie().ToString());
            // int diceRoll = RollDie(6)
            // int diceRoll = 6.RollTheDie();
        }

        // When the button for changing School Name gets clicked
        private void btnSchool_Click(object sender, RoutedEventArgs e)
        {
            // get the user inputed data from the textbox associated with changing the School Name
            // set the newly defined string schoolName with the user inputed data
            string schoolName = txtSchoolName.Text;
            // Assign the user inputed data from txtSchoolName.Text to the Static Field _name string variable
            School.school_name = schoolName;
            // Update the School class's _name data and display the updated instance of the School object to the RichTextBox
            // * Changing information in a static field changes it for the entire project
            runDisplay.Text = School.SchoolInformation();
            // Run a MessageBox popup that displays a message saying that the current School Name instance got the _name variable updated to the following data
            MessageBox.Show($"The School Name got changed to: " + schoolName);
        }

        // Button that returns School object data in the RichTextBox
        private void btnRefreshInformation2_Click(object sender, RoutedEventArgs e)
        {
            // Display the default hard coded School data to the RichTextBox
            runDisplay.Text = School.SchoolInformation();
        }
    }
}
