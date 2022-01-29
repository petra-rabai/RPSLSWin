using System.Data.SqlClient;

namespace GameBox
{
    public interface ISQLConnectionData
    {
        string ConnectionString { get; set; }
        SqlConnection DbConnection { get; set; }
    }
}