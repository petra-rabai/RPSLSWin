namespace RPSLSWin
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
            this.labelUserEmailRegistration = new System.Windows.Forms.Label();
            this.textBoxEmailaddress = new System.Windows.Forms.TextBox();
            this.labelUserNameRegistration = new System.Windows.Forms.Label();
            this.textBoxUserNameRegistration = new System.Windows.Forms.TextBox();
            this.labelUserPasswordRegistration = new System.Windows.Forms.Label();
            this.textBoxUserPasswordRegistration = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUserRegister = new System.Windows.Forms.Button();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.labelRegistrationWindow = new System.Windows.Forms.Label();
            this.bindingSourceRPSLSDB = new System.Windows.Forms.BindingSource(this.components);
            this.rPSLSDB_PrimaryDataSet = new RPSLSWin.RPSLSDB_PrimaryDataSet();
            this.panelUserRegistration.SuspendLayout();
            this.panelUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRPSLSDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPSLSDB_PrimaryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserRegistration
            // 
            this.panelUserRegistration.Controls.Add(this.labelRegistrationWindow);
            this.panelUserRegistration.Controls.Add(this.panelUserData);
            this.panelUserRegistration.Controls.Add(this.buttonUserRegister);
            this.panelUserRegistration.Controls.Add(this.buttonBack);
            this.panelUserRegistration.Location = new System.Drawing.Point(18, 18);
            this.panelUserRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUserRegistration.Name = "panelUserRegistration";
            this.panelUserRegistration.Size = new System.Drawing.Size(1164, 655);
            this.panelUserRegistration.TabIndex = 0;
            // 
            // labelUserEmailRegistration
            // 
            this.labelUserEmailRegistration.AutoSize = true;
            this.labelUserEmailRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmailRegistration.Location = new System.Drawing.Point(94, 230);
            this.labelUserEmailRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserEmailRegistration.Name = "labelUserEmailRegistration";
            this.labelUserEmailRegistration.Size = new System.Drawing.Size(217, 33);
            this.labelUserEmailRegistration.TabIndex = 15;
            this.labelUserEmailRegistration.Text = "Email address: ";
            // 
            // textBoxEmailaddress
            // 
            this.textBoxEmailaddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailaddress.Location = new System.Drawing.Point(100, 268);
            this.textBoxEmailaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmailaddress.Name = "textBoxEmailaddress";
            this.textBoxEmailaddress.Size = new System.Drawing.Size(289, 40);
            this.textBoxEmailaddress.TabIndex = 14;
            // 
            // labelUserNameRegistration
            // 
            this.labelUserNameRegistration.AutoSize = true;
            this.labelUserNameRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameRegistration.Location = new System.Drawing.Point(100, 22);
            this.labelUserNameRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserNameRegistration.Name = "labelUserNameRegistration";
            this.labelUserNameRegistration.Size = new System.Drawing.Size(174, 33);
            this.labelUserNameRegistration.TabIndex = 11;
            this.labelUserNameRegistration.Text = "User name: ";
            // 
            // textBoxUserNameRegistration
            // 
            this.textBoxUserNameRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameRegistration.Location = new System.Drawing.Point(100, 61);
            this.textBoxUserNameRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserNameRegistration.Name = "textBoxUserNameRegistration";
            this.textBoxUserNameRegistration.Size = new System.Drawing.Size(289, 40);
            this.textBoxUserNameRegistration.TabIndex = 10;
            // 
            // labelUserPasswordRegistration
            // 
            this.labelUserPasswordRegistration.AutoSize = true;
            this.labelUserPasswordRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPasswordRegistration.Location = new System.Drawing.Point(100, 125);
            this.labelUserPasswordRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserPasswordRegistration.Name = "labelUserPasswordRegistration";
            this.labelUserPasswordRegistration.Size = new System.Drawing.Size(226, 33);
            this.labelUserPasswordRegistration.TabIndex = 13;
            this.labelUserPasswordRegistration.Text = "User password: ";
            // 
            // textBoxUserPasswordRegistration
            // 
            this.textBoxUserPasswordRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPasswordRegistration.Location = new System.Drawing.Point(100, 164);
            this.textBoxUserPasswordRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserPasswordRegistration.Name = "textBoxUserPasswordRegistration";
            this.textBoxUserPasswordRegistration.PasswordChar = '#';
            this.textBoxUserPasswordRegistration.Size = new System.Drawing.Size(289, 40);
            this.textBoxUserPasswordRegistration.TabIndex = 12;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(1016, 602);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 49);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUserRegister
            // 
            this.buttonUserRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserRegister.Location = new System.Drawing.Point(4, 601);
            this.buttonUserRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserRegister.Name = "buttonUserRegister";
            this.buttonUserRegister.Size = new System.Drawing.Size(144, 49);
            this.buttonUserRegister.TabIndex = 16;
            this.buttonUserRegister.Text = "Register";
            this.buttonUserRegister.UseVisualStyleBackColor = true;
            this.buttonUserRegister.Click += new System.EventHandler(this.buttonUserRegister_Click);
            // 
            // panelUserData
            // 
            this.panelUserData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserData.Controls.Add(this.textBoxUserNameRegistration);
            this.panelUserData.Controls.Add(this.textBoxUserPasswordRegistration);
            this.panelUserData.Controls.Add(this.labelUserEmailRegistration);
            this.panelUserData.Controls.Add(this.labelUserPasswordRegistration);
            this.panelUserData.Controls.Add(this.textBoxEmailaddress);
            this.panelUserData.Controls.Add(this.labelUserNameRegistration);
            this.panelUserData.Location = new System.Drawing.Point(353, 66);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(464, 347);
            this.panelUserData.TabIndex = 17;
            // 
            // labelRegistrationWindow
            // 
            this.labelRegistrationWindow.AutoSize = true;
            this.labelRegistrationWindow.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationWindow.Location = new System.Drawing.Point(490, 16);
            this.labelRegistrationWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrationWindow.Name = "labelRegistrationWindow";
            this.labelRegistrationWindow.Size = new System.Drawing.Size(190, 35);
            this.labelRegistrationWindow.TabIndex = 18;
            this.labelRegistrationWindow.Text = "Registration";
            // 
            // bindingSourceRPSLSDB
            // 
            this.bindingSourceRPSLSDB.DataSource = this.rPSLSDB_PrimaryDataSet;
            this.bindingSourceRPSLSDB.Position = 0;
            // 
            // rPSLSDB_PrimaryDataSet
            // 
            this.rPSLSDB_PrimaryDataSet.DataSetName = "RPSLSDB_PrimaryDataSet";
            this.rPSLSDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panelUserRegistration);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUserRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUserRegistration.ResumeLayout(false);
            this.panelUserRegistration.PerformLayout();
            this.panelUserData.ResumeLayout(false);
            this.panelUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRPSLSDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPSLSDB_PrimaryDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceRPSLSDB;
        private RPSLSDB_PrimaryDataSet rPSLSDB_PrimaryDataSet;
    }
}