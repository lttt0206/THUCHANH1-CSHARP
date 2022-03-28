using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPhim
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"localhost";
            string database = "DBPhim";
            string username = "sa";
            string password = "1234";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
