using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PerpustakaanTgs.Config
{
    internal class Database
    {
        public static MySqlConnection GetConnection()
        {
            string connString =
                "server=localhost;database=perpustakaan;uid=root;pwd=Ayamgoreng1025;";
            return new MySqlConnection(connString);
        }
    }
}
