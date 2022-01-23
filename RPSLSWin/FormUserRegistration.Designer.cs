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
            this.panelUserRegistration = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelUserNameRegistration = new System.Windows.Forms.Label();
            this.textBoxUserNameRegistration = new System.Windows.Forms.TextBox();
            this.labelUserPasswordRegistration = new System.Windows.Forms.Label();
            this.textBoxUserPasswordRegistration = new System.Windows.Forms.TextBox();
            this.labelUserEmailRegistration = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelUserRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserRegistration
            // 
            this.panelUserRegistration.Controls.Add(this.labelUserEmailRegistration);
            this.panelUserRegistration.Controls.Add(this.textBox1);
            this.panelUserRegistration.Controls.Add(this.labelUserNameRegistration);
            this.panelUserRegistration.Controls.Add(this.textBoxUserNameRegistration);
            this.panelUserRegistration.Controls.Add(this.labelUserPasswordRegistration);
            this.panelUserRegistration.Controls.Add(this.textBoxUserPasswordRegistration);
            this.panelUserRegistration.Controls.Add(this.buttonBack);
            this.panelUserRegistration.Location = new System.Drawing.Point(12, 12);
            this.panelUserRegistration.Name = "panelUserRegistration";
            this.panelUserRegistration.Size = new System.Drawing.Size(776, 426);
            this.panelUserRegistration.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(677, 391);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 32);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelUserNameRegistration
            // 
            this.labelUserNameRegistration.AutoSize = true;
            this.labelUserNameRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameRegistration.Location = new System.Drawing.Point(3, 6);
            this.labelUserNameRegistration.Name = "labelUserNameRegistration";
            this.labelUserNameRegistration.Size = new System.Drawing.Size(112, 22);
            this.labelUserNameRegistration.TabIndex = 11;
            this.labelUserNameRegistration.Text = "User name: ";
            // 
            // textBoxUserNameRegistration
            // 
            this.textBoxUserNameRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameRegistration.Location = new System.Drawing.Point(3, 31);
            this.textBoxUserNameRegistration.Name = "textBoxUserNameRegistration";
            this.textBoxUserNameRegistration.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserNameRegistration.TabIndex = 10;
            // 
            // labelUserPasswordRegistration
            // 
            this.labelUserPasswordRegistration.AutoSize = true;
            this.labelUserPasswordRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPasswordRegistration.Location = new System.Drawing.Point(3, 73);
            this.labelUserPasswordRegistration.Name = "labelUserPasswordRegistration";
            this.labelUserPasswordRegistration.Size = new System.Drawing.Size(147, 22);
            this.labelUserPasswordRegistration.TabIndex = 13;
            this.labelUserPasswordRegistration.Text = "User password: ";
            // 
            // textBoxUserPasswordRegistration
            // 
            this.textBoxUserPasswordRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPasswordRegistration.Location = new System.Drawing.Point(3, 98);
            this.textBoxUserPasswordRegistration.Name = "textBoxUserPasswordRegistration";
            this.textBoxUserPasswordRegistration.PasswordChar = '#';
            this.textBoxUserPasswordRegistration.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserPasswordRegistration.TabIndex = 12;
            // 
            // labelUserEmailRegistration
            // 
            this.labelUserEmailRegistration.AutoSize = true;
            this.labelUserEmailRegistration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmailRegistration.Location = new System.Drawing.Point(3, 141);
            this.labelUserEmailRegistration.Name = "labelUserEmailRegistration";
            this.labelUserEmailRegistration.Size = new System.Drawing.Size(141, 22);
            this.labelUserEmailRegistration.TabIndex = 15;
            this.labelUserEmailRegistration.Text = "Email address: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 29);
            this.textBox1.TabIndex = 14;
            // 
            // FormUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelUserRegistration);
            this.Name = "FormUserRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUserRegistration.ResumeLayout(false);
            this.panelUserRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserRegistration;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUserEmailRegistration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUserNameRegistration;
        private System.Windows.Forms.TextBox textBoxUserNameRegistration;
        private System.Windows.Forms.Label labelUserPasswordRegistration;
        private System.Windows.Forms.TextBox textBoxUserPasswordRegistration;
    }
}