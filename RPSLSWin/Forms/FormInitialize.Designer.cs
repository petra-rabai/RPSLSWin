namespace RPSLSWin
{
    partial class FormInitialize
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
            this.panelLoadMainScreen = new System.Windows.Forms.Panel();
            this.labelLoadingPercent = new System.Windows.Forms.Label();
            this.progressBarLoadMainScreen = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStartApp = new System.Windows.Forms.Button();
            this.buttonQuitApp = new System.Windows.Forms.Button();
            this.panelLoadMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoadMainScreen
            // 
            this.panelLoadMainScreen.BackColor = System.Drawing.SystemColors.Control;
            this.panelLoadMainScreen.Controls.Add(this.labelLoadingPercent);
            this.panelLoadMainScreen.Controls.Add(this.buttonStartApp);
            this.panelLoadMainScreen.Controls.Add(this.buttonQuitApp);
            this.panelLoadMainScreen.Controls.Add(this.progressBarLoadMainScreen);
            this.panelLoadMainScreen.Location = new System.Drawing.Point(5, 218);
            this.panelLoadMainScreen.Name = "panelLoadMainScreen";
            this.panelLoadMainScreen.Size = new System.Drawing.Size(391, 136);
            this.panelLoadMainScreen.TabIndex = 0;
            // 
            // labelLoadingPercent
            // 
            this.labelLoadingPercent.AutoSize = true;
            this.labelLoadingPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoadingPercent.Font = new System.Drawing.Font("Cascadia Code SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingPercent.Location = new System.Drawing.Point(173, 56);
            this.labelLoadingPercent.Name = "labelLoadingPercent";
            this.labelLoadingPercent.Size = new System.Drawing.Size(29, 22);
            this.labelLoadingPercent.TabIndex = 3;
            this.labelLoadingPercent.Text = "0%";
            this.labelLoadingPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarLoadMainScreen
            // 
            this.progressBarLoadMainScreen.Location = new System.Drawing.Point(0, 51);
            this.progressBarLoadMainScreen.Name = "progressBarLoadMainScreen";
            this.progressBarLoadMainScreen.Size = new System.Drawing.Size(391, 32);
            this.progressBarLoadMainScreen.TabIndex = 0;
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPSLSWin.Properties.Resources.CompanyLogo;
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStartApp
            // 
            this.buttonStartApp.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartApp.Image = global::RPSLSWin.Properties.Resources.StartButton;
            this.buttonStartApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartApp.Location = new System.Drawing.Point(3, 101);
            this.buttonStartApp.Name = "buttonStartApp";
            this.buttonStartApp.Size = new System.Drawing.Size(132, 32);
            this.buttonStartApp.TabIndex = 2;
            this.buttonStartApp.Text = "Start";
            this.buttonStartApp.UseVisualStyleBackColor = true;
            this.buttonStartApp.Click += new System.EventHandler(this.buttonStartApp_Click);
            // 
            // buttonQuitApp
            // 
            this.buttonQuitApp.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitApp.Image = global::RPSLSWin.Properties.Resources.QuitButton;
            this.buttonQuitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitApp.Location = new System.Drawing.Point(255, 101);
            this.buttonQuitApp.Name = "buttonQuitApp";
            this.buttonQuitApp.Size = new System.Drawing.Size(132, 32);
            this.buttonQuitApp.TabIndex = 1;
            this.buttonQuitApp.Text = "Quit";
            this.buttonQuitApp.UseVisualStyleBackColor = true;
            this.buttonQuitApp.Click += new System.EventHandler(this.buttonQuitApp_Click);
            // 
            // FormInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 358);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLoadMainScreen);
            this.Name = "FormInitialize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormInitialize_Load);
            this.panelLoadMainScreen.ResumeLayout(false);
            this.panelLoadMainScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoadMainScreen;
        private System.Windows.Forms.ProgressBar progressBarLoadMainScreen;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Button buttonStartApp;
        private System.Windows.Forms.Button buttonQuitApp;
        private System.Windows.Forms.Label labelLoadingPercent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

