using System.Data.SqlClient;

namespace RPSLSWin
{
    public interface ISQLConnectionData
    {
        string ConnectionString { get; set; }
        SqlConnection DbConnection { get; set; }
    }
}