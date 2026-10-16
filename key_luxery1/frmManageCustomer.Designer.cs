namespace key_luxery1
{
	partial class frmManageCustomer
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
			this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
			this.cmbstatus = new System.Windows.Forms.ComboBox();
			this.lblID = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.grpSearch = new System.Windows.Forms.GroupBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearchPhone = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.grpCustomerDetails.SuspendLayout();
			this.grpSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(210, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(282, 32);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Customer Management";
			// 
			// grpCustomerDetails
			// 
			this.grpCustomerDetails.Controls.Add(this.cmbstatus);
			this.grpCustomerDetails.Controls.Add(this.lblID);
			this.grpCustomerDetails.Controls.Add(this.txtCustomerID);
			this.grpCustomerDetails.Controls.Add(this.lblName);
			this.grpCustomerDetails.Controls.Add(this.txtCustomerName);
			this.grpCustomerDetails.Controls.Add(this.lblPhone);
			this.grpCustomerDetails.Controls.Add(this.txtPhone);
			this.grpCustomerDetails.Controls.Add(this.label1);
			this.grpCustomerDetails.Controls.Add(this.lblAddress);
			this.grpCustomerDetails.Controls.Add(this.txtAddress);
			this.grpCustomerDetails.Controls.Add(this.btnSave);
			this.grpCustomerDetails.Controls.Add(this.btnUpdate);
			this.grpCustomerDetails.Controls.Add(this.btnDelete);
			this.grpCustomerDetails.Controls.Add(this.btnClear);
			this.grpCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.grpCustomerDetails.Location = new System.Drawing.Point(30, 70);
			this.grpCustomerDetails.Name = "grpCustomerDetails";
			this.grpCustomerDetails.Size = new System.Drawing.Size(590, 325);
			this.grpCustomerDetails.TabIndex = 1;
			this.grpCustomerDetails.TabStop = false;
			this.grpCustomerDetails.Text = "Customer Information";
			// 
			// cmbstatus
			// 
			this.cmbstatus.FormattingEnabled = true;
			this.cmbstatus.Location = new System.Drawing.Point(155, 201);
			this.cmbstatus.Name = "cmbstatus";
			this.cmbstatus.Size = new System.Drawing.Size(395, 28);
			this.cmbstatus.TabIndex = 8;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(30, 40);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(94, 20);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "Customer ID:";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(155, 37);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(395, 27);
			this.txtCustomerID.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(30, 80);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(119, 20);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Customer Name:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(155, 77);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(395, 27);
			this.txtCustomerName.TabIndex = 3;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(30, 120);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(53, 20);
			this.lblPhone.TabIndex = 4;
			this.lblPhone.Text = "Phone:";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(155, 117);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(395, 27);
			this.txtPhone.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Status";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(30, 160);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(65, 20);
			this.lblAddress.TabIndex = 6;
			this.lblAddress.Text = "Address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(155, 157);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(395, 27);
			this.txtAddress.TabIndex = 7;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(140, 272);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 30);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(245, 272);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(95, 30);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(350, 272);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(95, 30);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(455, 272);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(95, 30);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// grpSearch
			// 
			this.grpSearch.Controls.Add(this.lblSearch);
			this.grpSearch.Controls.Add(this.txtSearchPhone);
			this.grpSearch.Controls.Add(this.btnGet);
			this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.grpSearch.Location = new System.Drawing.Point(30, 401);
			this.grpSearch.Name = "grpSearch";
			this.grpSearch.Size = new System.Drawing.Size(590, 90);
			this.grpSearch.TabIndex = 2;
			this.grpSearch.TabStop = false;
			this.grpSearch.Text = "Quick Search";
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(30, 38);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(121, 20);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search by Phone:";
			// 
			// txtSearchPhone
			// 
			this.txtSearchPhone.Location = new System.Drawing.Point(180, 35);
			this.txtSearchPhone.Name = "txtSearchPhone";
			this.txtSearchPhone.Size = new System.Drawing.Size(265, 27);
			this.txtSearchPhone.TabIndex = 1;
			// 
			// btnGet
			// 
			this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGet.ForeColor = System.Drawing.Color.White;
			this.btnGet.Location = new System.Drawing.Point(455, 32);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(95, 28);
			this.btnGet.TabIndex = 2;
			this.btnGet.Text = "Search";
			this.btnGet.UseVisualStyleBackColor = false;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// frmManageCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(664, 514);
			this.Controls.Add(this.grpSearch);
			this.Controls.Add(this.grpCustomerDetails);
			this.Controls.Add(this.lblTitle);
			this.Name = "frmManageCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Customers - Key Luxury";
			this.grpCustomerDetails.ResumeLayout(false);
			this.grpCustomerDetails.PerformLayout();
			this.grpSearch.ResumeLayout(false);
			this.grpSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpCustomerDetails;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.GroupBox grpSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearchPhone;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbstatus;
	}
}