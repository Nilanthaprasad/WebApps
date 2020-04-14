using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.DataConn;
using MySql.Data.MySqlClient;
using MySql.Data.Common;


namespace RanAswanuPOS.EntityDao
{

    class UserDao
    {
        private MySqlConnection dbCon;
        
        
        public UserDao()
        {
            dbCon = DatabaseConnection.getConnection();
        }

        private List<string>[] checkCredentials()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            dbCon.Open();

            
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, dbCon);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["password"] + "");
                }

                //close Data Reader
                dataReader.Close();

            //close Connection
            dbCon.Close();

                //return list to be displayed
                return list;
            
   
            
        }
    }
}
