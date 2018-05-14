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

namespace Bill_It.Control
{
    class DatabaseConnector
    {
        public MySqlConnection myConnection;
        public string MyConnectingString;


        public DatabaseConnector()
        {
            
                MyConnectingString = "server=s7.nethely.hu; user id=nemethg; password=123456; persistsecurityinfo=True; database=nemethg; SslMode=none;";
            

                myConnection = new MySqlConnection(MyConnectingString);


        }

        public void OpenConnection()
        {


            if (myConnection.State != System.Data.ConnectionState.Open)
            {

                myConnection.Open();
            }



        }

        public void CloseConnection()
        {

            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }



        }

    }
}
