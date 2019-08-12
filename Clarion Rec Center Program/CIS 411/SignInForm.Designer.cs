namespace CIS_411
{
    partial class SignInForm
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
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblRecCenter = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnForgotID = new System.Windows.Forms.Button();
            this.btnBuyMembership = new System.Windows.Forms.Button();
            this.btnDayPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(674, 9);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(181, 20);
            this.lblCurrentDateTime.TabIndex = 30;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // lblSignIn
            // 
            this.lblSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(464, 115);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(156, 49);
            this.lblSignIn.TabIndex = 29;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblRecCenter
            // 
            this.lblRecCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecCenter.AutoSize = true;
            this.lblRecCenter.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCenter.Location = new System.Drawing.Point(432, 66);
            this.lblRecCenter.Name = "lblRecCenter";
            this.lblRecCenter.Size = new System.Drawing.Size(228, 49);
            this.lblRecCenter.TabIndex = 28;
            this.lblRecCenter.Text = "Rec Center";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(132, 321);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(174, 25);
            this.lblPhoneNumber.TabIndex = 26;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(181, 246);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 25);
            this.lblFullName.TabIndex = 25;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(312, 317);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 29);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(312, 246);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 31);
            this.txtName.TabIndex = 23;
            // 
            // btnForgotID
            // 
            this.btnForgotID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForgotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotID.Location = new System.Drawing.Point(527, 406);
            this.btnForgotID.Name = "btnForgotID";
            this.btnForgotID.Size = new System.Drawing.Size(155, 102);
            this.btnForgotID.TabIndex = 22;
            this.btnForgotID.Text = "Forgot ID?";
            this.btnForgotID.UseVisualStyleBackColor = true;
            this.btnForgotID.Click += new System.EventHandler(this.btnForgotID_Click);
            // 
            // btnBuyMembership
            // 
            this.btnBuyMembership.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuyMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMembership.Location = new System.Drawing.Point(312, 409);
            this.btnBuyMembership.Name = "btnBuyMembership";
            this.btnBuyMembership.Size = new System.Drawing.Size(169, 99);
            this.btnBuyMembership.TabIndex = 21;
            this.btnBuyMembership.Text = "Buy Membership";
            this.btnBuyMembership.UseVisualStyleBackColor = true;
            this.btnBuyMembership.Click += new System.EventHandler(this.btnBuyMembership_Click);
            // 
            // btnDayPass
            // 
            this.btnDayPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDayPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayPass.Location = new System.Drawing.Point(107, 409);
            this.btnDayPass.Name = "btnDayPass";
            this.btnDayPass.Size = new System.Drawing.Size(165, 99);
            this.btnDayPass.TabIndex = 20;
            this.btnDayPass.Text = "Day Pass";
            this.btnDayPass.UseVisualStyleBackColor = true;
            this.btnDayPass.Click += new System.EventHandler(this.btnDayPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CIS_411.Properties.Resources.ClarionLogo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(745, 502);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 37);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(704, 36);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentUser.TabIndex = 32;
            this.lblCurrentUser.Text = "Current User: ";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 550);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblRecCenter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnForgotID);
            this.Controls.Add(this.btnBuyMembership);
            this.Controls.Add(this.btnDayPass);
            this.Name = "SignInForm";
            this.Text = "Customer Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.Enter += new System.EventHandler(this.SignInForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblRecCenter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnForgotID;
        private System.Windows.Forms.Button btnBuyMembership;
        private System.Windows.Forms.Button btnDayPass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentUser;
    }
}