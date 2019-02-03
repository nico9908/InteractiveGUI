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

namespace InteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Controller cont = Controller.GetInstance();

        private void Btn_NewPerson(object sender, RoutedEventArgs e)
        {
            cont.AddPerson();
     //     AgeTextBox.Text = "0";
            FirstNameTextBox.IsEnabled = true;
            LastNameTextBox.IsEnabled = true;
            AgeTextBox.IsEnabled = true;
            TelephoneNoTextBox.IsEnabled = true;
            Up.IsEnabled = true;
            Down.IsEnabled = true;
            Delete_Person.IsEnabled = true;

     //     FirstNameTextBox.Text = null;
     //     LastNameTextBox.Text = null;
     //     AgeTextBox.Text = null;
     //     TelephoneNoTextBox = null;

            Person_Count.Text = "Person Count: " + cont.PersonCount;
            Index.Text = "Index: " + cont.PersonIndex;
     //     FirstNameTextBox.Text = cont.CurrentPerson.FirstName;
     //     LastNameTextBox.Text = cont.CurrentPerson.LastName;
     //     AgeTextBox.Text = cont.CurrentPerson.Age.ToString();
     //     TelephoneNoTextBox.Text = cont.CurrentPerson.TelephoneNo;
        }
        private void Btn_DeletePerson(object sender, RoutedEventArgs e)
        {
            cont.DeletePerson();
            cont.PrevPerson();
            Index.Text = "Index: " + cont.PersonIndex;
            Person_Count.Text = "Person Count: " + cont.PersonCount;

        }
        private void Btn_Up(object sender, RoutedEventArgs e)
        {
            if (cont.PersonIndex == cont.PersonCount - 1)
            {
                Up.IsEnabled = false;
            }
            else
            {
                cont.NextPerson();

                ResetText();
            }
            //      cont.NextPerson();
            //      ResetText();
            Index.Text = "Index: " + cont.PersonIndex;
        }
        private void Btn_Down(object sender, RoutedEventArgs e)
        {
            if (cont.PersonIndex == 0)
            {
                Down.IsEnabled = false;
            }
            else
            {
                cont.PrevPerson();

                ResetText();
            }
            //     cont.PrevPerson();
            //     ResetText();
            Index.Text = "Index: " + cont.PersonIndex;
        }
        private void ResetText()
        {
            FirstNameTextBox.Text = cont.CurrentPerson.FirstName;
            LastNameTextBox.Text = cont.CurrentPerson.LastName;
            AgeTextBox.Text = cont.CurrentPerson.Age.ToString();
            TelephoneNoTextBox.Text = cont.CurrentPerson.TelephoneNo;
        }
        private void TextChange_LastName(object sender, TextChangedEventArgs e)
        {
            cont.CurrentPerson.LastName = LastNameTextBox.Text;
        }

        private void TextChange_Firstname(object sender, TextChangedEventArgs e)
        {
            cont.CurrentPerson.FirstName = FirstNameTextBox.Text;
        }

        private void TextChange_Age(object sender, TextChangedEventArgs e)
        {
            cont.CurrentPerson.Age = Convert.ToInt32(AgeTextBox.Text);
        }

        private void TextChange_Tele(object sender, TextChangedEventArgs e)
        {
            cont.CurrentPerson.TelephoneNo = TelephoneNoTextBox.Text;
        }
    }
}
