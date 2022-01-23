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
    public partial class FormGameMainUI : Form
    {
        public FormGameMainUI()
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
    }
}
