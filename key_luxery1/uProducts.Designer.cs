namespace key_luxery1
{
	partial class uProducts
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTopBar = new System.Windows.Forms.Panel();
			this.btnDeleteSelected = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnStock = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblCategoryFilter = new System.Windows.Forms.Label();
			this.txtSearchFilter = new System.Windows.Forms.TextBox();
			this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.panelBottomPagination = new System.Windows.Forms.Panel();
			this.btnPrev = new System.Windows.Forms.Button();
			this.lblPageInfo = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.panelTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.panelBottomPagination.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTopBar
			// 
			this.panelTopBar.BackColor = System.Drawing.Color.White;
			this.panelTopBar.Controls.Add(this.btnDeleteSelected);
			this.panelTopBar.Controls.Add(this.btnRefresh);
			this.panelTopBar.Controls.Add(this.btnStock);
			this.panelTopBar.Controls.Add(this.btnAddProduct);
			this.panelTopBar.Controls.Add(this.lblSearch);
			this.panelTopBar.Controls.Add(this.lblCategoryFilter);
			this.panelTopBar.Controls.Add(this.txtSearchFilter);
			this.panelTopBar.Controls.Add(this.cmbFilterCategory);
			this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopBar.Location = new System.Drawing.Point(0, 0);
			this.panelTopBar.Name = "panelTopBar";
			this.panelTopBar.Size = new System.Drawing.Size(1219, 90);
			this.panelTopBar.TabIndex = 0;
			// 
			// btnDeleteSelected
			// 
			this.btnDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
			this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
			this.btnDeleteSelected.Location = new System.Drawing.Point(355, 26);
			this.btnDeleteSelected.Name = "btnDeleteSelected";
			this.btnDeleteSelected.Size = new System.Drawing.Size(130, 35);
			this.btnDeleteSelected.TabIndex = 7;
			this.btnDeleteSelected.Text = "Delete Selected";
			this.btnDeleteSelected.UseVisualStyleBackColor = false;
			this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
			this.btnExport.FlatAppearance.BorderSize = 0;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.Location = new System.Drawing.Point(927, 10);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(110, 35);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "Export CSV";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(131, 26);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(100, 35);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnStock
			// 
			this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnStock.FlatAppearance.BorderSize = 0;
			this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnStock.ForeColor = System.Drawing.Color.White;
			this.btnStock.Location = new System.Drawing.Point(240, 26);
			this.btnStock.Name = "btnStock";
			this.btnStock.Size = new System.Drawing.Size(105, 35);
			this.btnStock.TabIndex = 5;
			this.btnStock.Text = "Stock";
			this.btnStock.UseVisualStyleBackColor = false;
			this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnAddProduct.FlatAppearance.BorderSize = 0;
			this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnAddProduct.ForeColor = System.Drawing.Color.White;
			this.btnAddProduct.Location = new System.Drawing.Point(20, 26);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(105, 35);
			this.btnAddProduct.TabIndex = 5;
			this.btnAddProduct.Text = "+ Add Item";
			this.btnAddProduct.UseVisualStyleBackColor = false;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblSearch.Location = new System.Drawing.Point(699, 34);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(111, 20);
			this.lblSearch.TabIndex = 4;
			this.lblSearch.Text = "Search Product:";
			// 
			// lblCategoryFilter
			// 
			this.lblCategoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCategoryFilter.AutoSize = true;
			this.lblCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblCategoryFilter.Location = new System.Drawing.Point(1015, 10);
			this.lblCategoryFilter.Name = "lblCategoryFilter";
			this.lblCategoryFilter.Size = new System.Drawing.Size(72, 20);
			this.lblCategoryFilter.TabIndex = 4;
			this.lblCategoryFilter.Text = "Category:";
			// 
			// txtSearchFilter
			// 
			this.txtSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchFilter.Location = new System.Drawing.Point(825, 32);
			this.txtSearchFilter.Name = "txtSearchFilter";
			this.txtSearchFilter.Size = new System.Drawing.Size(180, 29);
			this.txtSearchFilter.TabIndex = 3;
			this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
			// 
			// cmbFilterCategory
			// 
			this.cmbFilterCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbFilterCategory.FormattingEnabled = true;
			this.cmbFilterCategory.Location = new System.Drawing.Point(1015, 32);
			this.cmbFilterCategory.Name = "cmbFilterCategory";
			this.cmbFilterCategory.Size = new System.Drawing.Size(175, 29);
			this.cmbFilterCategory.TabIndex = 2;
			this.cmbFilterCategory.Text = "All Categories";
			this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategory_SelectedIndexChanged);
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProducts.ColumnHeadersHeight = 40;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Location = new System.Drawing.Point(0, 90);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 51;
			this.dgvProducts.RowTemplate.Height = 32;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(1219, 624);
			this.dgvProducts.TabIndex = 1;
			// 
			// chkSelect
			// 
			this.chkSelect.HeaderText = "Select";
			this.chkSelect.MinimumWidth = 6;
			this.chkSelect.Name = "chkSelect";
			// 
			// panelBottomPagination
			// 
			this.panelBottomPagination.BackColor = System.Drawing.Color.White;
			this.panelBottomPagination.Controls.Add(this.btnPrev);
			this.panelBottomPagination.Controls.Add(this.btnExport);
			this.panelBottomPagination.Controls.Add(this.lblPageInfo);
			this.panelBottomPagination.Controls.Add(this.btnImport);
			this.panelBottomPagination.Controls.Add(this.btnNext);
			this.panelBottomPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottomPagination.Location = new System.Drawing.Point(0, 714);
			this.panelBottomPagination.Name = "panelBottomPagination";
			this.panelBottomPagination.Size = new System.Drawing.Size(1219, 50);
			this.panelBottomPagination.TabIndex = 2;
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(20, 10);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(90, 30);
			this.btnPrev.TabIndex = 0;
			this.btnPrev.Text = "< Previous";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// lblPageInfo
			// 
			this.lblPageInfo.AutoSize = true;
			this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblPageInfo.Location = new System.Drawing.Point(130, 14);
			this.lblPageInfo.Name = "lblPageInfo";
			this.lblPageInfo.Size = new System.Drawing.Size(94, 21);
			this.lblPageInfo.TabIndex = 1;
			this.lblPageInfo.Text = "Page 1 of 1";
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(240, 10);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(90, 30);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next >";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnImport.FlatAppearance.BorderSize = 0;
			this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnImport.ForeColor = System.Drawing.Color.White;
			this.btnImport.Location = new System.Drawing.Point(1052, 10);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(138, 35);
			this.btnImport.TabIndex = 5;
			this.btnImport.Text = "Import list";
			this.btnImport.UseVisualStyleBackColor = false;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// uProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.panelTopBar);
			this.Controls.Add(this.panelBottomPagination);
			this.Name = "uProducts";
			this.Size = new System.Drawing.Size(1219, 764);
			this.Load += new System.EventHandler(this.uProducts_Load);
			this.panelTopBar.ResumeLayout(false);
			this.panelTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.panelBottomPagination.ResumeLayout(false);
			this.panelBottomPagination.PerformLayout();
			this.ResumeLayout(false);

		}

			// Add these control declarations at the bottom of uProducts.Designer.cs
public System.Windows.Forms.Panel panelBottomPagination;
		public System.Windows.Forms.Button btnPrev;
		public System.Windows.Forms.Button btnNext;
		public System.Windows.Forms.Label lblPageInfo;

	

		#endregion

		private System.Windows.Forms.Panel panelTopBar;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblCategoryFilter;
		public System.Windows.Forms.TextBox txtSearchFilter;
		public System.Windows.Forms.ComboBox cmbFilterCategory;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridView dgvProducts;
		private System.Windows.Forms.Button btnStock;
		public System.Windows.Forms.Button btnDeleteSelected;
		private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
		private System.Windows.Forms.Button btnImport;
	}
}