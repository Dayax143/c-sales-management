namespace key_luxery1
{
	partial class uSales
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
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblFilterInput = new System.Windows.Forms.Label();
			this.lblFilterBy = new System.Windows.Forms.Label();
			this.txtFilterInput = new System.Windows.Forms.TextBox();
			this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
			this.btnManageSale = new System.Windows.Forms.Button();
			this.btnNewSale = new System.Windows.Forms.Button();
			this.dgvSales = new System.Windows.Forms.DataGridView();
			this.panelBottomPagination = new System.Windows.Forms.Panel();
			this.btnPrev = new System.Windows.Forms.Button();
			this.lblPageInfo = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.panelTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
			this.panelBottomPagination.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTopBar
			// 
			this.panelTopBar.BackColor = System.Drawing.Color.White;
			this.panelTopBar.Controls.Add(this.btnRefresh);
			this.panelTopBar.Controls.Add(this.lblFilterInput);
			this.panelTopBar.Controls.Add(this.lblFilterBy);
			this.panelTopBar.Controls.Add(this.txtFilterInput);
			this.panelTopBar.Controls.Add(this.cmbFilterCategory);
			this.panelTopBar.Controls.Add(this.btnManageSale);
			this.panelTopBar.Controls.Add(this.btnNewSale);
			this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopBar.Location = new System.Drawing.Point(0, 0);
			this.panelTopBar.Name = "panelTopBar";
			this.panelTopBar.Size = new System.Drawing.Size(1219, 90);
			this.panelTopBar.TabIndex = 5;
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
			// lblFilterInput
			// 
			this.lblFilterInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFilterInput.AutoSize = true;
			this.lblFilterInput.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblFilterInput.Location = new System.Drawing.Point(715, 34);
			this.lblFilterInput.Name = "lblFilterInput";
			this.lblFilterInput.Size = new System.Drawing.Size(95, 20);
			this.lblFilterInput.TabIndex = 4;
			this.lblFilterInput.Text = "Search/Filter:";
			// 
			// lblFilterBy
			// 
			this.lblFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFilterBy.AutoSize = true;
			this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblFilterBy.Location = new System.Drawing.Point(1015, 10);
			this.lblFilterBy.Name = "lblFilterBy";
			this.lblFilterBy.Size = new System.Drawing.Size(65, 20);
			this.lblFilterBy.TabIndex = 4;
			this.lblFilterBy.Text = "Filter by:";
			// 
			// txtFilterInput
			// 
			this.txtFilterInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilterInput.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtFilterInput.Location = new System.Drawing.Point(825, 32);
			this.txtFilterInput.Name = "txtFilterInput";
			this.txtFilterInput.Size = new System.Drawing.Size(180, 29);
			this.txtFilterInput.TabIndex = 3;
			this.txtFilterInput.TextChanged += new System.EventHandler(this.txtFilterInput_TextChanged);
			// 
			// cmbFilterCategory
			// 
			this.cmbFilterCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbFilterCategory.FormattingEnabled = true;
			this.cmbFilterCategory.Items.AddRange(new object[] {
            "All Sales",
            "Customer Name",
            "Payment Type"});
			this.cmbFilterCategory.Location = new System.Drawing.Point(1015, 32);
			this.cmbFilterCategory.Name = "cmbFilterCategory";
			this.cmbFilterCategory.Size = new System.Drawing.Size(175, 29);
			this.cmbFilterCategory.TabIndex = 2;
			this.cmbFilterCategory.Text = "All Sales";
			// 
			// btnManageSale
			// 
			this.btnManageSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnManageSale.FlatAppearance.BorderSize = 0;
			this.btnManageSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageSale.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnManageSale.ForeColor = System.Drawing.Color.White;
			this.btnManageSale.Location = new System.Drawing.Point(237, 28);
			this.btnManageSale.Name = "btnManageSale";
			this.btnManageSale.Size = new System.Drawing.Size(115, 35);
			this.btnManageSale.TabIndex = 5;
			this.btnManageSale.Text = "Manage Sale";
			this.btnManageSale.UseVisualStyleBackColor = false;
			this.btnManageSale.Visible = false;
			this.btnManageSale.Click += new System.EventHandler(this.btnManageSale_Click);
			// 
			// btnNewSale
			// 
			this.btnNewSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnNewSale.FlatAppearance.BorderSize = 0;
			this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewSale.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnNewSale.ForeColor = System.Drawing.Color.White;
			this.btnNewSale.Location = new System.Drawing.Point(20, 26);
			this.btnNewSale.Name = "btnNewSale";
			this.btnNewSale.Size = new System.Drawing.Size(105, 35);
			this.btnNewSale.TabIndex = 5;
			this.btnNewSale.Text = "+ New Sale";
			this.btnNewSale.UseVisualStyleBackColor = false;
			this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
			// 
			// dgvSales
			// 
			this.dgvSales.AllowUserToAddRows = false;
			this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSales.BackgroundColor = System.Drawing.Color.White;
			this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSales.ColumnHeadersHeight = 40;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSales.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSales.EnableHeadersVisualStyles = false;
			this.dgvSales.Location = new System.Drawing.Point(0, 90);
			this.dgvSales.Name = "dgvSales";
			this.dgvSales.ReadOnly = true;
			this.dgvSales.RowHeadersVisible = false;
			this.dgvSales.RowHeadersWidth = 51;
			this.dgvSales.RowTemplate.Height = 32;
			this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSales.Size = new System.Drawing.Size(1219, 624);
			this.dgvSales.TabIndex = 6;
			// 
			// panelBottomPagination
			// 
			this.panelBottomPagination.BackColor = System.Drawing.Color.White;
			this.panelBottomPagination.Controls.Add(this.btnPrev);
			this.panelBottomPagination.Controls.Add(this.lblPageInfo);
			this.panelBottomPagination.Controls.Add(this.btnNext);
			this.panelBottomPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottomPagination.Location = new System.Drawing.Point(0, 714);
			this.panelBottomPagination.Name = "panelBottomPagination";
			this.panelBottomPagination.Size = new System.Drawing.Size(1219, 50);
			this.panelBottomPagination.TabIndex = 8;
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
			// uSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.dgvSales);
			this.Controls.Add(this.panelBottomPagination);
			this.Controls.Add(this.panelTopBar);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "uSales";
			this.Size = new System.Drawing.Size(1219, 764);
			this.Load += new System.EventHandler(this.uSales_Load);
			this.panelTopBar.ResumeLayout(false);
			this.panelTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
			this.panelBottomPagination.ResumeLayout(false);
			this.panelBottomPagination.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTopBar;
		private System.Windows.Forms.Label lblFilterInput;
		private System.Windows.Forms.Label lblFilterBy;
		private System.Windows.Forms.ComboBox cmbFilterCategory;
		private System.Windows.Forms.Button btnManageSale;
		private System.Windows.Forms.Button btnNewSale;
		private System.Windows.Forms.DataGridView dgvSales;
		private System.Windows.Forms.Button btnRefresh;
		public System.Windows.Forms.TextBox txtFilterInput;
		public System.Windows.Forms.Panel panelBottomPagination;
		public System.Windows.Forms.Button btnPrev;
		public System.Windows.Forms.Label lblPageInfo;
		public System.Windows.Forms.Button btnNext;
	}
}