namespace key_luxery1
{
	partial class frmExpense
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpExpenseDetails = new System.Windows.Forms.GroupBox();
			this.pnlActions = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.lblNotes = new System.Windows.Forms.Label();
			this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.dgvExpenses = new System.Windows.Forms.DataGridView();
			this.pnlGridHeader = new System.Windows.Forms.Panel();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.panelHeader.SuspendLayout();
			this.grpExpenseDetails.SuspendLayout();
			this.pnlActions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
			this.pnlGridHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.panelHeader.Controls.Add(this.lblTitle);
			this.panelHeader.Controls.Add(this.pnlGridHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(976, 60);
			this.panelHeader.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(20, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(299, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Expense Management";
			// 
			// grpExpenseDetails
			// 
			this.grpExpenseDetails.Controls.Add(this.pnlActions);
			this.grpExpenseDetails.Controls.Add(this.txtNotes);
			this.grpExpenseDetails.Controls.Add(this.lblNotes);
			this.grpExpenseDetails.Controls.Add(this.dtpExpenseDate);
			this.grpExpenseDetails.Controls.Add(this.lblDate);
			this.grpExpenseDetails.Controls.Add(this.txtAmount);
			this.grpExpenseDetails.Controls.Add(this.lblAmount);
			this.grpExpenseDetails.Controls.Add(this.cmbCategory);
			this.grpExpenseDetails.Controls.Add(this.lblCategory);
			this.grpExpenseDetails.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpExpenseDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpExpenseDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.grpExpenseDetails.Location = new System.Drawing.Point(0, 60);
			this.grpExpenseDetails.Name = "grpExpenseDetails";
			this.grpExpenseDetails.Size = new System.Drawing.Size(357, 602);
			this.grpExpenseDetails.TabIndex = 1;
			this.grpExpenseDetails.TabStop = false;
			this.grpExpenseDetails.Text = "Expense Details";
			// 
			// pnlActions
			// 
			this.pnlActions.Controls.Add(this.btnDelete);
			this.pnlActions.Controls.Add(this.btnClear);
			this.pnlActions.Controls.Add(this.btnSave);
			this.pnlActions.Location = new System.Drawing.Point(20, 410);
			this.pnlActions.Name = "pnlActions";
			this.pnlActions.Size = new System.Drawing.Size(300, 130);
			this.pnlActions.TabIndex = 8;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(155, 58);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(145, 35);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(0, 58);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(145, 35);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(0, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(300, 38);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Expense";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNotes
			// 
			this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNotes.Location = new System.Drawing.Point(20, 270);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(300, 120);
			this.txtNotes.TabIndex = 7;
			// 
			// lblNotes
			// 
			this.lblNotes.AutoSize = true;
			this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNotes.Location = new System.Drawing.Point(20, 245);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(92, 21);
			this.lblNotes.TabIndex = 6;
			this.lblNotes.Text = "Description:";
			// 
			// dtpExpenseDate
			// 
			this.dtpExpenseDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpExpenseDate.Location = new System.Drawing.Point(20, 200);
			this.dtpExpenseDate.Name = "dtpExpenseDate";
			this.dtpExpenseDate.Size = new System.Drawing.Size(300, 30);
			this.dtpExpenseDate.TabIndex = 5;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(20, 175);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(45, 21);
			this.lblDate.TabIndex = 4;
			this.lblDate.Text = "Date:";
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtAmount.Location = new System.Drawing.Point(20, 130);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(300, 30);
			this.txtAmount.TabIndex = 3;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmount.Location = new System.Drawing.Point(20, 105);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(69, 21);
			this.lblAmount.TabIndex = 2;
			this.lblAmount.Text = "Amount:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(20, 60);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(300, 31);
			this.cmbCategory.TabIndex = 1;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(20, 35);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(76, 21);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category:";
			// 
			// dgvExpenses
			// 
			this.dgvExpenses.AllowUserToAddRows = false;
			this.dgvExpenses.AllowUserToDeleteRows = false;
			this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvExpenses.BackgroundColor = System.Drawing.Color.White;
			this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvExpenses.ColumnHeadersHeight = 35;
			this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvExpenses.EnableHeadersVisualStyles = false;
			this.dgvExpenses.Location = new System.Drawing.Point(357, 60);
			this.dgvExpenses.MultiSelect = false;
			this.dgvExpenses.Name = "dgvExpenses";
			this.dgvExpenses.ReadOnly = true;
			this.dgvExpenses.RowHeadersVisible = false;
			this.dgvExpenses.RowHeadersWidth = 51;
			this.dgvExpenses.RowTemplate.Height = 30;
			this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvExpenses.Size = new System.Drawing.Size(619, 602);
			this.dgvExpenses.TabIndex = 3;
			// 
			// pnlGridHeader
			// 
			this.pnlGridHeader.Controls.Add(this.lblSearch);
			this.pnlGridHeader.Controls.Add(this.txtSearch);
			this.pnlGridHeader.Location = new System.Drawing.Point(397, 5);
			this.pnlGridHeader.Name = "pnlGridHeader";
			this.pnlGridHeader.Size = new System.Drawing.Size(576, 45);
			this.pnlGridHeader.TabIndex = 2;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblSearch.Location = new System.Drawing.Point(306, 7);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(60, 21);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSearch.Location = new System.Drawing.Point(372, 3);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(201, 30);
			this.txtSearch.TabIndex = 1;
			// 
			// frmExpense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(976, 662);
			this.Controls.Add(this.dgvExpenses);
			this.Controls.Add(this.grpExpenseDetails);
			this.Controls.Add(this.panelHeader);
			this.Name = "frmExpense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Expense Management";
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.grpExpenseDetails.ResumeLayout(false);
			this.grpExpenseDetails.PerformLayout();
			this.pnlActions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
			this.pnlGridHeader.ResumeLayout(false);
			this.pnlGridHeader.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpExpenseDetails;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DateTimePicker dtpExpenseDate;
		private System.Windows.Forms.Label lblNotes;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Panel pnlActions;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Panel pnlGridHeader;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dgvExpenses;
	}
}