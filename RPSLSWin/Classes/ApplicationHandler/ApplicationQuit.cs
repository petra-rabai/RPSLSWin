using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLSWin
{
    public class ApplicationQuit : IApplicationQuit
    {
        
        public void Quit()
        {
            UserErrorHandling userErrorHandling = new UserErrorHandling();
            userErrorHandling.messageBoxType = "Question";
            userErrorHandling.messageBoxMessage = "Are you shure you want to quit?";
            userErrorHandling.CreateMessageBox();

            if (userErrorHandling.dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
    }
}
