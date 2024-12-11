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
        
        
        //private static String server = "localhost";
        //private static String database = "dphjmimy_wp0kg";
        //private static String uid = "root";
        //private static String password = "";       
        public static MySqlConnection dbConnection;

        private static String server = "162.241.225.63";
        private static String database = "dphjmimy_WP0KG";

        //Partial Priviledge user
        private static String uid = "dphjmimy_pos";
        private static String password = "bluelagoon";

        //Full Priviledged user
        //private static String uid = "dphjmimy_posuser";
        //private static String password = "bluelagoon#6";


        public DatabaseConnection()
        {
           
        }

        public static MySqlConnection getConnection()
        {
            String connectionString;
            if (dbConnection == null)
            {
                try
                {
                    connectionString = "SERVER=" +
                                         server + ";" +
                                         "DATABASE=" + database + ";" +
                                         "UID=" + uid + ";" +
                                         "PASSWORD=" + password + ";";
                    dbConnection = new MySqlConnection(connectionString);
                    dbConnection.Open();
                    return dbConnection;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
            }
            else
            {
                return dbConnection;
            }
            
        }

        
    }
}
