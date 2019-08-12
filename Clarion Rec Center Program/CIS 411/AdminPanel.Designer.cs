namespace CIS_411
{
    partial class AdminPanel
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPhoneClear = new System.Windows.Forms.Button();
            this.btnPhoneSearch = new System.Windows.Forms.Button();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditPrivileges = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboMembType = new System.Windows.Forms.ComboBox();
            this.cboStudWorker = new System.Windows.Forms.ComboBox();
            this.chkFilters = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.btnLaunchReports = new System.Windows.Forms.Button();
            this.dgvAdminReport = new System.Windows.Forms.DataGridView();
            this.TransactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voidStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedSync = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmSync = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditWorkers = new System.Windows.Forms.Button();
            this.btnEditMembership = new System.Windows.Forms.Button();
            this.tRANSACTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblMemb = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(1120, 541);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 52);
            this.btnExport.TabIndex = 66;
            this.btnExport.Text = "Export Current";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPhoneClear
            // 
            this.btnPhoneClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneClear.Location = new System.Drawing.Point(908, 609);
            this.btnPhoneClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhoneClear.Name = "btnPhoneClear";
            this.btnPhoneClear.Size = new System.Drawing.Size(189, 20);
            this.btnPhoneClear.TabIndex = 65;
            this.btnPhoneClear.Text = "Clear Search";
            this.btnPhoneClear.UseVisualStyleBackColor = true;
            this.btnPhoneClear.Click += new System.EventHandler(this.btnPhoneClear_Click_1);
            // 
            // btnPhoneSearch
            // 
            this.btnPhoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneSearch.Location = new System.Drawing.Point(1018, 584);
            this.btnPhoneSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhoneSearch.Name = "btnPhoneSearch";
            this.btnPhoneSearch.Size = new System.Drawing.Size(79, 20);
            this.btnPhoneSearch.TabIndex = 64;
            this.btnPhoneSearch.Text = "Search";
            this.btnPhoneSearch.UseVisualStyleBackColor = true;
            this.btnPhoneSearch.Click += new System.EventHandler(this.btnPhoneSearch_Click);
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(908, 584);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneSearch.TabIndex = 63;
            this.txtPhoneSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(900, 557);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Search Phone Number:";
            // 
            // btnEditPrivileges
            // 
            this.btnEditPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrivileges.Location = new System.Drawing.Point(146, 490);
            this.btnEditPrivileges.Name = "btnEditPrivileges";
            this.btnEditPrivileges.Size = new System.Drawing.Size(129, 53);
            this.btnEditPrivileges.TabIndex = 61;
            this.btnEditPrivileges.Text = "Edit Privileges";
            this.btnEditPrivileges.UseVisualStyleBackColor = true;
            this.btnEditPrivileges.Click += new System.EventHandler(this.btnEditPrivileges_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1179, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(908, 531);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(189, 20);
            this.btnClearSearch.TabIndex = 59;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // chkFilterDate
            // 
            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkFilterDate.Location = new System.Drawing.Point(691, 477);
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.Size = new System.Drawing.Size(124, 24);
            this.chkFilterDate.TabIndex = 58;
            this.chkFilterDate.Text = "Filter By Date";
            this.chkFilterDate.UseVisualStyleBackColor = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.chkFilterDate_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1018, 506);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 20);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(909, 506);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(900, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Search Name:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1120, 478);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 53);
            this.btnPrint.TabIndex = 54;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilter.Location = new System.Drawing.Point(281, 475);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(56, 20);
            this.lblFilter.TabIndex = 53;
            this.lblFilter.Text = "Filters:";
            // 
            // cboMembType
            // 
            this.cboMembType.FormattingEnabled = true;
            this.cboMembType.Items.AddRange(new object[] {
            "View All"});
            this.cboMembType.Location = new System.Drawing.Point(487, 584);
            this.cboMembType.Name = "cboMembType";
            this.cboMembType.Size = new System.Drawing.Size(188, 21);
            this.cboMembType.TabIndex = 52;
            this.cboMembType.Text = "Membership Type";
            this.cboMembType.SelectedIndexChanged += new System.EventHandler(this.cboMembType_SelectedIndexChanged);
            // 
            // cboStudWorker
            // 
            this.cboStudWorker.FormattingEnabled = true;
            this.cboStudWorker.Items.AddRange(new object[] {
            "View All"});
            this.cboStudWorker.Location = new System.Drawing.Point(483, 508);
            this.cboStudWorker.Name = "cboStudWorker";
            this.cboStudWorker.Size = new System.Drawing.Size(188, 21);
            this.cboStudWorker.TabIndex = 51;
            this.cboStudWorker.Text = "Student Worker";
            this.cboStudWorker.SelectedIndexChanged += new System.EventHandler(this.cboStudWorker_SelectedIndexChanged);
            // 
            // chkFilters
            // 
            this.chkFilters.FormattingEnabled = true;
            this.chkFilters.Items.AddRange(new object[] {
            "New Membership",
            "Existing Membership",
            "Cash Payment",
            "Check Payment",
            "Expired",
            "Not Expired",
            "Not Synced With CBoard"});
            this.chkFilters.Location = new System.Drawing.Point(285, 502);
            this.chkFilters.Name = "chkFilters";
            this.chkFilters.Size = new System.Drawing.Size(188, 109);
            this.chkFilters.TabIndex = 50;
            this.chkFilters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkFilters_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(687, 557);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(687, 504);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Start Date:";
            // 
            // dtEnd
            // 
            this.dtEnd.Enabled = false;
            this.dtEnd.Location = new System.Drawing.Point(698, 582);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(188, 20);
            this.dtEnd.TabIndex = 47;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(698, 529);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(188, 20);
            this.dtStart.TabIndex = 46;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // btnLaunchReports
            // 
            this.btnLaunchReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchReports.Location = new System.Drawing.Point(146, 557);
            this.btnLaunchReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaunchReports.Name = "btnLaunchReports";
            this.btnLaunchReports.Size = new System.Drawing.Size(129, 53);
            this.btnLaunchReports.TabIndex = 45;
            this.btnLaunchReports.Text = "Daily Report";
            this.btnLaunchReports.UseVisualStyleBackColor = true;
            this.btnLaunchReports.Click += new System.EventHandler(this.btnLaunchReports_Click);
            // 
            // dgvAdminReport
            // 
            this.dgvAdminReport.AllowUserToAddRows = false;
            this.dgvAdminReport.AllowUserToDeleteRows = false;
            this.dgvAdminReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactID,
            this.Date,
            this.CustName,
            this.CustPhone,
            this.MembType,
            this.ExpirationDate,
            this.PayType,
            this.Cost,
            this.CardNum,
            this.NewCust,
            this.WorkerName,
            this.voidStat,
            this.NeedSync,
            this.ConfirmSync});
            this.dgvAdminReport.Location = new System.Drawing.Point(4, 7);
            this.dgvAdminReport.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdminReport.Name = "dgvAdminReport";
            this.dgvAdminReport.RowTemplate.Height = 31;
            this.dgvAdminReport.Size = new System.Drawing.Size(1250, 462);
            this.dgvAdminReport.TabIndex = 44;
            this.dgvAdminReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminReport_CellContentClick_1);
            // 
            // TransactID
            // 
            this.TransactID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TransactID.HeaderText = "ID";
            this.TransactID.Name = "TransactID";
            this.TransactID.ReadOnly = true;
            this.TransactID.Width = 43;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // CustPhone
            // 
            this.CustPhone.HeaderText = "Customer Phone";
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.ReadOnly = true;
            // 
            // MembType
            // 
            this.MembType.HeaderText = "Membership Type";
            this.MembType.Name = "MembType";
            this.MembType.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // PayType
            // 
            this.PayType.HeaderText = "Payment Type";
            this.PayType.Name = "PayType";
            this.PayType.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 53;
            // 
            // CardNum
            // 
            this.CardNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CardNum.HeaderText = "Card Number";
            this.CardNum.Name = "CardNum";
            this.CardNum.ReadOnly = true;
            this.CardNum.Width = 87;
            // 
            // NewCust
            // 
            this.NewCust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NewCust.HeaderText = "New Customer";
            this.NewCust.Name = "NewCust";
            this.NewCust.ReadOnly = true;
            this.NewCust.Width = 93;
            // 
            // WorkerName
            // 
            this.WorkerName.HeaderText = "Worker Name";
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.ReadOnly = true;
            // 
            // voidStat
            // 
            this.voidStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.voidStat.HeaderText = "Void";
            this.voidStat.Name = "voidStat";
            this.voidStat.ReadOnly = true;
            this.voidStat.Width = 53;
            // 
            // NeedSync
            // 
            this.NeedSync.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NeedSync.HeaderText = "Needs Sync";
            this.NeedSync.Name = "NeedSync";
            this.NeedSync.ReadOnly = true;
            this.NeedSync.Width = 83;
            // 
            // ConfirmSync
            // 
            this.ConfirmSync.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ConfirmSync.HeaderText = "Confirm Sync";
            this.ConfirmSync.Name = "ConfirmSync";
            this.ConfirmSync.Width = 68;
            // 
            // btnEditWorkers
            // 
            this.btnEditWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWorkers.Location = new System.Drawing.Point(4, 557);
            this.btnEditWorkers.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditWorkers.Name = "btnEditWorkers";
            this.btnEditWorkers.Size = new System.Drawing.Size(137, 53);
            this.btnEditWorkers.TabIndex = 43;
            this.btnEditWorkers.Text = "Edit/Add Workers";
            this.btnEditWorkers.UseVisualStyleBackColor = true;
            this.btnEditWorkers.Click += new System.EventHandler(this.btnEditWorkers_Click);
            // 
            // btnEditMembership
            // 
            this.btnEditMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMembership.Location = new System.Drawing.Point(4, 490);
            this.btnEditMembership.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMembership.Name = "btnEditMembership";
            this.btnEditMembership.Size = new System.Drawing.Size(137, 53);
            this.btnEditMembership.TabIndex = 42;
            this.btnEditMembership.Text = "Edit/Add Memberships";
            this.btnEditMembership.UseVisualStyleBackColor = true;
            this.btnEditMembership.Click += new System.EventHandler(this.btnEditMembership_Click);
            // 
            // tRANSACTIONBindingSource
            // 
            this.tRANSACTIONBindingSource.DataMember = "TRANSACTION";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWorker.Location = new System.Drawing.Point(479, 481);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(183, 20);
            this.lblWorker.TabIndex = 67;
            this.lblWorker.Text = "Select a Student Worker";
            // 
            // lblMemb
            // 
            this.lblMemb.AutoSize = true;
            this.lblMemb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMemb.Location = new System.Drawing.Point(479, 557);
            this.lblMemb.Name = "lblMemb";
            this.lblMemb.Size = new System.Drawing.Size(196, 20);
            this.lblMemb.TabIndex = 68;
            this.lblMemb.Text = "Select a Membership Type";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 640);
            this.Controls.Add(this.lblMemb);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPhoneClear);
            this.Controls.Add(this.btnPhoneSearch);
            this.Controls.Add(this.txtPhoneSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditPrivileges);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.chkFilterDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboMembType);
            this.Controls.Add(this.cboStudWorker);
            this.Controls.Add(this.chkFilters);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btnLaunchReports);
            this.Controls.Add(this.dgvAdminReport);
            this.Controls.Add(this.btnEditWorkers);
            this.Controls.Add(this.btnEditMembership);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPhoneClear;
        private System.Windows.Forms.Button btnPhoneSearch;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditPrivileges;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboMembType;
        private System.Windows.Forms.ComboBox cboStudWorker;
        private System.Windows.Forms.CheckedListBox chkFilters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btnLaunchReports;
        private System.Windows.Forms.DataGridView dgvAdminReport;
        private System.Windows.Forms.Button btnEditWorkers;
        private System.Windows.Forms.Button btnEditMembership;
        private System.Windows.Forms.BindingSource tRANSACTIONBindingSource;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblMemb;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn voidStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedSync;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ConfirmSync;
    }
}