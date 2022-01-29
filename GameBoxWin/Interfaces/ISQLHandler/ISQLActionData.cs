using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RPSLSWin
{
    public interface ISQLActionData
    {
        SqlCommand sqlCommand { get; set; }
        SqlDataAdapter sqlDataAdapter { get; set; }
        string sqlStatement { get; set; }
    }
}
