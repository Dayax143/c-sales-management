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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.lblTotalExpensesVal = new System.Windows.Forms.Label();
			this.lblTotalExpensesTitle = new System.Windows.Forms.Label();
			this.lblTotalTransactionsVal = new System.Windows.Forms.Label();
			this.lblTotalTransactionsTitle = new System.Windows.Forms.Label();
			this.lblTotalProfitVal = new System.Windows.Forms.Label();
			this.lblTotalProfitTitle = new System.Windows.Forms.Label();
			this.lblTotalSalesVal = new System.Windows.Forms.Label();
			this.lblTotalSalesTitle = new System.Windows.Forms.Label();
			this.pnlTopHeader = new System.Windows.Forms.Panel();
			this.pnlFilterCard = new System.Windows.Forms.Panel();
			this.pnlFooterSignature = new System.Windows.Forms.Panel();
			this.lblPrepLine = new System.Windows.Forms.Label();
			this.lblPreparedBy = new System.Windows.Forms.Label();
			this.lblApprLine = new System.Windows.Forms.Label();
			this.lblApprovedBy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
			this.pnlSummary.SuspendLayout();
			this.pnlTopHeader.SuspendLayout();
			this.pnlFilterCard.SuspendLayout();
			this.pnlFooterSignature.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHeaderTitle
			// 
			this.lblHeaderTitle.AutoSize = true;
			this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
			this.lblHeaderTitle.Location = new System.Drawing.Point(20, 12);
			this.lblHeaderTitle.Name = "lblHeaderTitle";
			this.lblHeaderTitle.Size = new System.Drawing.Size(367, 37);
			this.lblHeaderTitle.TabIndex = 0;
			this.lblHeaderTitle.Text = "Advanced Business Reports";
			// 
			// lblReportType
			// 
			this.lblReportType.AutoSize = true;
			this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblReportType.Location = new System.Drawing.Point(15, 12);
			this.lblReportType.Name = "lblReportType";
			this.lblReportType.Size = new System.Drawing.Size(105, 21);
			this.lblReportType.TabIndex = 0;
			this.lblReportType.Text = "Report Type:";
			// 
			// cmbReportType
			// 
			this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.Items.AddRange(new object[] {
            "Sales Report",
            "Expense Summary Report",
            "Profit & Loss Report",
            "Payment Report",
            "Product Stock Report",
            "Customer Purchase History",
            "Daily Sales & Expense Breakdown",
            "Low Stock Inventory Report"});
			this.cmbReportType.Location = new System.Drawing.Point(15, 36);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new System.Drawing.Size(250, 31);
			this.cmbReportType.TabIndex = 1;
			// 
			// lblStartDate
			// 
			this.lblStartDate.AutoSize = true;
			this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblStartDate.Location = new System.Drawing.Point(280, 12);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(90, 21);
			this.lblStartDate.TabIndex = 2;
			this.lblStartDate.Text = "Start Date:";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
			this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDate.Location = new System.Drawing.Point(280, 36);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(150, 30);
			this.dtpStartDate.TabIndex = 3;
			// 
			// lblEndDate
			// 
			this.lblEndDate.AutoSize = true;
			this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblEndDate.Location = new System.Drawing.Point(445, 12);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(83, 21);
			this.lblEndDate.TabIndex = 4;
			this.lblEndDate.Text = "End Date:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
			this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDate.Location = new System.Drawing.Point(445, 36);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(150, 30);
			this.dtpEndDate.TabIndex = 5;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(610, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(110, 33);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Load Report";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchKeyword
			// 
			this.txtSearchKeyword.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearchKeyword.Location = new System.Drawing.Point(735, 36);
			this.txtSearchKeyword.Name = "txtSearchKeyword";
			this.txtSearchKeyword.Size = new System.Drawing.Size(225, 30);
			this.txtSearchKeyword.TabIndex = 8;
			this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
			// 
			// lblSearchKeyword
			// 
			this.lblSearchKeyword.AutoSize = true;
			this.lblSearchKeyword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
			this.lblSearchKeyword.ForeColor = System.Drawing.Color.Gray;
			this.lblSearchKeyword.Location = new System.Drawing.Point(735, 12);
			this.lblSearchKeyword.Name = "lblSearchKeyword";
			this.lblSearchKeyword.Size = new System.Drawing.Size(167, 20);
			this.lblSearchKeyword.TabIndex = 7;
			this.lblSearchKeyword.Text = "Filter Grid (Real-time):";
			// 
			// dgvReports
			// 
			this.dgvReports.AllowUserToAddRows = false;
			this.dgvReports.AllowUserToDeleteRows = false;
			this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReports.BackgroundColor = System.Drawing.Color.White;
			this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvReports.ColumnHeadersHeight = 35;
			this.dgvReports.EnableHeadersVisualStyles = false;
			this.dgvReports.Location = new System.Drawing.Point(20, 200);
			this.dgvReports.MultiSelect = false;
			this.dgvReports.Name = "dgvReports";
			this.dgvReports.ReadOnly = true;
			this.dgvReports.RowHeadersVisible = false;
			this.dgvReports.RowHeadersWidth = 51;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.dgvReports.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvReports.RowTemplate.Height = 30;
			this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReports.Size = new System.Drawing.Size(1112, 398);
			this.dgvReports.TabIndex = 2;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnExportExcel.FlatAppearance.BorderSize = 0;
			this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnExportExcel.ForeColor = System.Drawing.Color.White;
			this.btnExportExcel.Location = new System.Drawing.Point(892, 613);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(115, 50);
			this.btnExportExcel.TabIndex = 4;
			this.btnExportExcel.Text = "Export CSV";
			this.btnExportExcel.UseVisualStyleBackColor = false;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.Location = new System.Drawing.Point(1017, 613);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(115, 50);
			this.btnPrint.TabIndex = 5;
			this.btnPrint.Text = "Print Report";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// pnlSummary
			// 
			this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSummary.BackColor = System.Drawing.Color.White;
			this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSummary.Controls.Add(this.lblTotalExpensesVal);
			this.pnlSummary.Controls.Add(this.lblTotalExpensesTitle);
			this.pnlSummary.Controls.Add(this.lblTotalTransactionsVal);
			this.pnlSummary.Controls.Add(this.lblTotalTransactionsTitle);
			this.pnlSummary.Controls.Add(this.lblTotalProfitVal);
			this.pnlSummary.Controls.Add(this.lblTotalProfitTitle);
			this.pnlSummary.Controls.Add(this.lblTotalSalesVal);
			this.pnlSummary.Controls.Add(this.lblTotalSalesTitle);
			this.pnlSummary.Location = new System.Drawing.Point(20, 613);
			this.pnlSummary.Name = "pnlSummary";
			this.pnlSummary.Size = new System.Drawing.Size(862, 50);
			this.pnlSummary.TabIndex = 3;
			// 
			// lblTotalExpensesVal
			// 
			this.lblTotalExpensesVal.AutoSize = true;
			this.lblTotalExpensesVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalExpensesVal.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTotalExpensesVal.Location = new System.Drawing.Point(306, 13);
			this.lblTotalExpensesVal.Name = "lblTotalExpensesVal";
			this.lblTotalExpensesVal.Size = new System.Drawing.Size(55, 23);
			this.lblTotalExpensesVal.TabIndex = 3;
			this.lblTotalExpensesVal.Text = "$0.00";
			// 
			// lblTotalExpensesTitle
			// 
			this.lblTotalExpensesTitle.AutoSize = true;
			this.lblTotalExpensesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalExpensesTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalExpensesTitle.Location = new System.Drawing.Point(226, 15);
			this.lblTotalExpensesTitle.Name = "lblTotalExpensesTitle";
			this.lblTotalExpensesTitle.Size = new System.Drawing.Size(77, 20);
			this.lblTotalExpensesTitle.TabIndex = 2;
			this.lblTotalExpensesTitle.Text = "Expenses:";
			// 
			// lblTotalTransactionsVal
			// 
			this.lblTotalTransactionsVal.AutoSize = true;
			this.lblTotalTransactionsVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactionsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTotalTransactionsVal.Location = new System.Drawing.Point(746, 13);
			this.lblTotalTransactionsVal.Name = "lblTotalTransactionsVal";
			this.lblTotalTransactionsVal.Size = new System.Drawing.Size(20, 23);
			this.lblTotalTransactionsVal.TabIndex = 7;
			this.lblTotalTransactionsVal.Text = "0";
			// 
			// lblTotalTransactionsTitle
			// 
			this.lblTotalTransactionsTitle.AutoSize = true;
			this.lblTotalTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalTransactionsTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalTransactionsTitle.Location = new System.Drawing.Point(671, 15);
			this.lblTotalTransactionsTitle.Name = "lblTotalTransactionsTitle";
			this.lblTotalTransactionsTitle.Size = new System.Drawing.Size(69, 20);
			this.lblTotalTransactionsTitle.TabIndex = 6;
			this.lblTotalTransactionsTitle.Text = "Records:";
			// 
			// lblTotalProfitVal
			// 
			this.lblTotalProfitVal.AutoSize = true;
			this.lblTotalProfitVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfitVal.ForeColor = System.Drawing.Color.ForestGreen;
			this.lblTotalProfitVal.Location = new System.Drawing.Point(530, 13);
			this.lblTotalProfitVal.Name = "lblTotalProfitVal";
			this.lblTotalProfitVal.Size = new System.Drawing.Size(55, 23);
			this.lblTotalProfitVal.TabIndex = 5;
			this.lblTotalProfitVal.Text = "$0.00";
			// 
			// lblTotalProfitTitle
			// 
			this.lblTotalProfitTitle.AutoSize = true;
			this.lblTotalProfitTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTotalProfitTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalProfitTitle.Location = new System.Drawing.Point(445, 15);
			this.lblTotalProfitTitle.Name = "lblTotalProfitTitle";
			this.lblTotalProfitTitle.Size = new System.Drawing.Size(83, 20);
			this.lblTotalProfitTitle.TabIndex = 4;
			this.lblTotalProfitTitle.Text = "Net Profit:";
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
			this.lblTotalSalesTitle.Location = new System.Drawing.Point(10, 15);
			this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
			this.lblTotalSalesTitle.Size = new System.Drawing.Size(73, 20);
			this.lblTotalSalesTitle.TabIndex = 0;
			this.lblTotalSalesTitle.Text = "Revenue:";
			// 
			// pnlTopHeader
			// 
			this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
			this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlTopHeader.Name = "pnlTopHeader";
			this.pnlTopHeader.Size = new System.Drawing.Size(1152, 60);
			this.pnlTopHeader.TabIndex = 0;
			// 
			// pnlFilterCard
			// 
			this.pnlFilterCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFilterCard.BackColor = System.Drawing.Color.White;
			this.pnlFilterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFilterCard.Controls.Add(this.lblReportType);
			this.pnlFilterCard.Controls.Add(this.cmbReportType);
			this.pnlFilterCard.Controls.Add(this.lblStartDate);
			this.pnlFilterCard.Controls.Add(this.dtpStartDate);
			this.pnlFilterCard.Controls.Add(this.lblEndDate);
			this.pnlFilterCard.Controls.Add(this.dtpEndDate);
			this.pnlFilterCard.Controls.Add(this.btnSearch);
			this.pnlFilterCard.Controls.Add(this.lblSearchKeyword);
			this.pnlFilterCard.Controls.Add(this.txtSearchKeyword);
			this.pnlFilterCard.Location = new System.Drawing.Point(20, 75);
			this.pnlFilterCard.Name = "pnlFilterCard";
			this.pnlFilterCard.Size = new System.Drawing.Size(1112, 110);
			this.pnlFilterCard.TabIndex = 1;
			// 
			// pnlFooterSignature
			// 
			this.pnlFooterSignature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFooterSignature.Controls.Add(this.lblPrepLine);
			this.pnlFooterSignature.Controls.Add(this.lblPreparedBy);
			this.pnlFooterSignature.Controls.Add(this.lblApprLine);
			this.pnlFooterSignature.Controls.Add(this.lblApprovedBy);
			this.pnlFooterSignature.Location = new System.Drawing.Point(20, 670);
			this.pnlFooterSignature.Name = "pnlFooterSignature";
			this.pnlFooterSignature.Size = new System.Drawing.Size(1112, 40);
			this.pnlFooterSignature.TabIndex = 6;
			// 
			// lblPrepLine
			// 
			this.lblPrepLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPrepLine.Location = new System.Drawing.Point(100, 25);
			this.lblPrepLine.Name = "lblPrepLine";
			this.lblPrepLine.Size = new System.Drawing.Size(200, 2);
			this.lblPrepLine.TabIndex = 1;
			// 
			// lblPreparedBy
			// 
			this.lblPreparedBy.AutoSize = true;
			this.lblPreparedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPreparedBy.ForeColor = System.Drawing.Color.DimGray;
			this.lblPreparedBy.Location = new System.Drawing.Point(0, 10);
			this.lblPreparedBy.Name = "lblPreparedBy";
			this.lblPreparedBy.Size = new System.Drawing.Size(98, 20);
			this.lblPreparedBy.TabIndex = 0;
			this.lblPreparedBy.Text = "Prepared By:";
			// 
			// lblApprLine
			// 
			this.lblApprLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblApprLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblApprLine.Location = new System.Drawing.Point(902, 25);
			this.lblApprLine.Name = "lblApprLine";
			this.lblApprLine.Size = new System.Drawing.Size(200, 2);
			this.lblApprLine.TabIndex = 3;
			// 
			// lblApprovedBy
			// 
			this.lblApprovedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblApprovedBy.AutoSize = true;
			this.lblApprovedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApprovedBy.ForeColor = System.Drawing.Color.DimGray;
			this.lblApprovedBy.Location = new System.Drawing.Point(797, 10);
			this.lblApprovedBy.Name = "lblApprovedBy";
			this.lblApprovedBy.Size = new System.Drawing.Size(104, 20);
			this.lblApprovedBy.TabIndex = 2;
			this.lblApprovedBy.Text = "Approved By:";
			// 
			// frmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1152, 718);
			this.Controls.Add(this.pnlFooterSignature);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.pnlSummary);
			this.Controls.Add(this.dgvReports);
			this.Controls.Add(this.pnlFilterCard);
			this.Controls.Add(this.pnlTopHeader);
			this.Name = "frmReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Business Reports";
			this.Load += new System.EventHandler(this.frmReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
			this.pnlSummary.ResumeLayout(false);
			this.pnlSummary.PerformLayout();
			this.pnlTopHeader.ResumeLayout(false);
			this.pnlTopHeader.PerformLayout();
			this.pnlFilterCard.ResumeLayout(false);
			this.pnlFilterCard.PerformLayout();
			this.pnlFooterSignature.ResumeLayout(false);
			this.pnlFooterSignature.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTopHeader;
		private System.Windows.Forms.Label lblHeaderTitle;
		private System.Windows.Forms.Panel pnlFilterCard;
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
		private System.Windows.Forms.Label lblTotalSalesVal;
		private System.Windows.Forms.Label lblTotalSalesTitle;
		private System.Windows.Forms.Label lblTotalExpensesVal;
		private System.Windows.Forms.Label lblTotalExpensesTitle;
		private System.Windows.Forms.Label lblTotalProfitVal;
		private System.Windows.Forms.Label lblTotalProfitTitle;
		private System.Windows.Forms.Label lblTotalTransactionsVal;
		private System.Windows.Forms.Label lblTotalTransactionsTitle;
		private System.Windows.Forms.Panel pnlFooterSignature;
		private System.Windows.Forms.Label lblPreparedBy;
		private System.Windows.Forms.Label lblApprovedBy;
		private System.Windows.Forms.Label lblPrepLine;
		private System.Windows.Forms.Label lblApprLine;
	}
}