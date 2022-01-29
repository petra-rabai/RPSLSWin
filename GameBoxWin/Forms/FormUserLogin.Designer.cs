namespace GameBox
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoginWindow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEDataSet = new GameBox.Database.GAMEDataSet();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.userTableAdapter = new GameBox.Database.GAMEDataSetTableAdapters.UserTableAdapter();
            this.labelUserNamelogin = new System.Windows.Forms.Label();
            this.labelUserPasswordlogin = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.pictureBoxUserPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.buttonNewUserRegister = new System.Windows.Forms.Button();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLoginWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 321);
            this.panel1.TabIndex = 0;
            // 
            // labelLoginWindow
            // 
            this.labelLoginWindow.AutoSize = true;
            this.labelLoginWindow.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginWindow.Location = new System.Drawing.Point(158, 2);
            this.labelLoginWindow.Name = "labelLoginWindow";
            this.labelLoginWindow.Size = new System.Drawing.Size(72, 27);
            this.labelLoginWindow.TabIndex = 9;
            this.labelLoginWindow.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserPasswordlogin);
            this.panel2.Controls.Add(this.pictureBoxUserPassword);
            this.panel2.Controls.Add(this.labelUserNamelogin);
            this.panel2.Controls.Add(this.pictureBoxUserName);
            this.panel2.Controls.Add(this.buttonNewUserRegister);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.buttonUserLogin);
            this.panel2.Controls.Add(this.textBoxUserPassword);
            this.panel2.Location = new System.Drawing.Point(51, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 266);
            this.panel2.TabIndex = 8;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.textBoxUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(49, 54);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserName.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.gAMEDataSet;
            // 
            // gAMEDataSet
            // 
            this.gAMEDataSet.DataSetName = "GAMEDataSet";
            this.gAMEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEDataSet, "User.UserPassword", true));
            this.textBoxUserPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(49, 120);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserPassword.TabIndex = 2;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // labelUserNamelogin
            // 
            this.labelUserNamelogin.AutoSize = true;
            this.labelUserNamelogin.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNamelogin.Location = new System.Drawing.Point(83, 26);
            this.labelUserNamelogin.Name = "labelUserNamelogin";
            this.labelUserNamelogin.Size = new System.Drawing.Size(133, 25);
            this.labelUserNamelogin.TabIndex = 6;
            this.labelUserNamelogin.Text = "User name: ";
            // 
            // labelUserPasswordlogin
            // 
            this.labelUserPasswordlogin.AutoSize = true;
            this.labelUserPasswordlogin.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPasswordlogin.Location = new System.Drawing.Point(79, 91);
            this.labelUserPasswordlogin.Name = "labelUserPasswordlogin";
            this.labelUserPasswordlogin.Size = new System.Drawing.Size(177, 25);
            this.labelUserPasswordlogin.TabIndex = 8;
            this.labelUserPasswordlogin.Text = "User password: ";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Image = global::GameBox.Properties.Resources.QuitButton;
            this.buttonQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuit.Location = new System.Drawing.Point(416, 301);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(96, 32);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // pictureBoxUserPassword
            // 
            this.pictureBoxUserPassword.Image = global::GameBox.Properties.Resources.UserPassword;
            this.pictureBoxUserPassword.Location = new System.Drawing.Point(52, 92);
            this.pictureBoxUserPassword.Name = "pictureBoxUserPassword";
            this.pictureBoxUserPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUserPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUserPassword.TabIndex = 7;
            this.pictureBoxUserPassword.TabStop = false;
            // 
            // pictureBoxUserName
            // 
            this.pictureBoxUserName.Image = global::GameBox.Properties.Resources.UserName;
            this.pictureBoxUserName.Location = new System.Drawing.Point(56, 26);
            this.pictureBoxUserName.Name = "pictureBoxUserName";
            this.pictureBoxUserName.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUserName.TabIndex = 5;
            this.pictureBoxUserName.TabStop = false;
            // 
            // buttonNewUserRegister
            // 
            this.buttonNewUserRegister.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUserRegister.Image = global::GameBox.Properties.Resources.UserRegistration;
            this.buttonNewUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewUserRegister.Location = new System.Drawing.Point(57, 215);
            this.buttonNewUserRegister.Name = "buttonNewUserRegister";
            this.buttonNewUserRegister.Size = new System.Drawing.Size(186, 33);
            this.buttonNewUserRegister.TabIndex = 4;
            this.buttonNewUserRegister.Text = "Registration";
            this.buttonNewUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewUserRegister.UseVisualStyleBackColor = true;
            this.buttonNewUserRegister.Click += new System.EventHandler(this.buttonNewUserRegister_Click);
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLogin.Image = global::GameBox.Properties.Resources.UserLogin;
            this.buttonUserLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserLogin.Location = new System.Drawing.Point(84, 177);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(132, 32);
            this.buttonUserLogin.TabIndex = 3;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 339);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNewUserRegister;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelLoginWindow;
        private Database.GAMEDataSet gAMEDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Database.GAMEDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label labelUserPasswordlogin;
        private System.Windows.Forms.PictureBox pictureBoxUserPassword;
        private System.Windows.Forms.Label labelUserNamelogin;
        private System.Windows.Forms.PictureBox pictureBoxUserName;
    }
}