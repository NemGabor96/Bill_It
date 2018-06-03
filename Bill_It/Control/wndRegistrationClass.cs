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
using MySql.Data.MySqlClient;
using Bill_It.View;
using Bill_It.Control;
using Bill_It.Model;
using System.Text.RegularExpressions;

namespace Bill_It.Control
{
    class wndRegistrationClass
    {
        wndRegistration wndRegistration = new wndRegistration();
         
        public static void InputRegularExpressionNumbers(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void RegistrationButtonClick(string UserName, string PassWord, string PassWordAgain, string LastName, string FirstName, string City, string ZipCode, string Address, string Member, CheckBox CheckBox)
        {
            string Query = "SELECT username FROM Users WHERE username='" + UserName + "';";

            if(null != wndRegistrationModel.ModelRegistration_List(Query))
            {
                
                wndRegistration.lbHibaUezenet.Content = "A felhasználó már létezik próbálkozzon mással";
                wndRegistration.lbHibaUezenet.Visibility = Visibility.Visible;
                wndRegistration.tbFelhasznalonev.BorderBrush = Brushes.Red;
            }
            else
            {
                wndRegistration.tbFelhasznalonev.BorderBrush = Brushes.Black;

                if (PassWord == PassWordAgain)
                {
                    MessageBox.Show("Sikeres regisztráció!");

                    wndRegistration.pbJelszo.BorderBrush = Brushes.Black;
                    wndRegistration.pbJelszoMegerosites.BorderBrush = Brushes.Black;
                    wndRegistration.lbHibaUezenet.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    wndRegistration.lbHibaUezenet.Content = "A két jelszó nem egyezik";
                    wndRegistration.lbHibaUezenet.Visibility = Visibility.Visible;
                    wndRegistration.pbJelszo.BorderBrush = Brushes.Red;
                    wndRegistration.pbJelszoMegerosites.BorderBrush = Brushes.Red;
                }
            }
        }
    }
}
