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
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_8_Static
{
    /// <summary>
    /// Interaction logic for Shelter_Information.xaml
    /// </summary>
    public partial class Shelter_Information : Window
    {
        public Shelter_Information()
        {
            InitializeComponent();
            runDisplay.Text = Shelter.ShelterInformation();
        }

        private void btnOpenWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            string newShelterName = txtShelterName.Text;

            Shelter.ShelterLocation = newShelterName;

            runDisplay.Text = Shelter.ShelterInformation();


        }


    }
}
