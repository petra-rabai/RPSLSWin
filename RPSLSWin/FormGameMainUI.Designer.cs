namespace RPSLSWin
{
    partial class FormGameMainUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonNewUserRegister = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelLoginWindow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLoginWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 311);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Controls.Add(this.buttonNewUserRegister);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.labelUserPassword);
            this.panel2.Controls.Add(this.buttonUserLogin);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(51, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 276);
            this.panel2.TabIndex = 8;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(80, 24);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(112, 22);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User name: ";
            // 
            // buttonNewUserRegister
            // 
            this.buttonNewUserRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUserRegister.Location = new System.Drawing.Point(84, 215);
            this.buttonNewUserRegister.Name = "buttonNewUserRegister";
            this.buttonNewUserRegister.Size = new System.Drawing.Size(132, 32);
            this.buttonNewUserRegister.TabIndex = 7;
            this.buttonNewUserRegister.Text = "Registration";
            this.buttonNewUserRegister.UseVisualStyleBackColor = true;
            this.buttonNewUserRegister.Click += new System.EventHandler(this.buttonNewUserRegister_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(49, 49);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserName.TabIndex = 1;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPassword.Location = new System.Drawing.Point(80, 95);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(147, 22);
            this.labelUserPassword.TabIndex = 6;
            this.labelUserPassword.Text = "User password: ";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLogin.Location = new System.Drawing.Point(84, 177);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(132, 32);
            this.buttonUserLogin.TabIndex = 3;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '#';
            this.textBox1.Size = new System.Drawing.Size(194, 29);
            this.textBox1.TabIndex = 5;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(418, 291);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(96, 32);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelLoginWindow
            // 
            this.labelLoginWindow.AutoSize = true;
            this.labelLoginWindow.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginWindow.Location = new System.Drawing.Point(158, 2);
            this.labelLoginWindow.Name = "labelLoginWindow";
            this.labelLoginWindow.Size = new System.Drawing.Size(63, 24);
            this.labelLoginWindow.TabIndex = 9;
            this.labelLoginWindow.Text = "Login";
            // 
            // FormGameMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 335);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panel1);
            this.Name = "FormGameMainUI";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelLoginWindow;
    }
}