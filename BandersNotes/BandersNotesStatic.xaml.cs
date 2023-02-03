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

namespace Prog_124_W23_Lecture_8_Static.BandersNotes
{
    /// <summary>
    /// Interaction logic for BandersNotesStatic.xaml
    /// </summary>
    public partial class BandersNotesStatic : Page
    {
        public BandersNotesStatic()
        {
            InitializeComponent();
        }
    }
}


/*

Questions: 


Static

The keyword Static means a class member is associated with the class ____, not the instance.
Answer: Type

How do you access a static member?
Answer: Static members can be accessed by using the type Name, followed by dot, and the member you trying to access.
Ex.
StaticClass.name = "Will";
MessageBox.Show(StaticClass.name);


Static Fields

Can you have a static field that takes an instanced object?
Answer: You cannot access an instance variable of any object unless it's explicitly passed in a method parameter.


Static Constructor

When does the static constructor get called?
Answer: A static constructor is automatically private. It is initialized once. Just before the instane constructor is called, or just after the first time a static member is called.

What access modifier MUST a static constructor have?
Answer: You can't include an access modifier when defining a static constructor.
Static constructors are defined without access modifiers.

How many times can you call a static constructor?
Answer: A class or struct can only have one static constructor at most.

How many parameters can you pass into a static constructor?
Answer: A static constructor doesn't take access modifiers or have parameters.


Static Methods

Can a static method use instanced fields?
Answer: No


Static class

All members of a static class must be _____?
Answer: static

Can you inherit from a static class?
Answer: No, because static Classes are sealed.

Extension Method

  
*/