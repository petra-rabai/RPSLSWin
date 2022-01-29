using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBox
{
    public class SQLConnectionData : ISQLConnectionData
    {
        public string ConnectionString { get; set; } = Properties.Settings.Default.GAMEConnectionString;
        public SqlConnection DbConnection { get; set; }
    }
}
