using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateGUI
{
    public static class DatabaseController
    {
        public static MySqlConnection CreatConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.CharacterSet = "utf8";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "ingatlan";

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
