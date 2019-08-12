namespace CIS_411
{
    partial class LiabilityWaiver
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.rdoCheck = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMemTypeDisplay = new System.Windows.Forms.Label();
            this.lblCostDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(936, 244);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(120, 20);
            this.lblPayment.TabIndex = 46;
            this.lblPayment.Text = "Payment Type:";
            // 
            // rdoCheck
            // 
            this.rdoCheck.AutoSize = true;
            this.rdoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheck.Location = new System.Drawing.Point(940, 300);
            this.rdoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCheck.Name = "rdoCheck";
            this.rdoCheck.Size = new System.Drawing.Size(77, 24);
            this.rdoCheck.TabIndex = 45;
            this.rdoCheck.TabStop = true;
            this.rdoCheck.Text = "Check";
            this.rdoCheck.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCash.Location = new System.Drawing.Point(940, 268);
            this.rdoCash.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(69, 24);
            this.rdoCash.TabIndex = 44;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(1030, 9);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(232, 25);
            this.lblCurrentDateTime.TabIndex = 43;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCost.Location = new System.Drawing.Point(765, 177);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(64, 25);
            this.lblCost.TabIndex = 42;
            this.lblCost.Text = "Cost:";
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMembershipType.Location = new System.Drawing.Point(765, 143);
            this.lblMembershipType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(192, 25);
            this.lblMembershipType.TabIndex = 41;
            this.lblMembershipType.Text = "Membership Type:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(765, 109);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(162, 25);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullName.Location = new System.Drawing.Point(765, 75);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(116, 25);
            this.lblFullName.TabIndex = 39;
            this.lblFullName.Text = "Full Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(922, 516);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 89);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(922, 382);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(169, 87);
            this.btnAccept.TabIndex = 36;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS_411.Properties.Resources.LiabilitySS;
            this.pictureBox1.Location = new System.Drawing.Point(16, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMemTypeDisplay
            // 
            this.lblMemTypeDisplay.AutoSize = true;
            this.lblMemTypeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemTypeDisplay.Location = new System.Drawing.Point(964, 143);
            this.lblMemTypeDisplay.Name = "lblMemTypeDisplay";
            this.lblMemTypeDisplay.Size = new System.Drawing.Size(70, 25);
            this.lblMemTypeDisplay.TabIndex = 47;
            this.lblMemTypeDisplay.Text = "label1";
            this.lblMemTypeDisplay.Visible = false;
            // 
            // lblCostDisplay
            // 
            this.lblCostDisplay.AutoSize = true;
            this.lblCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostDisplay.Location = new System.Drawing.Point(836, 177);
            this.lblCostDisplay.Name = "lblCostDisplay";
            this.lblCostDisplay.Size = new System.Drawing.Size(70, 25);
            this.lblCostDisplay.TabIndex = 48;
            this.lblCostDisplay.Text = "label2";
            this.lblCostDisplay.Visible = false;
            // 
            // LiabilityWaiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 727);
            this.Controls.Add(this.lblCostDisplay);
            this.Controls.Add(this.lblMemTypeDisplay);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.rdoCheck);
            this.Controls.Add(this.rdoCash);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LiabilityWaiver";
            this.Text = "Liability Waiver";
            this.Load += new System.EventHandler(this.LiabilityWaiver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.RadioButton rdoCheck;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMemTypeDisplay;
        private System.Windows.Forms.Label lblCostDisplay;
    }
}