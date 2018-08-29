using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbSetup
    {
        private SqlConnection sqlConnection = null;

        public DbSetup(string sqlConnectionString)
        {
            sqlConnection = new SqlConnection(sqlConnectionString);
        }
    }
}
