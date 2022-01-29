using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBox
{
    public class SQLActionInsertData : ISQLActionData, ISQLActionInsertData
    {
        public SqlCommand sqlCommand { get; set; }
        public SqlDataAdapter sqlDataAdapter { get; set; } = new SqlDataAdapter();
        public string sqlStatement { get; set; } = "";
       

        public void SQLInsertData(SQLConnectionOpen sQLConnectionInitialize)
        {
            sqlCommand = new SqlCommand(sqlStatement, sQLConnectionInitialize.DbConnection);
            sqlDataAdapter.InsertCommand = sqlCommand;
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
        }
    }
}
