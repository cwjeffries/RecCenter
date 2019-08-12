namespace CIS_411
{
    partial class ReportsForm
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
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedSync = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tRANSACTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(1077, -61);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(181, 20);
            this.lblCurrentDateTime.TabIndex = 23;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnExport);
            this.grpControls.Controls.Add(this.label8);
            this.grpControls.Controls.Add(this.label7);
            this.grpControls.Controls.Add(this.dtEnd);
            this.grpControls.Controls.Add(this.dtStart);
            this.grpControls.Controls.Add(this.btnPrint);
            this.grpControls.Controls.Add(this.btnClose);
            this.grpControls.Location = new System.Drawing.Point(1113, 39);
            this.grpControls.Margin = new System.Windows.Forms.Padding(2);
            this.grpControls.Name = "grpControls";
            this.grpControls.Padding = new System.Windows.Forms.Padding(2);
            this.grpControls.Size = new System.Drawing.Size(197, 583);
            this.grpControls.TabIndex = 22;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(27, 512);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 34);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Start Date:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(4, 73);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(184, 20);
            this.dtEnd.TabIndex = 21;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(4, 37);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(184, 20);
            this.dtStart.TabIndex = 20;
            this.dtStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(27, 470);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 38);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(104, 550);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.AllowUserToAddRows = false;
            this.dgvDailyReport.AllowUserToDeleteRows = false;
            this.dgvDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDailyReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.CustName,
            this.CustPhone,
            this.MembType,
            this.PayType,
            this.Cost,
            this.CardNum,
            this.NewCust,
            this.NeedSync,
            this.WorkerName,
            this.isVoid,
            this.btnEditRow});
            this.dgvDailyReport.Location = new System.Drawing.Point(11, 39);
            this.dgvDailyReport.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.ReadOnly = true;
            this.dgvDailyReport.RowHeadersVisible = false;
            this.dgvDailyReport.RowTemplate.Height = 24;
            this.dgvDailyReport.Size = new System.Drawing.Size(1084, 584);
            this.dgvDailyReport.TabIndex = 21;
            this.dgvDailyReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailyReport_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 21;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 55;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Width = 98;
            // 
            // CustPhone
            // 
            this.CustPhone.HeaderText = "Customer Phone";
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.ReadOnly = true;
            this.CustPhone.Width = 101;
            // 
            // MembType
            // 
            this.MembType.HeaderText = "Membership Type";
            this.MembType.Name = "MembType";
            this.MembType.ReadOnly = true;
            this.MembType.Width = 106;
            // 
            // PayType
            // 
            this.PayType.HeaderText = "Payment Type";
            this.PayType.Name = "PayType";
            this.PayType.ReadOnly = true;
            this.PayType.Width = 92;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 53;
            // 
            // CardNum
            // 
            this.CardNum.HeaderText = "Card Number";
            this.CardNum.Name = "CardNum";
            this.CardNum.ReadOnly = true;
            this.CardNum.Width = 87;
            // 
            // NewCust
            // 
            this.NewCust.HeaderText = "New Customer";
            this.NewCust.Name = "NewCust";
            this.NewCust.ReadOnly = true;
            this.NewCust.Width = 93;
            // 
            // NeedSync
            // 
            this.NeedSync.HeaderText = "Needs Sync";
            this.NeedSync.Name = "NeedSync";
            this.NeedSync.ReadOnly = true;
            this.NeedSync.Width = 83;
            // 
            // WorkerName
            // 
            this.WorkerName.HeaderText = "Worker Name";
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.ReadOnly = true;
            this.WorkerName.Width = 90;
            // 
            // isVoid
            // 
            this.isVoid.HeaderText = "Voided:";
            this.isVoid.Name = "isVoid";
            this.isVoid.ReadOnly = true;
            this.isVoid.Width = 68;
            // 
            // btnEditRow
            // 
            this.btnEditRow.HeaderText = "Edit";
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.ReadOnly = true;
            this.btnEditRow.Text = "Edit Row";
            this.btnEditRow.Width = 31;
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUser.Location = new System.Drawing.Point(-12, -62);
            this.lblActiveUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(249, 20);
            this.lblActiveUser.TabIndex = 20;
            this.lblActiveUser.Text = "Displays user that is logged in";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1116, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(181, 20);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(7, 9);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(249, 20);
            this.labelUser.TabIndex = 24;
            this.labelUser.Text = "Displays user that is logged in";
            // 
            // tRANSACTIONBindingSource
            // 
            this.tRANSACTIONBindingSource.DataMember = "TRANSACTION";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 647);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.dgvDailyReport);
            this.Controls.Add(this.lblActiveUser);
            this.Name = "ReportsForm";
            this.Text = "Daily Transaction Report";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDailyReport;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.BindingSource tRANSACTIONBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn isVoid;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditRow;
    }
}