using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Eproject.Data
{
    public class SqlDataProvider
    {
        public static string connectionstring = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
        public static SqlConnection connection;
        public SqlDataProvider()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionstring);
            }
        }
        public SqlConnection getConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
            {
                return connection;
            }
        }
    }
}
