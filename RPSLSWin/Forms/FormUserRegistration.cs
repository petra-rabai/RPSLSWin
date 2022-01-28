using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLSWin
{
    public partial class FormUserRegistration : Form
    {
        public FormUserRegistration()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormUserLogin formGameMainUI = new FormUserLogin();
            formGameMainUI.Show();
        }

        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserNameRegistration.Text;
            string userPassword = textBoxUserPasswordRegistration.Text;
            string userEmail = textBoxEmailaddress.Text;
            UserErrorHandling userErrorHandling = new UserErrorHandling();

            if ((userName == "") || (userPassword == "") || (userEmail == ""))
            {
                userErrorHandling.messageBoxType = "Error";
                userErrorHandling.messageBoxMessage = "Please fill all fields on the Registration form!";
                userErrorHandling.CreateMessageBox();
            }

            SQLConnectionOpen sQLConnectionInitialize = new SQLConnectionOpen();
            SQLActionInsertData sQLActionInsertData = new SQLActionInsertData();
            SQLConnectionClose sQLConnectionClose = new SQLConnectionClose();

            sQLConnectionInitialize.ConnectionOpen();
            sQLActionInsertData.sqlStatement = "INSERT INTO [dbo].[User] ([UserName], [UserPassword], [UserEmail]) values (" + "'"+ textBoxUserNameRegistration.Text + "'" + ","+ "'" + textBoxUserPasswordRegistration.Text + "'" + "," + "'" + textBoxEmailaddress.Text + "'" + ")";
            sQLActionInsertData.SQLInsertData(sQLConnectionInitialize);
            userErrorHandling.messageBoxType = "Info";
            userErrorHandling.messageBoxMessage = "User registration success.";
            userErrorHandling.CreateMessageBox();
            sQLConnectionClose.ConnectionClose();
            
            
        }
    }
}
