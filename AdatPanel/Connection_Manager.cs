using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdatPanel
{
    public class Connection_Manager
    {
        public Connection_Manager() { }

        public static MySqlConnection connection
        {
            get
            {
                MySqlConnection connection = new MySqlConnection();
                string connctionString = "SERVER=192.168.0.136;" + "DATABASE=webshop;" + "UID=root;" + "PASSWORD=password;" + "SSL MODE=Required;";
                connection.ConnectionString = connctionString;
                return connection;
            }
        }

    }

    
}
