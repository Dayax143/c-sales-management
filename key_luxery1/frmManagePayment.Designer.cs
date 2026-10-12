namespace key_luxery1
{
	partial class frmManagePayment
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
			this.lblInvoiceNo = new System.Windows.Forms.Label();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.lblTotalDue = new System.Windows.Forms.Label();
			this.txtTotalDue = new System.Windows.Forms.TextBox();
			this.lblAmountPaid = new System.Windows.Forms.Label();
			this.txtAmountPaid = new System.Windows.Forms.TextBox();
			this.lblPaymentMethod = new System.Windows.Forms.Label();
			this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
			this.lblPaymentDate = new System.Windows.Forms.Label();
			this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
			this.btnSavePayment = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.grpPaymentDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(25, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(309, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Payment Processing";
			// 
			// grpPaymentDetails
			// 
			this.grpPaymentDetails.Controls.Add(this.lblInvoiceNo);
			this.grpPaymentDetails.Controls.Add(this.txtInvoiceNo);
			this.grpPaymentDetails.Controls.Add(this.lblTotalDue);
			this.grpPaymentDetails.Controls.Add(this.txtTotalDue);
			this.grpPaymentDetails.Controls.Add(this.lblAmountPaid);
			this.grpPaymentDetails.Controls.Add(this.txtAmountPaid);
			this.grpPaymentDetails.Controls.Add(this.lblPaymentMethod);
			this.grpPaymentDetails.Controls.Add(this.cmbPaymentMethod);
			this.grpPaymentDetails.Controls.Add(this.lblPaymentDate);
			this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
			this.grpPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpPaymentDetails.Location = new System.Drawing.Point(25, 75);
			this.grpPaymentDetails.Name = "grpPaymentDetails";
			this.grpPaymentDetails.Size = new System.Drawing.Size(430, 260);
			this.grpPaymentDetails.TabIndex = 1;
			this.grpPaymentDetails.TabStop = false;
			this.grpPaymentDetails.Text = "Payment Information";
			// 
			// lblInvoiceNo
			// 
			this.lblInvoiceNo.AutoSize = true;
			this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblInvoiceNo.Location = new System.Drawing.Point(20, 38);
			this.lblInvoiceNo.Name = "lblInvoiceNo";
			this.lblInvoiceNo.Size = new System.Drawing.Size(93, 21);
			this.lblInvoiceNo.TabIndex = 0;
			this.lblInvoiceNo.Text = "Invoice No :";
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.Enabled = false;
			this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtInvoiceNo.Location = new System.Drawing.Point(155, 35);
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.Size = new System.Drawing.Size(240, 29);
			this.txtInvoiceNo.TabIndex = 0;
			// 
			// lblTotalDue
			// 
			this.lblTotalDue.AutoSize = true;
			this.lblTotalDue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblTotalDue.Location = new System.Drawing.Point(20, 78);
			this.lblTotalDue.Name = "lblTotalDue";
			this.lblTotalDue.Size = new System.Drawing.Size(89, 21);
			this.lblTotalDue.TabIndex = 0;
			this.lblTotalDue.Text = "Total Due :";
			// 
			// txtTotalDue
			// 
			this.txtTotalDue.Enabled = false;
			this.txtTotalDue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtTotalDue.Location = new System.Drawing.Point(155, 75);
			this.txtTotalDue.Name = "txtTotalDue";
			this.txtTotalDue.Size = new System.Drawing.Size(240, 29);
			this.txtTotalDue.TabIndex = 1;
			// 
			// lblAmountPaid
			// 
			this.lblAmountPaid.AutoSize = true;
			this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblAmountPaid.Location = new System.Drawing.Point(20, 118);
			this.lblAmountPaid.Name = "lblAmountPaid";
			this.lblAmountPaid.Size = new System.Drawing.Size(113, 21);
			this.lblAmountPaid.TabIndex = 0;
			this.lblAmountPaid.Text = "Amount Paid :";
			// 
			// txtAmountPaid
			// 
			this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtAmountPaid.Location = new System.Drawing.Point(155, 115);
			this.txtAmountPaid.Name = "txtAmountPaid";
			this.txtAmountPaid.Size = new System.Drawing.Size(240, 29);
			this.txtAmountPaid.TabIndex = 2;
			// 
			// lblPaymentMethod
			// 
			this.lblPaymentMethod.AutoSize = true;
			this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblPaymentMethod.Location = new System.Drawing.Point(20, 158);
			this.lblPaymentMethod.Name = "lblPaymentMethod";
			this.lblPaymentMethod.Size = new System.Drawing.Size(139, 21);
			this.lblPaymentMethod.TabIndex = 0;
			this.lblPaymentMethod.Text = "Payment Method :";
			// 
			// cmbPaymentMethod
			// 
			this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbPaymentMethod.FormattingEnabled = true;
			this.cmbPaymentMethod.Items.AddRange(new object[] {
			"Cash",
			"Credit Card",
			"Bank Transfer",
			"Mobile Money"});
			this.cmbPaymentMethod.Location = new System.Drawing.Point(155, 155);
			this.cmbPaymentMethod.Name = "cmbPaymentMethod";
			this.cmbPaymentMethod.Size = new System.Drawing.Size(240, 29);
			this.cmbPaymentMethod.TabIndex = 3;
			// 
			// lblPaymentDate
			// 
			this.lblPaymentDate.AutoSize = true;
			this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblPaymentDate.Location = new System.Drawing.Point(20, 198);
			this.lblPaymentDate.Name = "lblPaymentDate";
			this.lblPaymentDate.Size = new System.Drawing.Size(119, 21);
			this.lblPaymentDate.TabIndex = 0;
			this.lblPaymentDate.Text = "Payment Date :";
			// 
			// dtpPaymentDate
			// 
			this.dtpPaymentDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPaymentDate.Location = new System.Drawing.Point(155, 195);
			this.dtpPaymentDate.Name = "dtpPaymentDate";
			this.dtpPaymentDate.Size = new System.Drawing.Size(240, 29);
			this.dtpPaymentDate.TabIndex = 4;
			// 
			// btnSavePayment
			// 
			this.btnSavePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSavePayment.FlatAppearance.BorderSize = 0;
			this.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSavePayment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnSavePayment.ForeColor = System.Drawing.Color.White;
			this.btnSavePayment.Location = new System.Drawing.Point(220, 350);
			this.btnSavePayment.Name = "btnSavePayment";
			this.btnSavePayment.Size = new System.Drawing.Size(115, 38);
			this.btnSavePayment.TabIndex = 2;
			this.btnSavePayment.Text = "Save Payment";
			this.btnSavePayment.UseVisualStyleBackColor = false;
			this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(345, 350);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 38);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmManagePayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(482, 415);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSavePayment);
			this.Controls.Add(this.grpPaymentDetails);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManagePayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Payment Processing";
			this.grpPaymentDetails.ResumeLayout(false);
			this.grpPaymentDetails.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpPaymentDetails;
		private System.Windows.Forms.Label lblInvoiceNo;
		public System.Windows.Forms.TextBox txtInvoiceNo;
		private System.Windows.Forms.Label lblTotalDue;
		public System.Windows.Forms.TextBox txtTotalDue;
		private System.Windows.Forms.Label lblAmountPaid;
		public System.Windows.Forms.TextBox txtAmountPaid;
		private System.Windows.Forms.Label lblPaymentMethod;
		public System.Windows.Forms.ComboBox cmbPaymentMethod;
		private System.Windows.Forms.Label lblPaymentDate;
		public System.Windows.Forms.DateTimePicker dtpPaymentDate;
		public System.Windows.Forms.Button btnSavePayment;
		public System.Windows.Forms.Button btnClose;
	}
}