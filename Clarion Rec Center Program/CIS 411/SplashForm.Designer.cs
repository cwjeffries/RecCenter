namespace CIS_411
{
    partial class SplashForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblRecCenter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(698, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(597, 37);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentUser.Size = new System.Drawing.Size(69, 13);
            this.lblCurrentUser.TabIndex = 31;
            this.lblCurrentUser.Text = "Current User:";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(641, 113);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 36);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "User Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Location = new System.Drawing.Point(641, 67);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(116, 36);
            this.btnStudentLogin.TabIndex = 29;
            this.btnStudentLogin.Text = "User Login";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(593, 8);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(181, 20);
            this.lblCurrentDateTime.TabIndex = 28;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // btnWorker
            // 
            this.btnWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker.Location = new System.Drawing.Point(275, 366);
            this.btnWorker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(193, 85);
            this.btnWorker.TabIndex = 27;
            this.btnWorker.Text = "Management Portal";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(275, 232);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(193, 80);
            this.btnCustomer.TabIndex = 26;
            this.btnCustomer.Text = "Customer Portal";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(388, 108);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(215, 40);
            this.lblSignIn.TabIndex = 25;
            this.lblSignIn.Text = "Home Screen";
            // 
            // lblRecCenter
            // 
            this.lblRecCenter.AutoSize = true;
            this.lblRecCenter.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCenter.Location = new System.Drawing.Point(402, 67);
            this.lblRecCenter.Name = "lblRecCenter";
            this.lblRecCenter.Size = new System.Drawing.Size(187, 40);
            this.lblRecCenter.TabIndex = 24;
            this.lblRecCenter.Text = "Rec Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS_411.Properties.Resources.ClarionLogo;
            this.pictureBox1.Location = new System.Drawing.Point(140, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 537);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblRecCenter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SplashForm";
            this.Text = "Home Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblRecCenter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}