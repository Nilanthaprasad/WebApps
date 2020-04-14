using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace RanAswanuPOS.DataConn
{

    class DatabaseConnection
    {
        private MySqlConnection connection;
        private static String server = "localhost";
        private static String database = "connectcsharptomysql";
        private static String uid = "root";
        private static String password = "";
        
      

        

        public DatabaseConnection()
        {
           
        }

        public static MySqlConnection getConnection()
        {
            String connectionString;
            MySqlConnection connection;
            try
            {
               connectionString = "SERVER=" +
                                    server + ";" +
                                    "DATABASE=" + database + ";" +
                                    "UID=" + uid + ";" +
                                    "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
