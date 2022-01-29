using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBox
{
    public interface ISQLActionInsertData
    {
        void SQLInsertData(SQLConnectionOpen sQLConnectionInitialize);
    }
}
