namespace key_luxery1
{
	partial class uInvoice
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

		#region Component Designer generated code

		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvInvoices = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.txtSearchInvoice = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnManageInvoice = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInvoices
			// 
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
			this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvInvoices.ColumnHeadersHeight = 35;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvInvoices.EnableHeadersVisualStyles = false;
			this.dgvInvoices.Location = new System.Drawing.Point(0, 100);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.RowHeadersVisible = false;
			this.dgvInvoices.RowHeadersWidth = 51;
			this.dgvInvoices.RowTemplate.Height = 30;
			this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInvoices.Size = new System.Drawing.Size(1014, 590);
			this.dgvInvoices.TabIndex = 0;
			this.dgvInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnManageInvoice);
			this.panel1.Controls.Add(this.btnRefresh);
			this.panel1.Controls.Add(this.txtSearchInvoice);
			this.panel1.Controls.Add(this.lblSearch);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1014, 100);
			this.panel1.TabIndex = 4;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(611, 35);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(100, 31);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// txtSearchInvoice
			// 
			this.txtSearchInvoice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchInvoice.Location = new System.Drawing.Point(346, 36);
			this.txtSearchInvoice.Name = "txtSearchInvoice";
			this.txtSearchInvoice.Size = new System.Drawing.Size(250, 29);
			this.txtSearchInvoice.TabIndex = 5;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblSearch.Location = new System.Drawing.Point(211, 39);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(129, 21);
			this.lblSearch.TabIndex = 4;
			this.lblSearch.Text = "Search Invoice :";
			// 
			// btnManageInvoice
			// 
			this.btnManageInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.btnManageInvoice.FlatAppearance.BorderSize = 0;
			this.btnManageInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnManageInvoice.ForeColor = System.Drawing.Color.White;
			this.btnManageInvoice.Location = new System.Drawing.Point(736, 36);
			this.btnManageInvoice.Name = "btnManageInvoice";
			this.btnManageInvoice.Size = new System.Drawing.Size(100, 31);
			this.btnManageInvoice.TabIndex = 6;
			this.btnManageInvoice.Text = "Manage";
			this.btnManageInvoice.UseVisualStyleBackColor = false;
			this.btnManageInvoice.Click += new System.EventHandler(this.btnManageInvoice_Click);
			// 
			// uInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.dgvInvoices);
			this.Controls.Add(this.panel1);
			this.Name = "uInvoice";
			this.Size = new System.Drawing.Size(1014, 690);
			this.Load += new System.EventHandler(this.uInvoice_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dgvInvoices;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Button btnRefresh;
		public System.Windows.Forms.TextBox txtSearchInvoice;
		private System.Windows.Forms.Label lblSearch;
		public System.Windows.Forms.Button btnManageInvoice;
	}
}