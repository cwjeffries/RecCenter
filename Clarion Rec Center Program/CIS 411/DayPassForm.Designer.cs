namespace CIS_411
{
    partial class DayPassForm
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
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblRecCenter = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvMemSelect = new System.Windows.Forms.DataGridView();
            this.Membership_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoice = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(427, 7);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(181, 20);
            this.lblCurrentDateTime.TabIndex = 27;
            this.lblCurrentDateTime.Text = "MM/dd/yyyy HH:mm:ss tt";
            // 
            // btnStartOver
            // 
            this.btnStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.Location = new System.Drawing.Point(10, 408);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(115, 45);
            this.btnStartOver.TabIndex = 26;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(370, 89);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(124, 40);
            this.lblSignIn.TabIndex = 22;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblRecCenter
            // 
            this.lblRecCenter.AutoSize = true;
            this.lblRecCenter.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCenter.Location = new System.Drawing.Point(345, 53);
            this.lblRecCenter.Name = "lblRecCenter";
            this.lblRecCenter.Size = new System.Drawing.Size(187, 40);
            this.lblRecCenter.TabIndex = 21;
            this.lblRecCenter.Text = "Rec Center";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::CIS_411.Properties.Resources.ClarionLogo;
            this.picBoxLogo.Location = new System.Drawing.Point(97, 53);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(228, 86);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 23;
            this.picBoxLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.dgvMemSelect.Location = new System.Drawing.Point(130, 167);
            this.dgvMemSelect.Name = "dgvMemSelect";
            this.dgvMemSelect.ReadOnly = true;
            this.dgvMemSelect.RowHeadersVisible = false;
            this.dgvMemSelect.Size = new System.Drawing.Size(470, 286);
            this.dgvMemSelect.TabIndex = 36;
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
            this.DESCRIPTION.HeaderText = "Membership Type";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // COST
            // 
            this.COST.HeaderText = "Cost";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            // 
            // btnChoice
            // 
            this.btnChoice.HeaderText = "Choose";
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.ReadOnly = true;
            // 
            // DayPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 465);
            this.Controls.Add(this.dgvMemSelect);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblRecCenter);
            this.Name = "DayPassForm";
            this.Text = "Day Pass Selection";
            this.Load += new System.EventHandler(this.DayPassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblRecCenter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvMemSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membership_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewButtonColumn btnChoice;
    }
}