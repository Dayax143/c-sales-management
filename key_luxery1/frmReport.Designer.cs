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
			this.dgvReports = new System.Windows.Forms.DataGridView();
			this.btnPrint = new System.Windows.Forms.Button();
			this.pnlActions = new System.Windows.Forms.Panel();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.lblTotalTransactionsVal = new System.Windows.Forms.Label();
			this.cmbReportType = new System.Windows.Forms.ComboBox();
			this.lblReportType = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.lblTotalTransactions = new System.Windows.Forms.Label();
			this.lblTotalProfitVal = new System.Windows.Forms.Label();
			this.lblTotalProfit = new System.Windows.Forms.Label();
			this.lblTotalSalesVal = new System.Windows.Forms.Label();
			this.lblTotalSales = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.pnlTopFilter = new System.Windows.Forms.Panel();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.pnlSummary = new System.Windows.Forms.Panel();
			this.txtSearchKeyword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
			this.pnlActions.SuspendLayout();
			this.pnlTopFilter.SuspendLayout();
			this.pnlSummary.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvReports
			// 
			this.dgvReports.AllowUserToAddRows = false;
			this.dgvReports.AllowUserToDeleteRows = false;
			this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReports.BackgroundColor = System.Drawing.Color.White;
			this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvReports.Location = new System.Drawing.Point(0, 150);
			this.dgvReports.Name = "dgvReports";
			this.dgvReports.ReadOnly = true;
			this.dgvReports.RowHeadersWidth = 51;
			this.dgvReports.RowTemplate.Height = 24;
			this.dgvReports.Size = new System.Drawing.Size(1130, 462);
			this.dgvReports.TabIndex = 7;
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnPrint.Location = new System.Drawing.Point(170, 15);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(140, 35);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "Print Report";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// pnlActions
			// 
			this.pnlActions.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnlActions.Controls.Add(this.txtSearchKeyword);
			this.pnlActions.Controls.Add(this.btnPrint);
			this.pnlActions.Controls.Add(this.label1);
			this.pnlActions.Controls.Add(this.btnExportExcel);
			this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlActions.Location = new System.Drawing.Point(0, 612);
			this.pnlActions.Name = "pnlActions";
			this.pnlActions.Size = new System.Drawing.Size(1130, 65);
			this.pnlActions.TabIndex = 6;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.BackColor = System.Drawing.Color.SeaGreen;
			this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportExcel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnExportExcel.ForeColor = System.Drawing.Color.White;
			this.btnExportExcel.Location = new System.Drawing.Point(20, 15);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(135, 35);
			this.btnExportExcel.TabIndex = 0;
			this.btnExportExcel.Text = "Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = false;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
			this.dtpStartDate.Font = new System.Drawing.Font("Arial", 11F);
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDate.Location = new System.Drawing.Point(120, 23);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(125, 29);
			this.dtpStartDate.TabIndex = 1;
			// 
			// lblStartDate
			// 
			this.lblStartDate.AutoSize = true;
			this.lblStartDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.lblStartDate.Location = new System.Drawing.Point(25, 28);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(56, 19);
			this.lblStartDate.TabIndex = 0;
			this.lblStartDate.Text = "From:";
			// 
			// lblTotalTransactionsVal
			// 
			this.lblTotalTransactionsVal.AutoSize = true;
			this.lblTotalTransactionsVal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactionsVal.ForeColor = System.Drawing.Color.DimGray;
			this.lblTotalTransactionsVal.Location = new System.Drawing.Point(750, 32);
			this.lblTotalTransactionsVal.Name = "lblTotalTransactionsVal";
			this.lblTotalTransactionsVal.Size = new System.Drawing.Size(26, 29);
			this.lblTotalTransactionsVal.TabIndex = 5;
			this.lblTotalTransactionsVal.Text = "0";
			// 
			// cmbReportType
			// 
			this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReportType.Font = new System.Drawing.Font("Arial", 11F);
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.Items.AddRange(new object[] {
            "Sales Report",
            "Payment Report",
            "Product Stock Report",
            "Profit Summary"});
			this.cmbReportType.Location = new System.Drawing.Point(590, 24);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new System.Drawing.Size(240, 29);
			this.cmbReportType.TabIndex = 5;
			// 
			// lblReportType
			// 
			this.lblReportType.AutoSize = true;
			this.lblReportType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.lblReportType.Location = new System.Drawing.Point(470, 28);
			this.lblReportType.Name = "lblReportType";
			this.lblReportType.Size = new System.Drawing.Size(111, 19);
			this.lblReportType.TabIndex = 4;
			this.lblReportType.Text = "Report Type:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
			this.dtpEndDate.Font = new System.Drawing.Font("Arial", 11F);
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDate.Location = new System.Drawing.Point(325, 23);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(125, 29);
			this.dtpEndDate.TabIndex = 3;
			// 
			// lblTotalTransactions
			// 
			this.lblTotalTransactions.AutoSize = true;
			this.lblTotalTransactions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactions.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalTransactions.Location = new System.Drawing.Point(752, 10);
			this.lblTotalTransactions.Name = "lblTotalTransactions";
			this.lblTotalTransactions.Size = new System.Drawing.Size(126, 18);
			this.lblTotalTransactions.TabIndex = 4;
			this.lblTotalTransactions.Text = "TRANSACTIONS";
			// 
			// lblTotalProfitVal
			// 
			this.lblTotalProfitVal.AutoSize = true;
			this.lblTotalProfitVal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfitVal.ForeColor = System.Drawing.Color.SeaGreen;
			this.lblTotalProfitVal.Location = new System.Drawing.Point(400, 32);
			this.lblTotalProfitVal.Name = "lblTotalProfitVal";
			this.lblTotalProfitVal.Size = new System.Drawing.Size(72, 29);
			this.lblTotalProfitVal.TabIndex = 3;
			this.lblTotalProfitVal.Text = "$0.00";
			// 
			// lblTotalProfit
			// 
			this.lblTotalProfit.AutoSize = true;
			this.lblTotalProfit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfit.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalProfit.Location = new System.Drawing.Point(402, 10);
			this.lblTotalProfit.Name = "lblTotalProfit";
			this.lblTotalProfit.Size = new System.Drawing.Size(117, 18);
			this.lblTotalProfit.TabIndex = 2;
			this.lblTotalProfit.Text = "TOTAL PROFIT";
			// 
			// lblTotalSalesVal
			// 
			this.lblTotalSalesVal.AutoSize = true;
			this.lblTotalSalesVal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.lblTotalSalesVal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblTotalSalesVal.Location = new System.Drawing.Point(50, 32);
			this.lblTotalSalesVal.Name = "lblTotalSalesVal";
			this.lblTotalSalesVal.Size = new System.Drawing.Size(72, 29);
			this.lblTotalSalesVal.TabIndex = 1;
			this.lblTotalSalesVal.Text = "$0.00";
			// 
			// lblTotalSales
			// 
			this.lblTotalSales.AutoSize = true;
			this.lblTotalSales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalSales.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalSales.Location = new System.Drawing.Point(52, 10);
			this.lblTotalSales.Name = "lblTotalSales";
			this.lblTotalSales.Size = new System.Drawing.Size(109, 18);
			this.lblTotalSales.TabIndex = 0;
			this.lblTotalSales.Text = "TOTAL SALES";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(865, 20);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 35);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Generate";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// pnlTopFilter
			// 
			this.pnlTopFilter.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnlTopFilter.Controls.Add(this.btnSearch);
			this.pnlTopFilter.Controls.Add(this.cmbReportType);
			this.pnlTopFilter.Controls.Add(this.lblReportType);
			this.pnlTopFilter.Controls.Add(this.dtpEndDate);
			this.pnlTopFilter.Controls.Add(this.lblEndDate);
			this.pnlTopFilter.Controls.Add(this.dtpStartDate);
			this.pnlTopFilter.Controls.Add(this.lblStartDate);
			this.pnlTopFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopFilter.Location = new System.Drawing.Point(0, 75);
			this.pnlTopFilter.Name = "pnlTopFilter";
			this.pnlTopFilter.Size = new System.Drawing.Size(1130, 75);
			this.pnlTopFilter.TabIndex = 4;
			// 
			// lblEndDate
			// 
			this.lblEndDate.AutoSize = true;
			this.lblEndDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.lblEndDate.Location = new System.Drawing.Point(270, 28);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(34, 19);
			this.lblEndDate.TabIndex = 2;
			this.lblEndDate.Text = "To:";
			// 
			// pnlSummary
			// 
			this.pnlSummary.BackColor = System.Drawing.Color.White;
			this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSummary.Controls.Add(this.lblTotalTransactionsVal);
			this.pnlSummary.Controls.Add(this.lblTotalTransactions);
			this.pnlSummary.Controls.Add(this.lblTotalProfitVal);
			this.pnlSummary.Controls.Add(this.lblTotalProfit);
			this.pnlSummary.Controls.Add(this.lblTotalSalesVal);
			this.pnlSummary.Controls.Add(this.lblTotalSales);
			this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSummary.Location = new System.Drawing.Point(0, 0);
			this.pnlSummary.Name = "pnlSummary";
			this.pnlSummary.Size = new System.Drawing.Size(1130, 75);
			this.pnlSummary.TabIndex = 5;
			// 
			// txtSearchKeyword
			// 
			this.txtSearchKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchKeyword.Location = new System.Drawing.Point(865, 15);
			this.txtSearchKeyword.Name = "txtSearchKeyword";
			this.txtSearchKeyword.Size = new System.Drawing.Size(251, 22);
			this.txtSearchKeyword.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(760, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Search by :";
			// 
			// frmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1130, 677);
			this.Controls.Add(this.dgvReports);
			this.Controls.Add(this.pnlActions);
			this.Controls.Add(this.pnlTopFilter);
			this.Controls.Add(this.pnlSummary);
			this.Name = "frmReport";
			this.Load += new System.EventHandler(this.frmReport_Load);
			this.Click += new System.EventHandler(this.frmReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
			this.pnlActions.ResumeLayout(false);
			this.pnlActions.PerformLayout();
			this.pnlTopFilter.ResumeLayout(false);
			this.pnlTopFilter.PerformLayout();
			this.pnlSummary.ResumeLayout(false);
			this.pnlSummary.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReports;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Panel pnlActions;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.Label lblStartDate;
		private System.Windows.Forms.Label lblTotalTransactionsVal;
		private System.Windows.Forms.ComboBox cmbReportType;
		private System.Windows.Forms.Label lblReportType;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label lblTotalTransactions;
		private System.Windows.Forms.Label lblTotalProfitVal;
		private System.Windows.Forms.Label lblTotalProfit;
		private System.Windows.Forms.Label lblTotalSalesVal;
		private System.Windows.Forms.Label lblTotalSales;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlTopFilter;
		private System.Windows.Forms.Label lblEndDate;
		private System.Windows.Forms.Panel pnlSummary;
		private System.Windows.Forms.TextBox txtSearchKeyword;
		private System.Windows.Forms.Label label1;
	}
}