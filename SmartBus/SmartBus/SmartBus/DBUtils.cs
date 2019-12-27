using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus
{
    class DBUtils
    {
        //Data Source = DESKTOP - 1LS8MPD\SQLEXPRESS; Initial Catalog = SMARTBUS; Integrated Security = True
        public static SqlConnection GetDBConnection()
        {
            string datasource = "DESKTOP-1LS8MPD\\SQLEXPRESS";

            string database = "SMARTBUS";
            string username = "DESKTOP-1LS8MPD\\ASUS";
            string password = "";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
