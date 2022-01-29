using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLSWin
{
    public interface IUserErrorHandling
    {
        MessageBoxIcon MessageBoxIcon { get; set; }
        MessageBoxButtons MessageBoxButtons { get; set; }
        DialogResult dialogResult { get; set; }
        string messageBoxType { get; set; }
        string messageBoxMessage { get; set; }
        string messageBoxCaption { get; set; }
        void CreateMessageBox();
    }
}
