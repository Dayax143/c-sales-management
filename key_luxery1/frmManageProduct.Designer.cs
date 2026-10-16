namespace key_luxery1
{
	partial class frmManageProduct
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpProductDetails = new System.Windows.Forms.GroupBox();
			this.lblID = new System.Windows.Forms.Label();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.lblCost = new System.Windows.Forms.Label();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.grpSearch = new System.Windows.Forms.GroupBox();
			this.lblSearchBy = new System.Windows.Forms.Label();
			this.cmbSearchBy = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.grpProductDetails.SuspendLayout();
			this.grpSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(25, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(297, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Product Management";
			// 
			// grpProductDetails
			// 
			this.grpProductDetails.Controls.Add(this.lblID);
			this.grpProductDetails.Controls.Add(this.txtProductID);
			this.grpProductDetails.Controls.Add(this.lblName);
			this.grpProductDetails.Controls.Add(this.txtProductName);
			this.grpProductDetails.Controls.Add(this.lblCategory);
			this.grpProductDetails.Controls.Add(this.cmbCategory);
			this.grpProductDetails.Controls.Add(this.lblQuantity);
			this.grpProductDetails.Controls.Add(this.txtStock);
			this.grpProductDetails.Controls.Add(this.lblCost);
			this.grpProductDetails.Controls.Add(this.txtCost);
			this.grpProductDetails.Controls.Add(this.label1);
			this.grpProductDetails.Controls.Add(this.lblPrice);
			this.grpProductDetails.Controls.Add(this.txtBarcode);
			this.grpProductDetails.Controls.Add(this.txtPrice);
			this.grpProductDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.grpProductDetails.Location = new System.Drawing.Point(25, 70);
			this.grpProductDetails.Name = "grpProductDetails";
			this.grpProductDetails.Size = new System.Drawing.Size(590, 335);
			this.grpProductDetails.TabIndex = 1;
			this.grpProductDetails.TabStop = false;
			this.grpProductDetails.Text = "Product Information";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblID.Location = new System.Drawing.Point(25, 38);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(90, 21);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "Product ID :";
			// 
			// txtProductID
			// 
			this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtProductID.Location = new System.Drawing.Point(160, 35);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(424, 29);
			this.txtProductID.TabIndex = 20;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblName.Location = new System.Drawing.Point(25, 78);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(117, 21);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Product Name :";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtProductName.Location = new System.Drawing.Point(160, 75);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(424, 29);
			this.txtProductName.TabIndex = 1;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblCategory.Location = new System.Drawing.Point(25, 118);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(80, 21);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category :";
			// 
			// cmbCategory
			// 
			this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Items.AddRange(new object[] {
            "Cadaro",
            "Saacado",
            "Other"});
			this.cmbCategory.Location = new System.Drawing.Point(160, 115);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(424, 29);
			this.cmbCategory.TabIndex = 2;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblQuantity.Location = new System.Drawing.Point(25, 158);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(118, 21);
			this.lblQuantity.TabIndex = 0;
			this.lblQuantity.Text = "Stock Quantity :";
			// 
			// txtStock
			// 
			this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtStock.Location = new System.Drawing.Point(160, 155);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(424, 29);
			this.txtStock.TabIndex = 3;
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblCost.Location = new System.Drawing.Point(25, 198);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(81, 21);
			this.lblCost.TabIndex = 0;
			this.lblCost.Text = "Unit Cost :";
			// 
			// txtCost
			// 
			this.txtCost.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtCost.Location = new System.Drawing.Point(160, 195);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(424, 29);
			this.txtCost.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.label1.Location = new System.Drawing.Point(25, 284);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Barcode :";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblPrice.Location = new System.Drawing.Point(25, 238);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(84, 21);
			this.lblPrice.TabIndex = 0;
			this.lblPrice.Text = "Sale Price :";
			// 
			// txtBarcode
			// 
			this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtBarcode.Location = new System.Drawing.Point(160, 281);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(424, 29);
			this.txtBarcode.TabIndex = 6;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtPrice.Location = new System.Drawing.Point(160, 235);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(424, 29);
			this.txtPrice.TabIndex = 5;
			// 
			// grpSearch
			// 
			this.grpSearch.Controls.Add(this.lblSearchBy);
			this.grpSearch.Controls.Add(this.cmbSearchBy);
			this.grpSearch.Controls.Add(this.lblSearch);
			this.grpSearch.Controls.Add(this.txtSearch);
			this.grpSearch.Controls.Add(this.btnGet);
			this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.grpSearch.Location = new System.Drawing.Point(25, 411);
			this.grpSearch.Name = "grpSearch";
			this.grpSearch.Size = new System.Drawing.Size(590, 115);
			this.grpSearch.TabIndex = 7;
			this.grpSearch.TabStop = false;
			this.grpSearch.Text = "Quick Search";
			// 
			// lblSearchBy
			// 
			this.lblSearchBy.AutoSize = true;
			this.lblSearchBy.Location = new System.Drawing.Point(25, 28);
			this.lblSearchBy.Name = "lblSearchBy";
			this.lblSearchBy.Size = new System.Drawing.Size(80, 20);
			this.lblSearchBy.TabIndex = 0;
			this.lblSearchBy.Text = "Search By :";
			// 
			// cmbSearchBy
			// 
			this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearchBy.FormattingEnabled = true;
			this.cmbSearchBy.Items.AddRange(new object[] {
            "Product Name",
            "Barcode"});
			this.cmbSearchBy.Location = new System.Drawing.Point(155, 25);
			this.cmbSearchBy.Name = "cmbSearchBy";
			this.cmbSearchBy.Size = new System.Drawing.Size(290, 28);
			this.cmbSearchBy.TabIndex = 0;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(25, 68);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(74, 20);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Keyword :";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(155, 65);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(290, 27);
			this.txtSearch.TabIndex = 1;
			// 
			// btnGet
			// 
			this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGet.ForeColor = System.Drawing.Color.White;
			this.btnGet.Location = new System.Drawing.Point(451, 63);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(95, 30);
			this.btnGet.TabIndex = 2;
			this.btnGet.Text = "Search";
			this.btnGet.UseVisualStyleBackColor = false;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(139, 537);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(90, 38);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.btnUpdate.Location = new System.Drawing.Point(239, 537);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 38);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(439, 537);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(92, 38);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClean_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(339, 537);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 38);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmManageProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(638, 587);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.grpSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.grpProductDetails);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Manage Product";
			this.grpProductDetails.ResumeLayout(false);
			this.grpProductDetails.PerformLayout();
			this.grpSearch.ResumeLayout(false);
			this.grpSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpProductDetails;
		private System.Windows.Forms.Label lblID;
		public System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label lblName;
		public System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblCategory;
		public System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblQuantity;
		public System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label lblCost;
		public System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.Label lblPrice;
		public System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.GroupBox grpSearch;
		private System.Windows.Forms.Label lblSearchBy;
		public System.Windows.Forms.ComboBox cmbSearchBy;
		private System.Windows.Forms.Label lblSearch;
		public System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnGet;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.Button btnUpdate;
		public System.Windows.Forms.Button btnClear;
		public System.Windows.Forms.Button btnDelete;
	}
}