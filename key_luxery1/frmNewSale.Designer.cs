namespace key_luxery1
{
	partial class frmNewSale
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
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearchProduct = new System.Windows.Forms.TextBox();
			this.lvProducts = new System.Windows.Forms.ListView();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblNetPriceTitle = new System.Windows.Forms.Label();
			this.lblNetPriceValue = new System.Windows.Forms.Label();
			this.btnSaveSale = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(30, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(301, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "New Sales Checkout";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSearch.Location = new System.Drawing.Point(30, 78);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(122, 21);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search Product :";
			// 
			// txtSearchProduct
			// 
			this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchProduct.Location = new System.Drawing.Point(173, 75);
			this.txtSearchProduct.Name = "txtSearchProduct";
			this.txtSearchProduct.Size = new System.Drawing.Size(507, 29);
			this.txtSearchProduct.TabIndex = 0;
			this.txtSearchProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lvProducts
			// 
			this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lvProducts.FullRowSelect = true;
			this.lvProducts.GridLines = true;
			this.lvProducts.HideSelection = false;
			this.lvProducts.Location = new System.Drawing.Point(173, 115);
			this.lvProducts.Name = "lvProducts";
			this.lvProducts.Size = new System.Drawing.Size(507, 220);
			this.lvProducts.TabIndex = 1;
			this.lvProducts.UseCompatibleStateImageBehavior = false;
			this.lvProducts.View = System.Windows.Forms.View.Details;
			this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblDiscount.Location = new System.Drawing.Point(30, 360);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(78, 21);
			this.lblDiscount.TabIndex = 0;
			this.lblDiscount.Text = "Discount :";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtDiscount.Location = new System.Drawing.Point(145, 357);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(150, 29);
			this.txtDiscount.TabIndex = 2;
			this.txtDiscount.Text = "0.00";
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// lblNetPriceTitle
			// 
			this.lblNetPriceTitle.AutoSize = true;
			this.lblNetPriceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblNetPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblNetPriceTitle.Location = new System.Drawing.Point(420, 357);
			this.lblNetPriceTitle.Name = "lblNetPriceTitle";
			this.lblNetPriceTitle.Size = new System.Drawing.Size(111, 28);
			this.lblNetPriceTitle.TabIndex = 0;
			this.lblNetPriceTitle.Text = "Net Price :";
			// 
			// lblNetPriceValue
			// 
			this.lblNetPriceValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblNetPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.lblNetPriceValue.Location = new System.Drawing.Point(515, 350);
			this.lblNetPriceValue.Name = "lblNetPriceValue";
			this.lblNetPriceValue.Size = new System.Drawing.Size(165, 35);
			this.lblNetPriceValue.TabIndex = 0;
			this.lblNetPriceValue.Text = "$0.00";
			this.lblNetPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSaveSale
			// 
			this.btnSaveSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSaveSale.FlatAppearance.BorderSize = 0;
			this.btnSaveSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSale.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnSaveSale.ForeColor = System.Drawing.Color.White;
			this.btnSaveSale.Location = new System.Drawing.Point(515, 410);
			this.btnSaveSale.Name = "btnSaveSale";
			this.btnSaveSale.Size = new System.Drawing.Size(165, 42);
			this.btnSaveSale.TabIndex = 3;
			this.btnSaveSale.Text = "Save Sale";
			this.btnSaveSale.UseVisualStyleBackColor = false;
			this.btnSaveSale.Click += new System.EventHandler(this.btnSaveSale_Click);
			// 
			// frmNewSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(715, 480);
			this.Controls.Add(this.btnSaveSale);
			this.Controls.Add(this.lblNetPriceValue);
			this.Controls.Add(this.lblNetPriceTitle);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.lvProducts);
			this.Controls.Add(this.txtSearchProduct);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmNewSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - New Sale Checkout";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSearch;
		public System.Windows.Forms.TextBox txtSearchProduct;
		public System.Windows.Forms.ListView lvProducts;
		private System.Windows.Forms.Label lblDiscount;
		public System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label lblNetPriceTitle;
		public System.Windows.Forms.Label lblNetPriceValue;
		public System.Windows.Forms.Button btnSaveSale;
	}
}