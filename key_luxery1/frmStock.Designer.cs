namespace key_luxery1
{
	partial class frmStock
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpStockControl = new System.Windows.Forms.GroupBox();
			this.btnRestock = new System.Windows.Forms.Button();
			this.btnAdjust = new System.Windows.Forms.Button();
			this.txtAdjustmentQty = new System.Windows.Forms.TextBox();
			this.lblAdjustmentQty = new System.Windows.Forms.Label();
			this.txtSelectedProduct = new System.Windows.Forms.TextBox();
			this.lblSelectedProduct = new System.Windows.Forms.Label();
			this.dgvCurrentStock = new System.Windows.Forms.DataGridView();
			this.dgvStockLogs = new System.Windows.Forms.DataGridView();
			this.lblInventoryTitle = new System.Windows.Forms.Label();
			this.lblLogsTitle = new System.Windows.Forms.Label();
			this.txtSearchStock = new System.Windows.Forms.TextBox();
			this.lblSearchStock = new System.Windows.Forms.Label();
			this.grpStockControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStockLogs)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(30, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(443, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Inventory & Stock Management";
			// 
			// grpStockControl
			// 
			this.grpStockControl.Controls.Add(this.btnRestock);
			this.grpStockControl.Controls.Add(this.btnAdjust);
			this.grpStockControl.Controls.Add(this.txtAdjustmentQty);
			this.grpStockControl.Controls.Add(this.lblAdjustmentQty);
			this.grpStockControl.Controls.Add(this.txtSelectedProduct);
			this.grpStockControl.Controls.Add(this.lblSelectedProduct);
			this.grpStockControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpStockControl.Location = new System.Drawing.Point(30, 70);
			this.grpStockControl.Name = "grpStockControl";
			this.grpStockControl.Size = new System.Drawing.Size(430, 220);
			this.grpStockControl.TabIndex = 1;
			this.grpStockControl.TabStop = false;
			this.grpStockControl.Text = "Stock Adjustment Panel";
			// 
			// btnRestock
			// 
			this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnRestock.FlatAppearance.BorderSize = 0;
			this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRestock.ForeColor = System.Drawing.Color.White;
			this.btnRestock.Location = new System.Drawing.Point(20, 150);
			this.btnRestock.Name = "btnRestock";
			this.btnRestock.Size = new System.Drawing.Size(185, 64);
			this.btnRestock.TabIndex = 2;
			this.btnRestock.Text = "(+) Restock Item";
			this.btnRestock.UseVisualStyleBackColor = false;
			this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
			// 
			// btnAdjust
			// 
			this.btnAdjust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnAdjust.FlatAppearance.BorderSize = 0;
			this.btnAdjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdjust.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnAdjust.ForeColor = System.Drawing.Color.White;
			this.btnAdjust.Location = new System.Drawing.Point(220, 150);
			this.btnAdjust.Name = "btnAdjust";
			this.btnAdjust.Size = new System.Drawing.Size(185, 64);
			this.btnAdjust.TabIndex = 3;
			this.btnAdjust.Text = "(-) Shrinkage / Damage";
			this.btnAdjust.UseVisualStyleBackColor = false;
			this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
			// 
			// txtAdjustmentQty
			// 
			this.txtAdjustmentQty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtAdjustmentQty.Location = new System.Drawing.Point(140, 90);
			this.txtAdjustmentQty.Name = "txtAdjustmentQty";
			this.txtAdjustmentQty.Size = new System.Drawing.Size(265, 29);
			this.txtAdjustmentQty.TabIndex = 1;
			this.txtAdjustmentQty.Text = "1";
			// 
			// lblAdjustmentQty
			// 
			this.lblAdjustmentQty.AutoSize = true;
			this.lblAdjustmentQty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblAdjustmentQty.Location = new System.Drawing.Point(20, 93);
			this.lblAdjustmentQty.Name = "lblAdjustmentQty";
			this.lblAdjustmentQty.Size = new System.Drawing.Size(77, 21);
			this.lblAdjustmentQty.TabIndex = 0;
			this.lblAdjustmentQty.Text = "Quantity :";
			// 
			// txtSelectedProduct
			// 
			this.txtSelectedProduct.Enabled = false;
			this.txtSelectedProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSelectedProduct.Location = new System.Drawing.Point(140, 45);
			this.txtSelectedProduct.Name = "txtSelectedProduct";
			this.txtSelectedProduct.Size = new System.Drawing.Size(265, 29);
			this.txtSelectedProduct.TabIndex = 0;
			this.txtSelectedProduct.Text = "Select item from grid ->";
			// 
			// lblSelectedProduct
			// 
			this.lblSelectedProduct.AutoSize = true;
			this.lblSelectedProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSelectedProduct.Location = new System.Drawing.Point(20, 48);
			this.lblSelectedProduct.Name = "lblSelectedProduct";
			this.lblSelectedProduct.Size = new System.Drawing.Size(117, 21);
			this.lblSelectedProduct.TabIndex = 0;
			this.lblSelectedProduct.Text = "Active Product :";
			// 
			// dgvCurrentStock
			// 
			this.dgvCurrentStock.AllowUserToAddRows = false;
			this.dgvCurrentStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCurrentStock.BackgroundColor = System.Drawing.Color.White;
			this.dgvCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCurrentStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvCurrentStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCurrentStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCurrentStock.ColumnHeadersHeight = 35;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCurrentStock.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvCurrentStock.EnableHeadersVisualStyles = false;
			this.dgvCurrentStock.Location = new System.Drawing.Point(485, 110);
			this.dgvCurrentStock.Name = "dgvCurrentStock";
			this.dgvCurrentStock.ReadOnly = true;
			this.dgvCurrentStock.RowHeadersVisible = false;
			this.dgvCurrentStock.RowHeadersWidth = 51;
			this.dgvCurrentStock.RowTemplate.Height = 30;
			this.dgvCurrentStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCurrentStock.Size = new System.Drawing.Size(705, 330);
			this.dgvCurrentStock.TabIndex = 2;
			this.dgvCurrentStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentStock_CellClick);
			// 
			// dgvStockLogs
			// 
			this.dgvStockLogs.AllowUserToAddRows = false;
			this.dgvStockLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStockLogs.BackgroundColor = System.Drawing.Color.White;
			this.dgvStockLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvStockLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvStockLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStockLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvStockLogs.ColumnHeadersHeight = 35;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStockLogs.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvStockLogs.EnableHeadersVisualStyles = false;
			this.dgvStockLogs.Location = new System.Drawing.Point(30, 485);
			this.dgvStockLogs.Name = "dgvStockLogs";
			this.dgvStockLogs.ReadOnly = true;
			this.dgvStockLogs.RowHeadersVisible = false;
			this.dgvStockLogs.RowHeadersWidth = 51;
			this.dgvStockLogs.RowTemplate.Height = 28;
			this.dgvStockLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStockLogs.Size = new System.Drawing.Size(1160, 245);
			this.dgvStockLogs.TabIndex = 3;
			// 
			// lblInventoryTitle
			// 
			this.lblInventoryTitle.AutoSize = true;
			this.lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblInventoryTitle.Location = new System.Drawing.Point(485, 75);
			this.lblInventoryTitle.Name = "lblInventoryTitle";
			this.lblInventoryTitle.Size = new System.Drawing.Size(239, 28);
			this.lblInventoryTitle.TabIndex = 0;
			this.lblInventoryTitle.Text = "Current Stock Inventory";
			// 
			// lblLogsTitle
			// 
			this.lblLogsTitle.AutoSize = true;
			this.lblLogsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblLogsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblLogsTitle.Location = new System.Drawing.Point(30, 455);
			this.lblLogsTitle.Name = "lblLogsTitle";
			this.lblLogsTitle.Size = new System.Drawing.Size(242, 28);
			this.lblLogsTitle.TabIndex = 0;
			this.lblLogsTitle.Text = "Stock Movement Ledger";
			// 
			// txtSearchStock
			// 
			this.txtSearchStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchStock.Location = new System.Drawing.Point(890, 75);
			this.txtSearchStock.Name = "txtSearchStock";
			this.txtSearchStock.Size = new System.Drawing.Size(300, 29);
			this.txtSearchStock.TabIndex = 4;
			this.txtSearchStock.TextChanged += new System.EventHandler(this.txtSearchStock_TextChanged);
			// 
			// lblSearchStock
			// 
			this.lblSearchStock.AutoSize = true;
			this.lblSearchStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSearchStock.Location = new System.Drawing.Point(780, 78);
			this.lblSearchStock.Name = "lblSearchStock";
			this.lblSearchStock.Size = new System.Drawing.Size(122, 21);
			this.lblSearchStock.TabIndex = 0;
			this.lblSearchStock.Text = "Search Product :";
			// 
			// frmStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1219, 755);
			this.Controls.Add(this.lblSearchStock);
			this.Controls.Add(this.txtSearchStock);
			this.Controls.Add(this.lblLogsTitle);
			this.Controls.Add(this.lblInventoryTitle);
			this.Controls.Add(this.dgvStockLogs);
			this.Controls.Add(this.dgvCurrentStock);
			this.Controls.Add(this.grpStockControl);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmStock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Stock Management & Audit";
			this.Load += new System.EventHandler(this.frmStock_Load);
			this.grpStockControl.ResumeLayout(false);
			this.grpStockControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStockLogs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpStockControl;
		private System.Windows.Forms.Label lblSelectedProduct;
		private System.Windows.Forms.TextBox txtSelectedProduct;
		private System.Windows.Forms.Label lblAdjustmentQty;
		private System.Windows.Forms.TextBox txtAdjustmentQty;
		private System.Windows.Forms.Button btnRestock;
		private System.Windows.Forms.Button btnAdjust;
		private System.Windows.Forms.DataGridView dgvCurrentStock;
		private System.Windows.Forms.DataGridView dgvStockLogs;
		private System.Windows.Forms.Label lblInventoryTitle;
		private System.Windows.Forms.Label lblLogsTitle;
		private System.Windows.Forms.TextBox txtSearchStock;
		private System.Windows.Forms.Label lblSearchStock;
	}
}