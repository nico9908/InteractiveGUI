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
        }
        private void Btn_DeletePerson(object sender, RoutedEventArgs e)
        {
            cont.DeletePerson();
        }
        private void Btn_Up(object sender, RoutedEventArgs e)
        {
            cont.NextPerson();
        }
        private void Btn_Down(object sender, RoutedEventArgs e)
        {
            cont.PrevPerson();
        }
    }
}
