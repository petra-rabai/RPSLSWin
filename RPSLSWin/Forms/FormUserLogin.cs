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
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewUserRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormUserRegistration formUserRegistration = new FormUserRegistration();
            formUserRegistration.Show();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            SQLConnectionOpen sQLConnectionInitialize = new SQLConnectionOpen();
            SQLActionSelectData sQLActionSelectData = new SQLActionSelectData();
            SQLConnectionClose sQLConnectionClose = new SQLConnectionClose();
            DataTable loginUserValidation = new DataTable();
            
            sQLConnectionInitialize.ConnectionOpen();
            sQLActionSelectData.sqlStatement = "SELECT COUNT(*) FROM [dbo].[User] WHERE [User name]= " + "'" +textBoxUserName.Text +"'" + " AND [User password]=" +"'" + textBoxUserPassword.Text+"'";
            sQLActionSelectData.SQLSelectData(sQLConnectionInitialize);
            sQLActionSelectData.sqlDataAdapter.Fill(loginUserValidation);
            
            if (loginUserValidation.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("User Login success");
            }
            else
            {
                MessageBox.Show("Invalid user name or password");
            }

            sQLConnectionClose.ConnectionClose();

            
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gAMEDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.gAMEDataSet.User);

        }
    }
}
