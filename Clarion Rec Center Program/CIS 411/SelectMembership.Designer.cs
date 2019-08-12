namespace CIS_411
{
    partial class SelectMembership
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMembOptions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoExisting = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNewMember = new System.Windows.Forms.RadioButton();
            this.dgvMemSelect = new System.Windows.Forms.DataGridView();
            this.Membership_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mEMBERSHIPTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblRecCenter = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpMembOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Select Membership:";
            // 
            // grpMembOptions
            // 
            this.grpMembOptions.Controls.Add(this.label4);
            this.grpMembOptions.Controls.Add(this.lblCost);
            this.grpMembOptions.Controls.Add(this.btnPurchase);
            this.grpMembOptions.Controls.Add(this.txtCardNum);
            this.grpMembOptions.Controls.Add(this.label2);
            this.grpMembOptions.Controls.Add(this.rdoExisting);
            this.grpMembOptions.Controls.Add(this.label1);
            this.grpMembOptions.Controls.Add(this.rdoNewMember);
            this.grpMembOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembOptions.Location = new System.Drawing.Point(520, 196);
            this.grpMembOptions.Name = "grpMembOptions";
            this.grpMembOptions.Size = new System.Drawing.Size(251, 324);
            this.grpMembOptions.TabIndex = 36;
            this.grpMembOptions.TabStop = false;
            this.grpMembOptions.Text = "Membership Options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "what is your card number?";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(5, 31);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(57, 24);
            this.lblCost.TabIndex = 39;
            this.lblCost.Text = "Cost: ";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Enabled = false;
            this.btnPurchase.Location = new System.Drawing.Point(76, 280);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(167, 38);
            this.btnPurchase.TabIndex = 38;
            this.btnPurchase.Text = "Purchase Membership";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Enabled = false;
            this.txtCardNum.Location = new System.Drawing.Point(23, 212);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(100, 24);
            this.txtCardNum.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "If you are an existing member,";
            // 
            // rdoExisting
            // 
            this.rdoExisting.AutoSize = true;
            this.rdoExisting.Location = new System.Drawing.Point(23, 106);
            this.rdoExisting.Name = "rdoExisting";
            this.rdoExisting.Size = new System.Drawing.Size(136, 22);
            this.rdoExisting.TabIndex = 35;
            this.rdoExisting.TabStop = true;
            this.rdoExisting.Text = "Existing Member";
            this.rdoExisting.UseVisualStyleBackColor = true;
            this.rdoExisting.CheckedChanged += new System.EventHandler(this.rdoExisting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Are You An Existing Member?";
            // 
            // rdoNewMember
            // 
            this.rdoNewMember.AutoSize = true;
            this.rdoNewMember.Location = new System.Drawing.Point(23, 128);
            this.rdoNewMember.Name = "rdoNewMember";
            this.rdoNewMember.Size = new System.Drawing.Size(115, 22);
            this.rdoNewMember.TabIndex = 33;
            this.rdoNewMember.TabStop = true;
            this.rdoNewMember.Text = "New Member";
            this.rdoNewMember.UseVisualStyleBackColor = true;
            this.rdoNewMember.CheckedChanged += new System.EventHandler(this.rdoNewMember_CheckedChanged);
            // 
            // dgvMemSelect
            // 
            this.dgvMemSelect.AllowUserToAddRows = false;
            this.dgvMemSelect.AllowUserToDeleteRows = false;
            this.dgvMemSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemSelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMemSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Membership_ID,
            this.DESCRIPTION,
            this.COST,
            this.btnChoice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemSelect.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemSelect.Location = new System.Drawing.Point(10, 196);
            this.dgvMemSelect.Name = "dgvMemSelect";
            this.dgvMemSelect.ReadOnly = true;
            this.dgvMemSelect.RowHeadersVisible = false;
            this.dgvMemSelect.Size = new System.Drawing.Size(505, 324);
            this.dgvMemSelect.TabIndex = 35;
            this.dgvMemSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Membership_ID
            // 
            this.Membership_ID.DataPropertyName = "MEMBERSHIP_ID";
            this.Membership_ID.HeaderText = "Membership ID";
            this.Membership_ID.Name = "Membership_ID";
            this.Membership_ID.ReadOnly = true;
            this.Membership_ID.Visible = false;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.FillWeight = 213.198F;
            this.DESCRIPTION.HeaderText = "Membership Type";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // COST
            // 
            this.COST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.COST.FillWeight = 43.40102F;
            this.COST.HeaderText = "Cost";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            this.COST.Width = 53;
            // 
            // btnChoice
            // 
            this.btnChoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnChoice.FillWeight = 43.40102F;
            this.btnChoice.HeaderText = "Choose";
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.ReadOnly = true;
            this.btnChoice.Width = 49;
            // 
            // mEMBERSHIPTYPEBindingSource
            // 
            this.mEMBERSHIPTYPEBindingSource.DataMember = "MEMBERSHIP_TYPE";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(601, 9);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(181, 20);
            this.lblCurrentDateTime.TabIndex = 34;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // btnStartOver
            // 
            this.btnStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.Location = new System.Drawing.Point(11, 72);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(119, 45);
            this.btnStartOver.TabIndex = 33;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(456, 87);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(124, 40);
            this.lblSignIn.TabIndex = 31;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblRecCenter
            // 
            this.lblRecCenter.AutoSize = true;
            this.lblRecCenter.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCenter.Location = new System.Drawing.Point(429, 51);
            this.lblRecCenter.Name = "lblRecCenter";
            this.lblRecCenter.Size = new System.Drawing.Size(187, 40);
            this.lblRecCenter.TabIndex = 30;
            this.lblRecCenter.Text = "Rec Center";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::CIS_411.Properties.Resources.ClarionLogo;
            this.picBoxLogo.Location = new System.Drawing.Point(177, 51);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(228, 86);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 32;
            this.picBoxLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SelectMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpMembOptions);
            this.Controls.Add(this.dgvMemSelect);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblRecCenter);
            this.Name = "SelectMembership";
            this.Text = "Membership Selection";
            this.Load += new System.EventHandler(this.SelectMembership_Load);
            this.grpMembOptions.ResumeLayout(false);
            this.grpMembOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMembOptions;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoExisting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNewMember;
        private System.Windows.Forms.DataGridView dgvMemSelect;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblRecCenter;
        private System.Windows.Forms.Timer timer1;
        private ClarionRecCenterDataSet clarionRecCenterDataSet;
        private System.Windows.Forms.BindingSource mEMBERSHIPTYPEBindingSource;
        private ClarionRecCenterDataSetTableAdapters.MEMBERSHIP_TYPETableAdapter mEMBERSHIP_TYPETableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membership_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewButtonColumn btnChoice;
    }
}