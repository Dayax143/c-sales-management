namespace key_luxery1
{
	partial class frmRecoverProduct
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTopBar = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnRecover = new System.Windows.Forms.Button();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblCategoryFilter = new System.Windows.Forms.Label();
			this.txtSearchFilter = new System.Windows.Forms.TextBox();
			this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.panelTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTopBar
			// 
			this.panelTopBar.BackColor = System.Drawing.Color.White;
			this.panelTopBar.Controls.Add(this.btnRefresh);
			this.panelTopBar.Controls.Add(this.btnRecover);
			this.panelTopBar.Controls.Add(this.lblSearch);
			this.panelTopBar.Controls.Add(this.lblCategoryFilter);
			this.panelTopBar.Controls.Add(this.txtSearchFilter);
			this.panelTopBar.Controls.Add(this.cmbFilterCategory);
			this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopBar.Location = new System.Drawing.Point(0, 0);
			this.panelTopBar.Name = "panelTopBar";
			this.panelTopBar.Size = new System.Drawing.Size(1201, 90);
			this.panelTopBar.TabIndex = 0;
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
			// 
			// btnRecover
			// 
			this.btnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnRecover.FlatAppearance.BorderSize = 0;
			this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecover.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRecover.ForeColor = System.Drawing.Color.White;
			this.btnRecover.Location = new System.Drawing.Point(20, 26);
			this.btnRecover.Name = "btnRecover";
			this.btnRecover.Size = new System.Drawing.Size(105, 35);
			this.btnRecover.TabIndex = 5;
			this.btnRecover.Text = "+ Recover";
			this.btnRecover.UseVisualStyleBackColor = false;
			this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblSearch.Location = new System.Drawing.Point(681, 34);
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
			this.lblCategoryFilter.Location = new System.Drawing.Point(997, 10);
			this.lblCategoryFilter.Name = "lblCategoryFilter";
			this.lblCategoryFilter.Size = new System.Drawing.Size(72, 20);
			this.lblCategoryFilter.TabIndex = 4;
			this.lblCategoryFilter.Text = "Category:";
			// 
			// txtSearchFilter
			// 
			this.txtSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchFilter.Location = new System.Drawing.Point(807, 32);
			this.txtSearchFilter.Name = "txtSearchFilter";
			this.txtSearchFilter.Size = new System.Drawing.Size(180, 29);
			this.txtSearchFilter.TabIndex = 3;
			// 
			// cmbFilterCategory
			// 
			this.cmbFilterCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbFilterCategory.FormattingEnabled = true;
			this.cmbFilterCategory.Location = new System.Drawing.Point(997, 32);
			this.cmbFilterCategory.Name = "cmbFilterCategory";
			this.cmbFilterCategory.Size = new System.Drawing.Size(175, 29);
			this.cmbFilterCategory.TabIndex = 2;
			this.cmbFilterCategory.Text = "All Categories";
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvProducts.ColumnHeadersHeight = 40;
			this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.EnableHeadersVisualStyles = false;
			this.dgvProducts.Location = new System.Drawing.Point(0, 90);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.RowHeadersWidth = 51;
			this.dgvProducts.RowTemplate.Height = 32;
			this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProducts.Size = new System.Drawing.Size(1201, 627);
			this.dgvProducts.TabIndex = 1;
			// 
			// chkSelect
			// 
			this.chkSelect.HeaderText = "Select";
			this.chkSelect.MinimumWidth = 6;
			this.chkSelect.Name = "chkSelect";
			// 
			// frmRecoverProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1201, 717);
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.panelTopBar);
			this.Name = "frmRecoverProduct";
			this.Load += new System.EventHandler(this.frmRecoverProduct_Load);
			this.panelTopBar.ResumeLayout(false);
			this.panelTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);

			}



			#endregion

			private System.Windows.Forms.Panel panelTopBar;
			private System.Windows.Forms.Label lblSearch;
			private System.Windows.Forms.Label lblCategoryFilter;
			public System.Windows.Forms.TextBox txtSearchFilter;
			public System.Windows.Forms.ComboBox cmbFilterCategory;
			private System.Windows.Forms.Button btnRecover;
			private System.Windows.Forms.Button btnRefresh;
			private System.Windows.Forms.DataGridView dgvProducts;
			private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
		}
}