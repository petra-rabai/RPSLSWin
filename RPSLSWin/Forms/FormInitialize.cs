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
    public partial class FormInitialize : Form
    {
        public FormInitialize()
        {
            InitializeComponent();
        }

        private void FormInitialize_Load(object sender, EventArgs e)
        {
            timerLoading.Enabled = true;
            buttonQuitApp.Visible = false;
            buttonStartApp.Visible = false;
            progressBarLoadMainScreen.Value = 0;

        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (progressBarLoadMainScreen.Value <100)
            {
                progressBarLoadMainScreen.Value++;
                labelLoadingPercent.Text = progressBarLoadMainScreen.Value.ToString() + " %";
            }
            else
            {
                timerLoading.Enabled = false;
                buttonQuitApp.Visible = true;
                buttonStartApp.Visible = true;
                progressBarLoadMainScreen.Visible = false;
                labelLoadingPercent.Visible = false;
            }
        }

        private void buttonQuitApp_Click(object sender, EventArgs e)
        {
            ApplicationQuit applicationQuit = new ApplicationQuit();
            applicationQuit.Quit();
        }

        private void buttonStartApp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormUserLogin formGameMain = new FormUserLogin();
            formGameMain.Show();  
        }
    }
}
