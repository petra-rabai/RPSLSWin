using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLSWin
{
    public class UserErrorHandling : IUserErrorHandling
    {
        public MessageBoxIcon MessageBoxIcon { get; set; }
        public MessageBoxButtons MessageBoxButtons { get; set; }
        public string messageBoxType { get; set; } = "";
        public string messageBoxMessage { get; set; } = "";
        public string messageBoxCaption { get; set; } = "";
        public DialogResult dialogResult { get; set; }

        public void CreateMessageBox()
        {
            switch (messageBoxType)
            {
                case "Error":
                    MessageBoxIcon MessageBoxIconError = MessageBoxIcon.Error;
                    MessageBoxButtons MessageBoxButtonsError = MessageBoxButtons.OK;
                    messageBoxCaption = "User interaction error";
                    MessageBox.Show(messageBoxMessage,messageBoxCaption, MessageBoxButtonsError, MessageBoxIconError);
                    break;
                case "Question":
                    MessageBoxIcon MessageBoxIconQuestion = MessageBoxIcon.Question;
                    MessageBoxButtons MessageBoxButtonsQuestion = MessageBoxButtons.YesNo;
                    messageBoxCaption = "User question";
                    dialogResult = MessageBox.Show(messageBoxMessage, messageBoxCaption, MessageBoxButtonsQuestion, MessageBoxIconQuestion);
                    break;

                default:
                    break;

            }
        }
    }
}
