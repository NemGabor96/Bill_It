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

        }

        public static void btBelepes_Click(string username, string password)
        {
            ucLoginModel ucLoginModel = new ucLoginModel();
            string Query = "SELECT username, password, del, reg_date FROM Users WHERE username='"+username+"' AND password='"+password+"' AND del = 1";
           
            if( 0 != ucLoginModel.ModelBelepes_List(Query).Count())
            {
                MessageBox.Show("Sikeresen Bejelentkezett!", "Értesítés");
            }
            else
            {
                MessageBox.Show("Nem Sikerült Bejelentkezett!", "Értesítés");
            }
        }

        
    }
}
