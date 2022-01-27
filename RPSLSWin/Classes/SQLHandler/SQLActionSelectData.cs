using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RPSLSWin
{
    public class SQLActionSelectData : ISQLActionSelectData, ISQLActionData
    {
        public SqlCommand sqlCommand { get; set; }
        public SqlDataAdapter sqlDataAdapter { get; set; } = new SqlDataAdapter();
        public string sqlStatement { get; set; } = "";

        public void SQLSelectData(SQLConnectionOpen sQLConnectionInitialize)
        {
            sqlCommand = new SqlCommand(sqlStatement, sQLConnectionInitialize.DbConnection);
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
        }
    }
}
