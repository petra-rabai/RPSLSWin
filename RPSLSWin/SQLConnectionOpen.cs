using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace RPSLSWin
{
   public class SQLConnectionOpen : ISQLConnectionData, ISQLConnectionOpen
    {
        public string ConnectionString { get; set; } = Properties.Settings.Default.RPSLSDB_PrimaryConnectionString;
        public SqlConnection DbConnection { get; set; }

        public void ConnectionOpen()
        {
            DbConnection = new SqlConnection(ConnectionString);
            DbConnection.Open();
        }
    }
}
