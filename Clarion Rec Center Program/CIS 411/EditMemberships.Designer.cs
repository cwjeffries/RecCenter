namespace CIS_411
{
    partial class EditMemberships
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboMembershipSelect = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblexpType = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkRestricted = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkDayPass = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboExpType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Membership Type:";
            // 
            // cboMembershipSelect
            // 
            this.cboMembershipSelect.FormattingEnabled = true;
            this.cboMembershipSelect.Location = new System.Drawing.Point(9, 24);
            this.cboMembershipSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cboMembershipSelect.Name = "cboMembershipSelect";
            this.cboMembershipSelect.Size = new System.Drawing.Size(362, 21);
            this.cboMembershipSelect.TabIndex = 1;
            this.cboMembershipSelect.SelectedIndexChanged += new System.EventHandler(this.cboMembershipSelect_SelectedIndexChanged_1);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(9, 56);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(83, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration (Days):";
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(9, 72);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(107, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(152, 56);
            this.lblExp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(56, 13);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Expiration:";
            // 
            // dtpExp
            // 
            this.dtpExp.Enabled = false;
            this.dtpExp.Location = new System.Drawing.Point(154, 72);
            this.dtpExp.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(218, 20);
            this.dtpExp.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(9, 114);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(9, 130);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(96, 20);
            this.txtCost.TabIndex = 7;
            // 
            // lblexpType
            // 
            this.lblexpType.AutoSize = true;
            this.lblexpType.Location = new System.Drawing.Point(138, 114);
            this.lblexpType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexpType.Name = "lblexpType";
            this.lblexpType.Size = new System.Drawing.Size(83, 13);
            this.lblexpType.TabIndex = 8;
            this.lblexpType.Text = "Expiration Type:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(9, 171);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(9, 188);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(393, 45);
            this.txtDescription.TabIndex = 11;
            // 
            // chkRestricted
            // 
            this.chkRestricted.AutoSize = true;
            this.chkRestricted.Enabled = false;
            this.chkRestricted.Location = new System.Drawing.Point(303, 110);
            this.chkRestricted.Margin = new System.Windows.Forms.Padding(2);
            this.chkRestricted.Name = "chkRestricted";
            this.chkRestricted.Size = new System.Drawing.Size(103, 17);
            this.chkRestricted.TabIndex = 12;
            this.chkRestricted.Text = "Restricted (Y/N)";
            this.chkRestricted.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(303, 130);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(85, 17);
            this.chkActive.TabIndex = 13;
            this.chkActive.Text = "Active (Y/N)";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkDayPass
            // 
            this.chkDayPass.AutoSize = true;
            this.chkDayPass.Enabled = false;
            this.chkDayPass.Location = new System.Drawing.Point(303, 152);
            this.chkDayPass.Margin = new System.Windows.Forms.Padding(2);
            this.chkDayPass.Name = "chkDayPass";
            this.chkDayPass.Size = new System.Drawing.Size(100, 17);
            this.chkDayPass.TabIndex = 14;
            this.chkDayPass.Text = "Day Pass (Y/N)";
            this.chkDayPass.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(79, 236);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 27);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 236);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add New Membership";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 270);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 270);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cboExpType
            // 
            this.cboExpType.Enabled = false;
            this.cboExpType.FormattingEnabled = true;
            this.cboExpType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboExpType.Items.AddRange(new object[] {
            "Duration",
            "Date"});
            this.cboExpType.Location = new System.Drawing.Point(141, 130);
            this.cboExpType.Name = "cboExpType";
            this.cboExpType.Size = new System.Drawing.Size(81, 21);
            this.cboExpType.TabIndex = 19;
            // 
            // EditMemberships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 306);
            this.Controls.Add(this.cboExpType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkDayPass);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkRestricted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblexpType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.dtpExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.cboMembershipSelect);
            this.Controls.Add(this.label1);
            this.Name = "EditMemberships";
            this.Text = "Membership Editing and Adding";
            this.Load += new System.EventHandler(this.EditMemberships_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMembershipSelect;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblexpType;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkRestricted;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkDayPass;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboExpType;
    }
}