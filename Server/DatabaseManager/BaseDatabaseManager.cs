using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Server.DatabaseManager
{
    public class BaseDatabaseManager
    {
        protected BaseDatabaseManager() { }

        public static MySqlConnection connection
        {
            get
            {
                MySqlConnection connection = new MySqlConnection();
                string connctionString = "SERVER=192.168.0.136;"+"DATABASE=webshop;"+"UID=root;"+"PASSWORD=password;"+ "SSL MODE=Required;";
                connection.ConnectionString = connctionString;
                return connection;
            }
        }
    }
}