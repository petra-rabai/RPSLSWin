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
            SQLConnectionOpen sQLConnectionInitialize = new SQLConnectionOpen();
            SQLActionInsertData sQLActionInsertData = new SQLActionInsertData();
            SQLConnectionClose sQLConnectionClose = new SQLConnectionClose();

            sQLConnectionInitialize.ConnectionOpen();
            sQLActionInsertData.sqlStatement = "INSERT INTO [dbo].[User] ([User name], [User password], [User e-mail address]) values (" + "'"+ textBoxUserNameRegistration.Text + "'" + ","+ "'" + textBoxUserPasswordRegistration.Text + "'" + "," + "'" + textBoxEmailaddress.Text + "'" + ")";
            sQLActionInsertData.SQLInsertData(sQLConnectionInitialize);
            sQLConnectionClose.ConnectionClose();
            
            MessageBox.Show("User registration success");
        }
    }
}
