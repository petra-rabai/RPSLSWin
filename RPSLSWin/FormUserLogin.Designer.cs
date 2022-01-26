namespace RPSLSWin
{
    partial class FormUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoginWindow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonNewUserRegister = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLoginWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 477);
            this.panel1.TabIndex = 0;
            // 
            // labelLoginWindow
            // 
            this.labelLoginWindow.AutoSize = true;
            this.labelLoginWindow.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginWindow.Location = new System.Drawing.Point(237, 3);
            this.labelLoginWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginWindow.Name = "labelLoginWindow";
            this.labelLoginWindow.Size = new System.Drawing.Size(95, 35);
            this.labelLoginWindow.TabIndex = 9;
            this.labelLoginWindow.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Controls.Add(this.buttonNewUserRegister);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.labelUserPassword);
            this.panel2.Controls.Add(this.buttonUserLogin);
            this.panel2.Controls.Add(this.textBoxUserPassword);
            this.panel2.Location = new System.Drawing.Point(76, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 425);
            this.panel2.TabIndex = 8;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(120, 37);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(174, 33);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User name: ";
            // 
            // buttonNewUserRegister
            // 
            this.buttonNewUserRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUserRegister.Location = new System.Drawing.Point(126, 331);
            this.buttonNewUserRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNewUserRegister.Name = "buttonNewUserRegister";
            this.buttonNewUserRegister.Size = new System.Drawing.Size(198, 49);
            this.buttonNewUserRegister.TabIndex = 7;
            this.buttonNewUserRegister.Text = "Registration";
            this.buttonNewUserRegister.UseVisualStyleBackColor = true;
            this.buttonNewUserRegister.Click += new System.EventHandler(this.buttonNewUserRegister_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(74, 75);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(289, 40);
            this.textBoxUserName.TabIndex = 1;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPassword.Location = new System.Drawing.Point(120, 146);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(226, 33);
            this.labelUserPassword.TabIndex = 6;
            this.labelUserPassword.Text = "User password: ";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLogin.Location = new System.Drawing.Point(126, 272);
            this.buttonUserLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(198, 49);
            this.buttonUserLogin.TabIndex = 3;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(74, 185);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '#';
            this.textBoxUserPassword.Size = new System.Drawing.Size(289, 40);
            this.textBoxUserPassword.TabIndex = 5;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(627, 448);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(144, 49);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 515);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUserLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonNewUserRegister;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelLoginWindow;
    }
}