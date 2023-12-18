using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace task4._0
{
    internal class DataBase
    {
        private MySqlConnection con = new MySqlConnection("datasource=softwareserver.database.windows.net;port=1433;username=akmaral;password=an271003-;database=mydb");
        public MySqlConnection getConnection
        {
            get
            { return con; }
        }
        public void openconnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }

}

