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

namespace Bill_It.Control
{
    class ucLoginClass
    {
        MySqlCommand Command;
        DatabaseConnector databaseConnector = new DatabaseConnector();

        public static void btEsc_Click()
        {
            Application.Current.Shutdown();
        }

        public static void btTalca_Click()
        {
            wndMain wndMain = new wndMain();
            wndMain.Minimizer();
        }

        public static void btRegisztracio_Click()
        {
            wndRegistration registration = new wndRegistration();
            registration.Show();
        }

        public static void btBelepes_Click(TextBox tbFelhasznalo, PasswordBox pwJelszo, Label lbFelhasznalo, Label lbJelszo, Label lbHibaFelJel)
        {
            ucLoginModel ucLoginModel = new ucLoginModel();
            string Query = "SELECT username, password, del, reg_date FROM Users WHERE username='"+tbFelhasznalo.Text+"' AND password='"+pwJelszo.Password+"' AND del = 1";
           
            if( 0 != ucLoginModel.ModelBelepes_List(Query).Count())
            {
                tbFelhasznalo.BorderBrush = Brushes.Green;
                pwJelszo.BorderBrush = Brushes.Green;
                lbFelhasznalo.Foreground = Brushes.Green;
                lbJelszo.Foreground = Brushes.Green;
                lbHibaFelJel.Visibility = Visibility.Hidden;
                

               
            }
            else
            {
                tbFelhasznalo.BorderBrush = Brushes.Red;
                pwJelszo.BorderBrush = Brushes.Red;
                lbFelhasznalo.Foreground = Brushes.Red;
                lbJelszo.Foreground = Brushes.Red;
                lbHibaFelJel.Visibility = Visibility.Visible;
            }
        }

        
    }
}
