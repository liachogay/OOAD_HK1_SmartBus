using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus
{
    class DBSQLServerUtils
    {

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;Integrated Security=SSPI";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
