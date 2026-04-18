using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms.Ecc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceges_autokGUI
{
    internal class DatabaseController
    {
        public static MySqlConnection CreateConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.CharacterSet = "utf8";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "parkolohaz";

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
