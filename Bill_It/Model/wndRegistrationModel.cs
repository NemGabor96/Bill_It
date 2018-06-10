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
namespace Bill_It.Model
{
    class wndRegistrationModel
    {
        static MySqlCommand Command;
        static DatabaseConnector databaseConnector = new DatabaseConnector();

        public class RegUserModel
        {
            public string UserName;
          
        }

        public static List<RegUserModel> ModelRegistration_List(string Query)
        {

            List<RegUserModel> ElementModel = new List<RegUserModel>();
            Command = new MySqlCommand(Query, databaseConnector.myConnection);
            Command.CommandText = Query;
            databaseConnector.OpenConnection();
            Command.ExecuteNonQuery();
            

            using (MySqlDataReader rdr = Command.ExecuteReader())

            {
                int i = 0;
                while (rdr.Read())
                {
                    ElementModel.Add(new RegUserModel
                    {
                        UserName = rdr["username"].ToString()
                    });

                    i++;
                }
            }


            return ElementModel;

        }

    }
}
