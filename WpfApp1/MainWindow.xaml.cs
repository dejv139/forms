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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Validator validator = new Validator();


        public MainWindow()
        {
            InitializeComponent();

        }

        Person clovek = new Person();
        
        


        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person clovek = new Person
            {
                Name = Jmeno.Text,
                Surname = Prijmeni.Text,
                Email = Email.Text
            };

            if (!ValidationExtension.Validate(validator, clovek, "Surname").IsValid)
            {
                Prijmeni.Background = Brushes.Red;
            }
            if (!ValidationExtension.Validate(validator, clovek, "Name").IsValid)
            {
                Jmeno.Background = Brushes.Red;
            }

            if (ValidationExtension.Validate(validator, clovek, "Email").IsValid)
            {
                Email.Background = Brushes.White;
            }
            if (ValidationExtension.Validate(validator, clovek, "Surname").IsValid)
            {
                Prijmeni.Background = Brushes.White;
            }
            if (ValidationExtension.Validate(validator, clovek, "Name").IsValid)
            {
                Jmeno.Background = Brushes.White;
            }

        }*/

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            clovek.AddEmail(Email.Text);

            if (!ValidationExtension.Validate(validator, clovek, "Email").IsValid)
            {
                Email.Background = Brushes.Red;
            }
            else
            {
                Email.Background = Brushes.White;
            }
        }

        private void Prijmeni_TextChanged(object sender, TextChangedEventArgs e)
        {
            clovek.AddName(Jmeno.Text);
            clovek.AddSurname(Prijmeni.Text);

            if (!ValidationExtension.Validate(validator, clovek, "Surname").IsValid)
            {
                Prijmeni.Background = Brushes.Red;
            }
            else
            {
                Prijmeni.Background = Brushes.White;
            }
        }

        private void Jmeno_TextChanged(object sender, TextChangedEventArgs e)
        {
            clovek.AddName(Jmeno.Text);

            if (!ValidationExtension.Validate(validator, clovek, "Name").IsValid)
            {
                Jmeno.Background = Brushes.Red;
            }
            else
            {
                Jmeno.Background = Brushes.White;
            }
        }
    }
}
