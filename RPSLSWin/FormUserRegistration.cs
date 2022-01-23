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
            FormGameMainUI formGameMainUI = new FormGameMainUI();
            formGameMainUI.Show();
        }
    }
}
