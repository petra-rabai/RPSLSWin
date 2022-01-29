namespace GameBox
{
    partial class FormUserRegistration
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
            this.panelUserRegistration = new System.Windows.Forms.Panel();
            this.labelRegistrationWindow = new System.Windows.Forms.Label();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUserNameRegistration = new System.Windows.Forms.TextBox();
            this.gAMEDataSet = new GameBox.Database.GAMEDataSet();
            this.textBoxUserPasswordRegistration = new System.Windows.Forms.TextBox();
            this.labelUserEmailRegistration = new System.Windows.Forms.Label();
            this.labelUserPasswordRegistration = new System.Windows.Forms.Label();
            this.textBoxEmailaddress = new System.Windows.Forms.TextBox();
            this.labelUserNameRegistration = new System.Windows.Forms.Label();
            this.buttonUserRegister = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.bindingSourceGameDB = new System.Windows.Forms.BindingSource(this.components);
            this.panelUserRegistration.SuspendLayout();
            this.panelUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGameDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserRegistration
            // 
            this.panelUserRegistration.Controls.Add(this.labelRegistrationWindow);
            this.panelUserRegistration.Controls.Add(this.panelUserData);
            this.panelUserRegistration.Controls.Add(this.buttonUserRegister);
            this.panelUserRegistration.Controls.Add(this.buttonBack);
            this.panelUserRegistration.Location = new System.Drawing.Point(12, 12);
            this.panelUserRegistration.Name = "panelUserRegistration";
            this.panelUserRegistration.Size = new System.Drawing.Size(332, 351);
            this.panelUserRegistration.TabIndex = 0;
            // 
            // labelRegistrationWindow
            // 
            this.labelRegistrationWindow.AutoSize = true;
            this.labelRegistrationWindow.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationWindow.Location = new System.Drawing.Point(86, 10);
            this.labelRegistrationWindow.Name = "labelRegistrationWindow";
            this.labelRegistrationWindow.Size = new System.Drawing.Size(156, 27);
            this.labelRegistrationWindow.TabIndex = 18;
            this.labelRegistrationWindow.Text = "Registration";
            // 
            // panelUserData
            // 
            this.panelUserData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserData.Controls.Add(this.pictureBox3);
            this.panelUserData.Controls.Add(this.pictureBox2);
            this.panelUserData.Controls.Add(this.pictureBox1);
            this.panelUserData.Controls.Add(this.textBoxUserNameRegistration);
            this.panelUserData.Controls.Add(this.textBoxUserPasswordRegistration);
            this.panelUserData.Controls.Add(this.labelUserEmailRegistration);
            this.panelUserData.Controls.Add(this.labelUserPasswordRegistration);
            this.panelUserData.Controls.Add(this.textBoxEmailaddress);
            this.panelUserData.Controls.Add(this.labelUserNameRegistration);
            this.panelUserData.Location = new System.Drawing.Point(11, 43);
            this.panelUserData.Margin = new System.Windows.Forms.Padding(2);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(310, 226);
            this.panelUserData.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GameBox.Properties.Resources.UserEmail;
            this.pictureBox3.Location = new System.Drawing.Point(71, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameBox.Properties.Resources.UserPassword;
            this.pictureBox2.Location = new System.Drawing.Point(71, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameBox.Properties.Resources.UserName;
            this.pictureBox1.Location = new System.Drawing.Point(71, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUserNameRegistration
            // 
            this.textBoxUserNameRegistration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEDataSet, "User.UserName", true));
            this.textBoxUserNameRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameRegistration.Location = new System.Drawing.Point(67, 43);
            this.textBoxUserNameRegistration.Name = "textBoxUserNameRegistration";
            this.textBoxUserNameRegistration.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserNameRegistration.TabIndex = 1;
            // 
            // gAMEDataSet
            // 
            this.gAMEDataSet.DataSetName = "GAMEDataSet";
            this.gAMEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxUserPasswordRegistration
            // 
            this.textBoxUserPasswordRegistration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEDataSet, "User.UserPassword", true));
            this.textBoxUserPasswordRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPasswordRegistration.Location = new System.Drawing.Point(67, 109);
            this.textBoxUserPasswordRegistration.Name = "textBoxUserPasswordRegistration";
            this.textBoxUserPasswordRegistration.PasswordChar = '*';
            this.textBoxUserPasswordRegistration.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserPasswordRegistration.TabIndex = 2;
            // 
            // labelUserEmailRegistration
            // 
            this.labelUserEmailRegistration.AutoSize = true;
            this.labelUserEmailRegistration.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmailRegistration.Location = new System.Drawing.Point(101, 150);
            this.labelUserEmailRegistration.Name = "labelUserEmailRegistration";
            this.labelUserEmailRegistration.Size = new System.Drawing.Size(177, 25);
            this.labelUserEmailRegistration.TabIndex = 15;
            this.labelUserEmailRegistration.Text = "Email address: ";
            // 
            // labelUserPasswordRegistration
            // 
            this.labelUserPasswordRegistration.AutoSize = true;
            this.labelUserPasswordRegistration.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPasswordRegistration.Location = new System.Drawing.Point(101, 82);
            this.labelUserPasswordRegistration.Name = "labelUserPasswordRegistration";
            this.labelUserPasswordRegistration.Size = new System.Drawing.Size(177, 25);
            this.labelUserPasswordRegistration.TabIndex = 13;
            this.labelUserPasswordRegistration.Text = "User password: ";
            // 
            // textBoxEmailaddress
            // 
            this.textBoxEmailaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEDataSet, "User.UserEmail", true));
            this.textBoxEmailaddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailaddress.Location = new System.Drawing.Point(67, 177);
            this.textBoxEmailaddress.Name = "textBoxEmailaddress";
            this.textBoxEmailaddress.Size = new System.Drawing.Size(194, 29);
            this.textBoxEmailaddress.TabIndex = 3;
            // 
            // labelUserNameRegistration
            // 
            this.labelUserNameRegistration.AutoSize = true;
            this.labelUserNameRegistration.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameRegistration.Location = new System.Drawing.Point(101, 16);
            this.labelUserNameRegistration.Name = "labelUserNameRegistration";
            this.labelUserNameRegistration.Size = new System.Drawing.Size(133, 25);
            this.labelUserNameRegistration.TabIndex = 11;
            this.labelUserNameRegistration.Text = "User name: ";
            // 
            // buttonUserRegister
            // 
            this.buttonUserRegister.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserRegister.Image = global::GameBox.Properties.Resources.UserSaved;
            this.buttonUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserRegister.Location = new System.Drawing.Point(107, 274);
            this.buttonUserRegister.Name = "buttonUserRegister";
            this.buttonUserRegister.Size = new System.Drawing.Size(139, 32);
            this.buttonUserRegister.TabIndex = 4;
            this.buttonUserRegister.Text = "Register";
            this.buttonUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserRegister.UseVisualStyleBackColor = true;
            this.buttonUserRegister.Click += new System.EventHandler(this.buttonUserRegister_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::GameBox.Properties.Resources.QuitButton;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(127, 312);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 32);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // bindingSourceGameDB
            // 
            this.bindingSourceGameDB.DataSource = this.gAMEDataSet;
            this.bindingSourceGameDB.Position = 0;
            // 
            // FormUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 372);
            this.ControlBox = false;
            this.Controls.Add(this.panelUserRegistration);
            this.Name = "FormUserRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUserRegistration.ResumeLayout(false);
            this.panelUserRegistration.PerformLayout();
            this.panelUserData.ResumeLayout(false);
            this.panelUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGameDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserRegistration;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUserEmailRegistration;
        private System.Windows.Forms.TextBox textBoxEmailaddress;
        private System.Windows.Forms.Label labelUserNameRegistration;
        private System.Windows.Forms.TextBox textBoxUserNameRegistration;
        private System.Windows.Forms.Label labelUserPasswordRegistration;
        private System.Windows.Forms.TextBox textBoxUserPasswordRegistration;
        private System.Windows.Forms.Panel panelUserData;
        private System.Windows.Forms.Button buttonUserRegister;
        private System.Windows.Forms.Label labelRegistrationWindow;
        private System.Windows.Forms.BindingSource bindingSourceGameDB;
        private Database.GAMEDataSet gAMEDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}