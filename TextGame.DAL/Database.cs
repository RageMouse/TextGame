using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TextGame.DAL
{
    public class Database
    {
        private static ConnectionStringBuilder connectionStringBuilder = new ConnectionStringBuilder();

        public static SqlConnection getConnection()
        {
            return connectionStringBuilder.GetConnection();
        }
    }
}
