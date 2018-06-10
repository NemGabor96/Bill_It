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
        DatabaseConnector databaseConnector = new DatabaseConnector();
        MySqlCommand Command;
         
        public static void InputRegularExpressionNumbers(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public bool RegistrationButtonClick(string UserName, string PassWord, string PassWordAgain, string LastName, string FirstName, string City, string ZipCode, string Address, string Member, CheckBox CheckBox)
        {
            string Query = "SELECT username FROM Users WHERE username='" + UserName + "';";

            if(0 != wndRegistrationModel.ModelRegistration_List(Query).Count)
            {
                return false;   
                
            }
            else
            {
               

                if (PassWord == PassWordAgain && CheckBox.IsChecked == true)
                {
                   
                    Query = "INSERT INTO Users (username,password,fname,lname,city,zipcode,address,member,role,reg_date,del) VALUES('"+UserName+"','"+PassWord+"','"+FirstName+"','"+LastName+"','"+City+"','"+ZipCode+"','"+Address+"','"+Member+"','1','"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"','1');";
                    Command = new MySqlCommand(Query, databaseConnector.myConnection);
                    databaseConnector.OpenConnection();
                    Command.CommandText = Query;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres regisztráció!");

                    return true;
                    
                }
                else
                {
                    return false;
                    
                }
            }
        }
    }
}
