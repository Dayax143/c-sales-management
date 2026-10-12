using System.Windows.Forms;

namespace key_luxery1
{
	partial class frmManageInvoice
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInvoice));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearchInvoiceNo = new System.Windows.Forms.TextBox();
			this.dgvInvoices = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnPrintInvoice = new System.Windows.Forms.Button();
			this.btnViewItems = new System.Windows.Forms.Button();
			this.btnDeleteInvoice = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(25, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(314, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Invoice Management";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.lblSearch.Location = new System.Drawing.Point(25, 80);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(156, 21);
			this.lblSearch.TabIndex = 1;
			this.lblSearch.Text = "Search Invoice No :";
			// 
			// txtSearchInvoiceNo
			// 
			this.txtSearchInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchInvoiceNo.Location = new System.Drawing.Point(192, 77);
			this.txtSearchInvoiceNo.Name = "txtSearchInvoiceNo";
			this.txtSearchInvoiceNo.Size = new System.Drawing.Size(220, 29);
			this.txtSearchInvoiceNo.TabIndex = 2;
			this.txtSearchInvoiceNo.TextChanged += new System.EventHandler(this.txtSearchInvoiceNo_TextChanged);
			// 
			// dgvInvoices
			// 
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.dgvInvoices.EnableHeadersVisualStyles = false;
			this.dgvInvoices.Location = new System.Drawing.Point(25, 125);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.RowHeadersVisible = false;
			this.dgvInvoices.RowHeadersWidth = 51;
			this.dgvInvoices.RowTemplate.Height = 30;
			this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInvoices.Size = new System.Drawing.Size(1110, 440);
			this.dgvInvoices.TabIndex = 3;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(420, 75);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(90, 32);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnPrintInvoice
			// 
			this.btnPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
			this.btnPrintInvoice.FlatAppearance.BorderSize = 0;
			this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
			this.btnPrintInvoice.Location = new System.Drawing.Point(582, 75);
			this.btnPrintInvoice.Name = "btnPrintInvoice";
			this.btnPrintInvoice.Size = new System.Drawing.Size(158, 32);
			this.btnPrintInvoice.TabIndex = 5;
			this.btnPrintInvoice.Text = "Print / Re-print";
			this.btnPrintInvoice.UseVisualStyleBackColor = false;
			this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
			// 
			// btnViewItems
			// 
			this.btnViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.btnViewItems.FlatAppearance.BorderSize = 0;
			this.btnViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewItems.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnViewItems.ForeColor = System.Drawing.Color.White;
			this.btnViewItems.Location = new System.Drawing.Point(748, 75);
			this.btnViewItems.Name = "btnViewItems";
			this.btnViewItems.Size = new System.Drawing.Size(115, 32);
			this.btnViewItems.TabIndex = 6;
			this.btnViewItems.Text = "View Items";
			this.btnViewItems.UseVisualStyleBackColor = false;
			this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
			// 
			// btnDeleteInvoice
			// 
			this.btnDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnDeleteInvoice.FlatAppearance.BorderSize = 0;
			this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
			this.btnDeleteInvoice.Location = new System.Drawing.Point(871, 75);
			this.btnDeleteInvoice.Name = "btnDeleteInvoice";
			this.btnDeleteInvoice.Size = new System.Drawing.Size(120, 32);
			this.btnDeleteInvoice.TabIndex = 7;
			this.btnDeleteInvoice.Text = "Delete";
			this.btnDeleteInvoice.UseVisualStyleBackColor = false;
			this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(999, 75);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(136, 32);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// frmManageInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1162, 595);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDeleteInvoice);
			this.Controls.Add(this.btnViewItems);
			this.Controls.Add(this.btnPrintInvoice);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvInvoices);
			this.Controls.Add(this.txtSearchInvoiceNo);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageInvoice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Invoice Management & Re-printing";
			this.Load += new System.EventHandler(this.frmManageInvoice_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSearch;
		public System.Windows.Forms.TextBox txtSearchInvoiceNo;
		public System.Windows.Forms.DataGridView dgvInvoices;
		public System.Windows.Forms.Button btnRefresh;
		public System.Windows.Forms.Button btnPrintInvoice;
		public System.Windows.Forms.Button btnViewItems;
		public System.Windows.Forms.Button btnDeleteInvoice;
		public System.Windows.Forms.Button btnClose;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	}
}