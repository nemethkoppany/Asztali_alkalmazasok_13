using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NetflixMovies
{
    public static class DatabaseController
    {
     public static MySqlConnection CreateConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.CharacterSet = "utf8";
            builder.Server = "localhost";
            builder.Database = "netflix";
            builder.Password = "";
            builder.UserID = "root";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            conn.Open();
            return conn;
        }

        public static void CloseConnection(MySqlConnection conn)
        {
            conn.Close();
        }
    }
}
