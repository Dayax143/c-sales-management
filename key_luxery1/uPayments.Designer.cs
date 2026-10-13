namespace key_luxery1
{
	partial class uPayments
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.cmbFilterMethod = new System.Windows.Forms.ComboBox();
			this.lblFilterMethod = new System.Windows.Forms.Label();
			this.txtSearchFilter = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dgvPayments = new System.Windows.Forms.DataGridView();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.White;
			this.panelTop.Controls.Add(this.btnExport);
			this.panelTop.Controls.Add(this.btnRefresh);
			this.panelTop.Controls.Add(this.cmbFilterMethod);
			this.panelTop.Controls.Add(this.lblFilterMethod);
			this.panelTop.Controls.Add(this.txtSearchFilter);
			this.panelTop.Controls.Add(this.lblSearch);
			this.panelTop.Controls.Add(this.lblTitle);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(1219, 90);
			this.panelTop.TabIndex = 0;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnExport.FlatAppearance.BorderSize = 0;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.Location = new System.Drawing.Point(940, 28);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(120, 35);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "Export CSV";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(1075, 28);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(110, 35);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// cmbFilterMethod
			// 
			this.cmbFilterMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFilterMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbFilterMethod.FormattingEnabled = true;
			this.cmbFilterMethod.Location = new System.Drawing.Point(699, 34);
			this.cmbFilterMethod.Name = "cmbFilterMethod";
			this.cmbFilterMethod.Size = new System.Drawing.Size(180, 29);
			this.cmbFilterMethod.TabIndex = 4;
			this.cmbFilterMethod.SelectedIndexChanged += new System.EventHandler(this.cmbFilterMethod_SelectedIndexChanged);
			// 
			// lblFilterMethod
			// 
			this.lblFilterMethod.AutoSize = true;
			this.lblFilterMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblFilterMethod.Location = new System.Drawing.Point(584, 36);
			this.lblFilterMethod.Name = "lblFilterMethod";
			this.lblFilterMethod.Size = new System.Drawing.Size(109, 21);
			this.lblFilterMethod.TabIndex = 3;
			this.lblFilterMethod.Text = "Payment Type:";
			// 
			// txtSearchFilter
			// 
			this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtSearchFilter.Location = new System.Drawing.Point(349, 32);
			this.txtSearchFilter.Name = "txtSearchFilter";
			this.txtSearchFilter.Size = new System.Drawing.Size(210, 29);
			this.txtSearchFilter.TabIndex = 2;
			this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSearch.Location = new System.Drawing.Point(289, 36);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(64, 21);
			this.lblSearch.TabIndex = 1;
			this.lblSearch.Text = "Search :";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(18, 24);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(226, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Payment Ledger";
			// 
			// dgvPayments
			// 
			this.dgvPayments.AllowUserToAddRows = false;
			this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
			this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPayments.ColumnHeadersHeight = 38;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPayments.EnableHeadersVisualStyles = false;
			this.dgvPayments.Location = new System.Drawing.Point(0, 90);
			this.dgvPayments.Name = "dgvPayments";
			this.dgvPayments.ReadOnly = true;
			this.dgvPayments.RowHeadersVisible = false;
			this.dgvPayments.RowHeadersWidth = 51;
			this.dgvPayments.RowTemplate.Height = 32;
			this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPayments.Size = new System.Drawing.Size(1219, 660);
			this.dgvPayments.TabIndex = 1;
			this.dgvPayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellDoubleClick);
			// 
			// uPayments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.dgvPayments);
			this.Controls.Add(this.panelTop);
			this.Name = "uPayments";
			this.Size = new System.Drawing.Size(1219, 750);
			this.Load += new System.EventHandler(this.uPayments_Load);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtSearchFilter;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.ComboBox cmbFilterMethod;
		private System.Windows.Forms.Label lblFilterMethod;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridView dgvPayments;
	}
}