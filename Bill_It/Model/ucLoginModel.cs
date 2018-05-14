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
    class ucLoginModel
    {
        MySqlCommand Command;
        DatabaseConnector databaseConnector = new DatabaseConnector();

        public class ModelLoginBelepes
        {
            public string UserName { get; set; }
            public string PassWord { get; set; }
            public int Delete { get; set; }
            public DateTime Reg_Date { get; set; }

        }

        public List<ModelLoginBelepes> ModelBelepes_List(string Query)
        {

            List<ModelLoginBelepes> ElementModel = new List<ModelLoginBelepes>();
            Command = new MySqlCommand(Query, databaseConnector.myConnection);
            Command.CommandText = Query;

            databaseConnector.OpenConnection();

            using (MySqlDataReader rdr = Command.ExecuteReader())

            {
                int i = 0;
                while (rdr.Read())
                {
                    ElementModel.Add(new ModelLoginBelepes
                    {
                        UserName = rdr["username"].ToString(),
                        PassWord = rdr["password"].ToString(),
                        Delete = Convert.ToInt32(rdr["del"]),
                        Reg_Date = Convert.ToDateTime(rdr["reg_date"])
                    });

                    i++;
                }
            }


            return ElementModel;

        }
    }
}
