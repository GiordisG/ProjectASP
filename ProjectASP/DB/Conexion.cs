using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjectASP.DB
{
    public static class Conexion
    {
        public static MySqlConnection conexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "proyectoasp";
            var cn = new MySqlConnection(builder.ToString());
            return cn;
        }
    }
}