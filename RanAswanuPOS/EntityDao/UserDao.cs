using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.DataConn;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using RanAswanuPOS.Entity;


namespace RanAswanuPOS.EntityDao
{

    class UserDao
    {
        private MySqlConnection dbCon = DatabaseConnection.getConnection();
        
        
        public UserDao()
        {
           
        }

        public List<string>[] getUser(User user)
        {
            
            String[] arguementsForSelect = { DataDictionary.USER_TABLE_COL_USERNAME, DataDictionary.USER_TABLE_COL_PASSWORD };
            String query = DatabaseUtil.getSelectAllwithANDStatement(DataDictionary.USER_TABLE, arguementsForSelect);

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            cmd.Parameters.AddWithValue(DataDictionary.USER_TABLE_COL_USERNAME_PARAM, user.Username);
            cmd.Parameters.AddWithValue(DataDictionary.USER_TABLE_COL_PASSWORD_PARAM, user.Password);
            cmd.Prepare();
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"].ToString());
                list[1].Add(dataReader["username"].ToString());
                list[2].Add(dataReader["password"].ToString());
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            //dbCon.Close();

                //return list to be displayed
            return list;  
            
        }
    }
}
