namespace key_luxery1
{
	partial class frmReport
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
			this.lblHeaderTitle = new System.Windows.Forms.Label();
			this.lblReportType = new System.Windows.Forms.Label();
			this.cmbReportType = new System.Windows.Forms.ComboBox();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchKeyword = new System.Windows.Forms.TextBox();
			this.lblSearchKeyword = new System.Windows.Forms.Label();
			this.dgvReports = new System.Windows.Forms.DataGridView();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.pnlSummary = new System.Windows.Forms.Panel();
			this.lblTotalTransactionsVal = new System.Windows.Forms.Label();
			this.lblTotalTransactionsTitle = new System.Windows.Forms.Label();
			this.lblTotalProfitVal = new System.Windows.Forms.Label();
			this.lblTotalProfitTitle = new System.Windows.Forms.Label();
			this.lblTotalSalesVal = new System.Windows.Forms.Label();
			this.lblTotalSalesTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
			this.pnlSummary.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHeaderTitle
			// 
			this.lblHeaderTitle.AutoSize = true;
			this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblHeaderTitle.Location = new System.Drawing.Point(25, 20);
			this.lblHeaderTitle.Name = "lblHeaderTitle";
			this.lblHeaderTitle.Size = new System.Drawing.Size(360, 37);
			this.lblHeaderTitle.TabIndex = 0;
			this.lblHeaderTitle.Text = "Advanced Business Reports";
			// 
			// lblReportType
			// 
			this.lblReportType.AutoSize = true;
			this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblReportType.Location = new System.Drawing.Point(25, 75);
			this.lblReportType.Name = "lblReportType";
			this.lblReportType.Size = new System.Drawing.Size(103, 21);
			this.lblReportType.TabIndex = 1;
			this.lblReportType.Text = "Report Type:";
			// 
			// cmbReportType
			// 
			this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.Items.AddRange(new object[] {
			"Sales Report",
			"Payment Report",
			"Product Stock Report",
			"Profit Summary",
			"Customer Purchase History",
			"Daily Sales Summary",
			"Low Stock Inventory Report"});
			this.cmbReportType.Location = new System.Drawing.Point(25, 100);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new System.Drawing.Size(240, 31);
			this.cmbReportType.TabIndex = 2;
			// 
			// lblStartDate
			// 
			this.lblStartDate.AutoSize = true;
			this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblStartDate.Location = new System.Drawing.Point(285, 75);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(89, 21);
			this.lblStartDate.TabIndex = 3;
			this.lblStartDate.Text = "Start Date:";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
			this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDate.Location = new System.Drawing.Point(285, 100);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(160, 30);
			this.dtpStartDate.TabIndex = 4;
			// 
			// lblEndDate
			// 
			this.lblEndDate.AutoSize = true;
			this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblEndDate.Location = new System.Drawing.Point(465, 75);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(81, 21);
			this.lblEndDate.TabIndex = 5;
			this.lblEndDate.Text = "End Date:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
			this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDate.Location = new System.Drawing.Point(465, 100);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(160, 30);
			this.dtpEndDate.TabIndex = 6;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(645, 98);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 34);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Load";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchKeyword
			// 
			this.txtSearchKeyword.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearchKeyword.Location = new System.Drawing.Point(25, 165);
			this.txtSearchKeyword.Name = "txtSearchKeyword";
			this.txtSearchKeyword.Size = new System.Drawing.Size(300, 30);
			this.txtSearchKeyword.TabIndex = 8;
			this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
			// 
			// lblSearchKeyword
			// 
			this.lblSearchKeyword.AutoSize = true;
			this.lblSearchKeyword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSearchKeyword.ForeColor = System.Drawing.Color.Gray;
			this.lblSearchKeyword.Location = new System.Drawing.Point(25, 142);
			this.lblSearchKeyword.Name = "lblSearchKeyword";
			this.lblSearchKeyword.Size = new System.Drawing.Size(211, 20);
			this.lblSearchKeyword.TabIndex = 9;
			this.lblSearchKeyword.Text = "Filter by Keyword (Real-time):";
			// 
			// dgvReports
			// 
			this.dgvReports.AllowUserToAddRows = false;
			this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReports.BackgroundColor = System.Drawing.Color.White;
			this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReports.Location = new System.Drawing.Point(25, 210);
			this.dgvReports.Name = "dgvReports";
			this.dgvReports.ReadOnly = true;
			this.dgvReports.RowHeadersVisible = false;
			this.dgvReports.RowTemplate.Height = 28;
			this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReports.Size = new System.Drawing.Size(950, 400);
			this.dgvReports.TabIndex = 10;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnExportExcel.ForeColor = System.Drawing.Color.White;
			this.btnExportExcel.Location = new System.Drawing.Point(735, 630);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(115, 40);
			this.btnExportExcel.TabIndex = 11;
			this.btnExportExcel.Text = "Export CSV";
			this.btnExportExcel.UseVisualStyleBackColor = false;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.Location = new System.Drawing.Point(860, 630);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(115, 40);
			this.btnPrint.TabIndex = 12;
			this.btnPrint.Text = "Print Report";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// pnlSummary
			// 
			this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlSummary.BackColor = System.Drawing.Color.White;
			this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSummary.Controls.Add(this.lblTotalTransactionsVal);
			this.pnlSummary.Controls.Add(this.lblTotalTransactionsTitle);
			this.pnlSummary.Controls.Add(this.lblTotalProfitVal);
			this.pnlSummary.Controls.Add(this.lblTotalProfitTitle);
			this.pnlSummary.Controls.Add(this.lblTotalSalesVal);
			this.pnlSummary.Controls.Add(this.lblTotalSalesTitle);
			this.pnlSummary.Location = new System.Drawing.Point(25, 625);
			this.pnlSummary.Name = "pnlSummary";
			this.pnlSummary.Size = new System.Drawing.Size(600, 50);
			this.pnlSummary.TabIndex = 13;
			// 
			// lblTotalTransactionsVal
			// 
			this.lblTotalTransactionsVal.AutoSize = true;
			this.lblTotalTransactionsVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactionsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTotalTransactionsVal.Location = new System.Drawing.Point(490, 13);
			this.lblTotalTransactionsVal.Name = "lblTotalTransactionsVal";
			this.lblTotalTransactionsVal.Size = new System.Drawing.Size(40, 23);
			this.lblTotalTransactionsVal.TabIndex = 5;
			this.lblTotalTransactionsVal.Text = "000";
			// 
			// lblTotalTransactionsTitle
			// 
			this.lblTotalTransactionsTitle.AutoSize = true;
			this.lblTotalTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactionsTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalTransactionsTitle.Location = new System.Drawing.Point(400, 15);
			this.lblTotalTransactionsTitle.Name = "lblTotalTransactionsTitle";
			this.lblTotalTransactionsTitle.Size = new System.Drawing.Size(89, 20);
			this.lblTotalTransactionsTitle.TabIndex = 4;
			this.lblTotalTransactionsTitle.Text = "Records:";
			// 
			// lblTotalProfitVal
			// 
			this.lblTotalProfitVal.AutoSize = true;
			this.lblTotalProfitVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfitVal.ForeColor = System.Drawing.Color.ForestGreen;
			this.lblTotalProfitVal.Location = new System.Drawing.Point(280, 13);
			this.lblTotalProfitVal.Name = "lblTotalProfitVal";
			this.lblTotalProfitVal.Size = new System.Drawing.Size(55, 23);
			this.lblTotalProfitVal.TabIndex = 3;
			this.lblTotalProfitVal.Text = "$0.00";
			// 
			// lblTotalProfitTitle
			// 
			this.lblTotalProfitTitle.AutoSize = true;
			this.lblTotalProfitTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfitTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalProfitTitle.Location = new System.Drawing.Point(225, 15);
			this.lblTotalProfitTitle.Name = "lblTotalProfitTitle";
			this.lblTotalProfitTitle.Size = new System.Drawing.Size(56, 20);
			this.lblTotalProfitTitle.TabIndex = 2;
			this.lblTotalProfitTitle.Text = "Profit:";
			// 
			// lblTotalSalesVal
			// 
			this.lblTotalSalesVal.AutoSize = true;
			this.lblTotalSalesVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalSalesVal.ForeColor = System.Drawing.Color.Navy;
			this.lblTotalSalesVal.Location = new System.Drawing.Point(85, 13);
			this.lblTotalSalesVal.Name = "lblTotalSalesVal";
			this.lblTotalSalesVal.Size = new System.Drawing.Size(55, 23);
			this.lblTotalSalesVal.TabIndex = 1;
			this.lblTotalSalesVal.Text = "$0.00";
			// 
			// lblTotalSalesTitle
			// 
			this.lblTotalSalesTitle.AutoSize = true;
			this.lblTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalSalesTitle.Location = new System.Drawing.Point(12, 15);
			this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
			this.lblTotalSalesTitle.Size = new System.Drawing.Size(74, 20);
			this.lblTotalSalesTitle.TabIndex = 0;
			this.lblTotalSalesTitle.Text = "Revenue:";
			// 
			// frmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.pnlSummary);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.dgvReports);
			this.Controls.Add(this.lblSearchKeyword);
			this.Controls.Add(this.txtSearchKeyword);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.lblEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.lblStartDate);
			this.Controls.Add(this.cmbReportType);
			this.Controls.Add(this.lblReportType);
			this.Controls.Add(this.lblHeaderTitle);
			this.Name = "frmReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Business Reports";
			this.Load += new System.EventHandler(this.frmReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
			this.pnlSummary.ResumeLayout(false);
			this.pnlSummary.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeaderTitle;
		private System.Windows.Forms.Label lblReportType;
		private System.Windows.Forms.ComboBox cmbReportType;
		private System.Windows.Forms.Label lblStartDate;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.Label lblEndDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchKeyword;
		private System.Windows.Forms.Label lblSearchKeyword;
		private System.Windows.Forms.DataGridView dgvReports;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Panel pnlSummary;
		private System.Windows.Forms.Label lblTotalTransactionsVal;
		private System.Windows.Forms.Label lblTotalTransactionsTitle;
		private System.Windows.Forms.Label lblTotalProfitVal;
		private System.Windows.Forms.Label lblTotalProfitTitle;
		private System.Windows.Forms.Label lblTotalSalesVal;
		private System.Windows.Forms.Label lblTotalSalesTitle;
	}
}