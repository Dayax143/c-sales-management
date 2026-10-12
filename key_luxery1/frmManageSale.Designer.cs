namespace key_luxery1
{
	partial class frmManageSale
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSale));
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
			this.lblInvoiceId = new System.Windows.Forms.Label();
			this.txtInvoiceId = new System.Windows.Forms.TextBox();
			this.lblInvoiceNo = new System.Windows.Forms.Label();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.lblCustomerPhone = new System.Windows.Forms.Label();
			this.txtCustomerPhone = new System.Windows.Forms.TextBox();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.cmbCustomer = new System.Windows.Forms.ComboBox();
			this.lblSaleDate = new System.Windows.Forms.Label();
			this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
			this.grpItemSelection = new System.Windows.Forms.GroupBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtSearchProduct = new System.Windows.Forms.TextBox();
			this.btnFindProduct = new System.Windows.Forms.Button();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.dgvCart = new System.Windows.Forms.DataGridView();
			this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grpSummary = new System.Windows.Forms.GroupBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblPaymentMethod = new System.Windows.Forms.Label();
			this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
			this.lblGrandTotalTitle = new System.Windows.Forms.Label();
			this.lblGrandTotalValue = new System.Windows.Forms.Label();
			this.btnCompleteSale = new System.Windows.Forms.Button();
			this.btnRemoveItem = new System.Windows.Forms.Button();
			this.btnClearCart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.txtcustomer_id = new System.Windows.Forms.TextBox();
			this.txtProduct_name = new System.Windows.Forms.TextBox();
			this.grpCustomerInfo.SuspendLayout();
			this.grpItemSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
			this.grpSummary.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(25, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(327, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Sales & Order Checkout";
			// 
			// grpCustomerInfo
			// 
			this.grpCustomerInfo.Controls.Add(this.lblInvoiceId);
			this.grpCustomerInfo.Controls.Add(this.txtInvoiceId);
			this.grpCustomerInfo.Controls.Add(this.lblInvoiceNo);
			this.grpCustomerInfo.Controls.Add(this.txtInvoiceNo);
			this.grpCustomerInfo.Controls.Add(this.lblCustomerPhone);
			this.grpCustomerInfo.Controls.Add(this.txtCustomerPhone);
			this.grpCustomerInfo.Controls.Add(this.lblCustomer);
			this.grpCustomerInfo.Controls.Add(this.cmbCustomer);
			this.grpCustomerInfo.Controls.Add(this.lblSaleDate);
			this.grpCustomerInfo.Controls.Add(this.dtpSaleDate);
			this.grpCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpCustomerInfo.Location = new System.Drawing.Point(25, 65);
			this.grpCustomerInfo.Name = "grpCustomerInfo";
			this.grpCustomerInfo.Size = new System.Drawing.Size(430, 225);
			this.grpCustomerInfo.TabIndex = 1;
			this.grpCustomerInfo.TabStop = false;
			this.grpCustomerInfo.Text = "Invoice & Customer Information";
			// 
			// lblInvoiceId
			// 
			this.lblInvoiceId.AutoSize = true;
			this.lblInvoiceId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblInvoiceId.Location = new System.Drawing.Point(20, 30);
			this.lblInvoiceId.Name = "lblInvoiceId";
			this.lblInvoiceId.Size = new System.Drawing.Size(85, 21);
			this.lblInvoiceId.TabIndex = 0;
			this.lblInvoiceId.Text = "Invoice ID :";
			// 
			// txtInvoiceId
			// 
			this.txtInvoiceId.Enabled = false;
			this.txtInvoiceId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtInvoiceId.Location = new System.Drawing.Point(145, 27);
			this.txtInvoiceId.Name = "txtInvoiceId";
			this.txtInvoiceId.Size = new System.Drawing.Size(255, 29);
			this.txtInvoiceId.TabIndex = 0;
			// 
			// lblInvoiceNo
			// 
			this.lblInvoiceNo.AutoSize = true;
			this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblInvoiceNo.Location = new System.Drawing.Point(20, 68);
			this.lblInvoiceNo.Name = "lblInvoiceNo";
			this.lblInvoiceNo.Size = new System.Drawing.Size(91, 21);
			this.lblInvoiceNo.TabIndex = 0;
			this.lblInvoiceNo.Text = "Invoice No :";
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.Enabled = false;
			this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtInvoiceNo.Location = new System.Drawing.Point(145, 65);
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.Size = new System.Drawing.Size(255, 29);
			this.txtInvoiceNo.TabIndex = 1;
			// 
			// lblCustomerPhone
			// 
			this.lblCustomerPhone.AutoSize = true;
			this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblCustomerPhone.Location = new System.Drawing.Point(20, 106);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(99, 21);
			this.lblCustomerPhone.TabIndex = 0;
			this.lblCustomerPhone.Text = "Cust. Phone :";
			// 
			// txtCustomerPhone
			// 
			this.txtCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtCustomerPhone.Location = new System.Drawing.Point(145, 103);
			this.txtCustomerPhone.Name = "txtCustomerPhone";
			this.txtCustomerPhone.Size = new System.Drawing.Size(255, 29);
			this.txtCustomerPhone.TabIndex = 2;
			this.txtCustomerPhone.TextChanged += new System.EventHandler(this.txtCustomerPhone_TextChanged);
			// 
			// lblCustomer
			// 
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblCustomer.Location = new System.Drawing.Point(20, 144);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(85, 21);
			this.lblCustomer.TabIndex = 0;
			this.lblCustomer.Text = "Customer :";
			// 
			// cmbCustomer
			// 
			this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbCustomer.FormattingEnabled = true;
			this.cmbCustomer.Location = new System.Drawing.Point(145, 141);
			this.cmbCustomer.Name = "cmbCustomer";
			this.cmbCustomer.Size = new System.Drawing.Size(255, 29);
			this.cmbCustomer.TabIndex = 3;
			this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
			// 
			// lblSaleDate
			// 
			this.lblSaleDate.AutoSize = true;
			this.lblSaleDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSaleDate.Location = new System.Drawing.Point(20, 182);
			this.lblSaleDate.Name = "lblSaleDate";
			this.lblSaleDate.Size = new System.Drawing.Size(82, 21);
			this.lblSaleDate.TabIndex = 0;
			this.lblSaleDate.Text = "Sale Date :";
			// 
			// dtpSaleDate
			// 
			this.dtpSaleDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpSaleDate.Location = new System.Drawing.Point(145, 179);
			this.dtpSaleDate.Name = "dtpSaleDate";
			this.dtpSaleDate.Size = new System.Drawing.Size(255, 29);
			this.dtpSaleDate.TabIndex = 4;
			// 
			// grpItemSelection
			// 
			this.grpItemSelection.Controls.Add(this.lblProduct);
			this.grpItemSelection.Controls.Add(this.txtSearchProduct);
			this.grpItemSelection.Controls.Add(this.btnFindProduct);
			this.grpItemSelection.Controls.Add(this.lblQty);
			this.grpItemSelection.Controls.Add(this.txtQuantity);
			this.grpItemSelection.Controls.Add(this.btnAddItem);
			this.grpItemSelection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpItemSelection.Location = new System.Drawing.Point(25, 305);
			this.grpItemSelection.Name = "grpItemSelection";
			this.grpItemSelection.Size = new System.Drawing.Size(430, 130);
			this.grpItemSelection.TabIndex = 2;
			this.grpItemSelection.TabStop = false;
			this.grpItemSelection.Text = "Search Product & Quantity";
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblProduct.Location = new System.Drawing.Point(20, 35);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(71, 21);
			this.lblProduct.TabIndex = 0;
			this.lblProduct.Text = "Product :";
			// 
			// txtSearchProduct
			// 
			this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchProduct.Location = new System.Drawing.Point(145, 32);
			this.txtSearchProduct.Name = "txtSearchProduct";
			this.txtSearchProduct.Size = new System.Drawing.Size(150, 29);
			this.txtSearchProduct.TabIndex = 0;
			// 
			// btnFindProduct
			// 
			this.btnFindProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.btnFindProduct.FlatAppearance.BorderSize = 0;
			this.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnFindProduct.ForeColor = System.Drawing.Color.White;
			this.btnFindProduct.Location = new System.Drawing.Point(301, 32);
			this.btnFindProduct.Name = "btnFindProduct";
			this.btnFindProduct.Size = new System.Drawing.Size(99, 29);
			this.btnFindProduct.TabIndex = 1;
			this.btnFindProduct.Text = "Find";
			this.btnFindProduct.UseVisualStyleBackColor = false;
			this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
			// 
			// lblQty
			// 
			this.lblQty.AutoSize = true;
			this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblQty.Location = new System.Drawing.Point(20, 75);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(77, 21);
			this.lblQty.TabIndex = 0;
			this.lblQty.Text = "Quantity :";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtQuantity.Location = new System.Drawing.Point(145, 72);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(90, 29);
			this.txtQuantity.TabIndex = 2;
			this.txtQuantity.Text = "1";
			// 
			// btnAddItem
			// 
			this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnAddItem.FlatAppearance.BorderSize = 0;
			this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnAddItem.ForeColor = System.Drawing.Color.White;
			this.btnAddItem.Location = new System.Drawing.Point(241, 70);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(159, 32);
			this.btnAddItem.TabIndex = 3;
			this.btnAddItem.Text = "+ Add to Cart";
			this.btnAddItem.UseVisualStyleBackColor = false;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// dgvCart
			// 
			this.dgvCart.AllowUserToAddRows = false;
			this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCart.BackgroundColor = System.Drawing.Color.White;
			this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCart.ColumnHeadersHeight = 35;
			this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colPrice,
            this.colQuantity,
            this.colSubtotal});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCart.EnableHeadersVisualStyles = false;
			this.dgvCart.Location = new System.Drawing.Point(475, 65);
			this.dgvCart.Name = "dgvCart";
			this.dgvCart.ReadOnly = true;
			this.dgvCart.RowHeadersVisible = false;
			this.dgvCart.RowHeadersWidth = 51;
			this.dgvCart.RowTemplate.Height = 30;
			this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCart.Size = new System.Drawing.Size(585, 490);
			this.dgvCart.TabIndex = 3;
			// 
			// colProductID
			// 
			this.colProductID.HeaderText = "ID";
			this.colProductID.MinimumWidth = 6;
			this.colProductID.Name = "colProductID";
			this.colProductID.ReadOnly = true;
			this.colProductID.Visible = false;
			// 
			// colProductName
			// 
			this.colProductName.HeaderText = "Product Name";
			this.colProductName.MinimumWidth = 6;
			this.colProductName.Name = "colProductName";
			this.colProductName.ReadOnly = true;
			// 
			// colPrice
			// 
			this.colPrice.HeaderText = "Price";
			this.colPrice.MinimumWidth = 6;
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			// 
			// colQuantity
			// 
			this.colQuantity.HeaderText = "Qty";
			this.colQuantity.MinimumWidth = 6;
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.ReadOnly = true;
			// 
			// colSubtotal
			// 
			this.colSubtotal.HeaderText = "Subtotal";
			this.colSubtotal.MinimumWidth = 6;
			this.colSubtotal.Name = "colSubtotal";
			this.colSubtotal.ReadOnly = true;
			// 
			// grpSummary
			// 
			this.grpSummary.Controls.Add(this.lblDiscount);
			this.grpSummary.Controls.Add(this.txtDiscount);
			this.grpSummary.Controls.Add(this.lblPaymentMethod);
			this.grpSummary.Controls.Add(this.cmbPaymentMethod);
			this.grpSummary.Controls.Add(this.lblGrandTotalTitle);
			this.grpSummary.Controls.Add(this.lblGrandTotalValue);
			this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpSummary.Location = new System.Drawing.Point(25, 445);
			this.grpSummary.Name = "grpSummary";
			this.grpSummary.Size = new System.Drawing.Size(430, 165);
			this.grpSummary.TabIndex = 4;
			this.grpSummary.TabStop = false;
			this.grpSummary.Text = "Payment & Total Summary";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblDiscount.Location = new System.Drawing.Point(20, 35);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(78, 21);
			this.lblDiscount.TabIndex = 0;
			this.lblDiscount.Text = "Discount :";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtDiscount.Location = new System.Drawing.Point(145, 32);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(255, 29);
			this.txtDiscount.TabIndex = 0;
			this.txtDiscount.Text = "0";
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// lblPaymentMethod
			// 
			this.lblPaymentMethod.AutoSize = true;
			this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblPaymentMethod.Location = new System.Drawing.Point(20, 75);
			this.lblPaymentMethod.Name = "lblPaymentMethod";
			this.lblPaymentMethod.Size = new System.Drawing.Size(113, 21);
			this.lblPaymentMethod.TabIndex = 0;
			this.lblPaymentMethod.Text = "Payment Type :";
			// 
			// cmbPaymentMethod
			// 
			this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbPaymentMethod.FormattingEnabled = true;
			this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Bank Transfer",
            "Store Credit"});
			this.cmbPaymentMethod.Location = new System.Drawing.Point(145, 72);
			this.cmbPaymentMethod.Name = "cmbPaymentMethod";
			this.cmbPaymentMethod.Size = new System.Drawing.Size(255, 29);
			this.cmbPaymentMethod.TabIndex = 1;
			this.cmbPaymentMethod.Text = "Cash";
			// 
			// lblGrandTotalTitle
			// 
			this.lblGrandTotalTitle.AutoSize = true;
			this.lblGrandTotalTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblGrandTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblGrandTotalTitle.Location = new System.Drawing.Point(20, 118);
			this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
			this.lblGrandTotalTitle.Size = new System.Drawing.Size(126, 25);
			this.lblGrandTotalTitle.TabIndex = 0;
			this.lblGrandTotalTitle.Text = "Grand Total :";
			// 
			// lblGrandTotalValue
			// 
			this.lblGrandTotalValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.lblGrandTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.lblGrandTotalValue.Location = new System.Drawing.Point(145, 112);
			this.lblGrandTotalValue.Name = "lblGrandTotalValue";
			this.lblGrandTotalValue.Size = new System.Drawing.Size(255, 35);
			this.lblGrandTotalValue.TabIndex = 2;
			this.lblGrandTotalValue.Text = "$0.00";
			this.lblGrandTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCompleteSale
			// 
			this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnCompleteSale.FlatAppearance.BorderSize = 0;
			this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
			this.btnCompleteSale.Location = new System.Drawing.Point(905, 570);
			this.btnCompleteSale.Name = "btnCompleteSale";
			this.btnCompleteSale.Size = new System.Drawing.Size(155, 42);
			this.btnCompleteSale.TabIndex = 5;
			this.btnCompleteSale.Text = "Complete & Print";
			this.btnCompleteSale.UseVisualStyleBackColor = false;
			this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
			// 
			// btnRemoveItem
			// 
			this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnRemoveItem.FlatAppearance.BorderSize = 0;
			this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
			this.btnRemoveItem.Location = new System.Drawing.Point(755, 570);
			this.btnRemoveItem.Name = "btnRemoveItem";
			this.btnRemoveItem.Size = new System.Drawing.Size(140, 42);
			this.btnRemoveItem.TabIndex = 6;
			this.btnRemoveItem.Text = "Remove Item";
			this.btnRemoveItem.UseVisualStyleBackColor = false;
			this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
			// 
			// btnClearCart
			// 
			this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnClearCart.FlatAppearance.BorderSize = 0;
			this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClearCart.ForeColor = System.Drawing.Color.White;
			this.btnClearCart.Location = new System.Drawing.Point(605, 570);
			this.btnClearCart.Name = "btnClearCart";
			this.btnClearCart.Size = new System.Drawing.Size(140, 42);
			this.btnClearCart.TabIndex = 7;
			this.btnClearCart.Text = "Clear Cart";
			this.btnClearCart.UseVisualStyleBackColor = false;
			this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(475, 570);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 42);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// txtcustomer_id
			// 
			this.txtcustomer_id.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtcustomer_id.Location = new System.Drawing.Point(514, 12);
			this.txtcustomer_id.Name = "txtcustomer_id";
			this.txtcustomer_id.Size = new System.Drawing.Size(90, 29);
			this.txtcustomer_id.TabIndex = 2;
			this.txtcustomer_id.Visible = false;
			// 
			// txtProduct_name
			// 
			this.txtProduct_name.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtProduct_name.Location = new System.Drawing.Point(622, 12);
			this.txtProduct_name.Name = "txtProduct_name";
			this.txtProduct_name.Size = new System.Drawing.Size(150, 29);
			this.txtProduct_name.TabIndex = 0;
			this.txtProduct_name.Visible = false;
			// 
			// frmManageSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1085, 635);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtProduct_name);
			this.Controls.Add(this.btnClearCart);
			this.Controls.Add(this.btnRemoveItem);
			this.Controls.Add(this.btnCompleteSale);
			this.Controls.Add(this.txtcustomer_id);
			this.Controls.Add(this.grpSummary);
			this.Controls.Add(this.dgvCart);
			this.Controls.Add(this.grpItemSelection);
			this.Controls.Add(this.grpCustomerInfo);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Point of Sale (Manage Sale)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageSale_FormClosing);
			this.Load += new System.EventHandler(this.frmManageSale_Load);
			this.grpCustomerInfo.ResumeLayout(false);
			this.grpCustomerInfo.PerformLayout();
			this.grpItemSelection.ResumeLayout(false);
			this.grpItemSelection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
			this.grpSummary.ResumeLayout(false);
			this.grpSummary.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpCustomerInfo;
		private System.Windows.Forms.Label lblInvoiceId;
		public System.Windows.Forms.TextBox txtInvoiceId;
		private System.Windows.Forms.Label lblInvoiceNo;
		public System.Windows.Forms.TextBox txtInvoiceNo;
		private System.Windows.Forms.Label lblCustomerPhone;
		public System.Windows.Forms.TextBox txtCustomerPhone;
		private System.Windows.Forms.Label lblCustomer;
		public System.Windows.Forms.ComboBox cmbCustomer;
		private System.Windows.Forms.Label lblSaleDate;
		public System.Windows.Forms.DateTimePicker dtpSaleDate;
		private System.Windows.Forms.GroupBox grpItemSelection;
		private System.Windows.Forms.Label lblProduct;
		public System.Windows.Forms.TextBox txtSearchProduct;
		public System.Windows.Forms.Button btnFindProduct;
		private System.Windows.Forms.Label lblQty;
		public System.Windows.Forms.TextBox txtQuantity;
		public System.Windows.Forms.Button btnAddItem;
		public System.Windows.Forms.DataGridView dgvCart;
		private System.Windows.Forms.GroupBox grpSummary;
		private System.Windows.Forms.Label lblDiscount;
		public System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label lblPaymentMethod;
		public System.Windows.Forms.ComboBox cmbPaymentMethod;
		private System.Windows.Forms.Label lblGrandTotalTitle;
		public System.Windows.Forms.Label lblGrandTotalValue;
		public System.Windows.Forms.Button btnCompleteSale;
		public System.Windows.Forms.Button btnRemoveItem;
		public System.Windows.Forms.Button btnClearCart;
		public System.Windows.Forms.Button btnCancel;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
		public System.Windows.Forms.TextBox txtcustomer_id;
		public System.Windows.Forms.TextBox txtProduct_name;
	}
}