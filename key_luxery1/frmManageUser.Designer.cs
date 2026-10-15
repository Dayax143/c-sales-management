namespace key_luxery1
{
	partial class frmManageUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblBrandHeader = new System.Windows.Forms.Label();
			this.pnlFormContainer = new System.Windows.Forms.Panel();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblRole = new System.Windows.Forms.Label();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.cmbRecoveryQuestion = new System.Windows.Forms.ComboBox();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.txtRecoveryAnswer = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.lblTagline = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			this.pnlFormContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			this.pnlHeader.Controls.Add(this.lblTagline);
			this.pnlHeader.Controls.Add(this.lblBrandHeader);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1150, 80);
			this.pnlHeader.TabIndex = 0;
			// 
			// lblBrandHeader
			// 
			this.lblBrandHeader.AutoSize = true;
			this.lblBrandHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrandHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
			this.lblBrandHeader.Location = new System.Drawing.Point(18, 9);
			this.lblBrandHeader.Name = "lblBrandHeader";
			this.lblBrandHeader.Size = new System.Drawing.Size(195, 41);
			this.lblBrandHeader.TabIndex = 0;
			this.lblBrandHeader.Text = "KEY LUXURY";
			// 
			// pnlFormContainer
			// 
			this.pnlFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.pnlFormContainer.Controls.Add(this.lblUserId);
			this.pnlFormContainer.Controls.Add(this.txtUserId);
			this.pnlFormContainer.Controls.Add(this.lblUserName);
			this.pnlFormContainer.Controls.Add(this.txtUserName);
			this.pnlFormContainer.Controls.Add(this.lblPassword);
			this.pnlFormContainer.Controls.Add(this.txtPassword);
			this.pnlFormContainer.Controls.Add(this.lblRole);
			this.pnlFormContainer.Controls.Add(this.cmbRole);
			this.pnlFormContainer.Controls.Add(this.lblQuestion);
			this.pnlFormContainer.Controls.Add(this.cmbRecoveryQuestion);
			this.pnlFormContainer.Controls.Add(this.lblAnswer);
			this.pnlFormContainer.Controls.Add(this.txtRecoveryAnswer);
			this.pnlFormContainer.Controls.Add(this.lblStatus);
			this.pnlFormContainer.Controls.Add(this.cmbStatus);
			this.pnlFormContainer.Controls.Add(this.btnSave);
			this.pnlFormContainer.Controls.Add(this.btnUpdate);
			this.pnlFormContainer.Controls.Add(this.btnDelete);
			this.pnlFormContainer.Controls.Add(this.btnClear);
			this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlFormContainer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.pnlFormContainer.Location = new System.Drawing.Point(0, 80);
			this.pnlFormContainer.Name = "pnlFormContainer";
			this.pnlFormContainer.Size = new System.Drawing.Size(430, 595);
			this.pnlFormContainer.TabIndex = 1;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Location = new System.Drawing.Point(20, 15);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(64, 21);
			this.lblUserId.TabIndex = 0;
			this.lblUserId.Text = "User ID:";
			// 
			// txtUserId
			// 
			this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.txtUserId.Location = new System.Drawing.Point(24, 38);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.ReadOnly = true;
			this.txtUserId.Size = new System.Drawing.Size(380, 29);
			this.txtUserId.TabIndex = 1;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(20, 75);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(84, 21);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "Username:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(24, 98);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(380, 29);
			this.txtUserName.TabIndex = 3;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(20, 135);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(79, 21);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(24, 158);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(380, 29);
			this.txtPassword.TabIndex = 5;
			// 
			// lblRole
			// 
			this.lblRole.AutoSize = true;
			this.lblRole.Location = new System.Drawing.Point(20, 195);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(44, 21);
			this.lblRole.TabIndex = 6;
			this.lblRole.Text = "Role:";
			// 
			// cmbRole
			// 
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
			this.cmbRole.Location = new System.Drawing.Point(24, 218);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(380, 29);
			this.cmbRole.TabIndex = 7;
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(20, 255);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(144, 21);
			this.lblQuestion.TabIndex = 8;
			this.lblQuestion.Text = "Recovery Question:";
			// 
			// cmbRecoveryQuestion
			// 
			this.cmbRecoveryQuestion.FormattingEnabled = true;
			this.cmbRecoveryQuestion.Items.AddRange(new object[] {
            "What is your childhood nickname?",
            "What is the name of your first pet?",
            "What city were you born in?",
            "What is your favorite book?"});
			this.cmbRecoveryQuestion.Location = new System.Drawing.Point(24, 278);
			this.cmbRecoveryQuestion.Name = "cmbRecoveryQuestion";
			this.cmbRecoveryQuestion.Size = new System.Drawing.Size(380, 29);
			this.cmbRecoveryQuestion.TabIndex = 9;
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(20, 315);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(133, 21);
			this.lblAnswer.TabIndex = 10;
			this.lblAnswer.Text = "Recovery Answer:";
			// 
			// txtRecoveryAnswer
			// 
			this.txtRecoveryAnswer.Location = new System.Drawing.Point(24, 338);
			this.txtRecoveryAnswer.Name = "txtRecoveryAnswer";
			this.txtRecoveryAnswer.Size = new System.Drawing.Size(380, 29);
			this.txtRecoveryAnswer.TabIndex = 11;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(20, 375);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(91, 21);
			this.lblStatus.TabIndex = 12;
			this.lblStatus.Text = "User Status:";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.cmbStatus.Location = new System.Drawing.Point(24, 398);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(380, 29);
			this.cmbStatus.TabIndex = 13;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.Black;
			this.btnSave.Location = new System.Drawing.Point(24, 455);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 38);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(122, 455);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 38);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(220, 455);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 38);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(318, 455);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(86, 38);
			this.btnClear.TabIndex = 17;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
			this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvUsers.ColumnHeadersHeight = 40;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsers.EnableHeadersVisualStyles = false;
			this.dgvUsers.Location = new System.Drawing.Point(430, 80);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersVisible = false;
			this.dgvUsers.RowHeadersWidth = 51;
			this.dgvUsers.RowTemplate.Height = 32;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(720, 595);
			this.dgvUsers.TabIndex = 2;
			this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
			// 
			// lblTagline
			// 
			this.lblTagline.AutoSize = true;
			this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
			this.lblTagline.Location = new System.Drawing.Point(22, 47);
			this.lblTagline.Name = "lblTagline";
			this.lblTagline.Size = new System.Drawing.Size(388, 20);
			this.lblTagline.TabIndex = 1;
			this.lblTagline.Text = "MANAGE YOUR USER ACCOUNTS AND ADD A NEW ONE";
			// 
			// frmManageUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 675);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.pnlFormContainer);
			this.Controls.Add(this.pnlHeader);
			this.Name = "frmManageUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - User Management";
			this.Load += new System.EventHandler(this.frmManageUser_Load);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.pnlFormContainer.ResumeLayout(false);
			this.pnlFormContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblBrandHeader;
		private System.Windows.Forms.Panel pnlFormContainer;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.ComboBox cmbRecoveryQuestion;
		private System.Windows.Forms.Label lblAnswer;
		private System.Windows.Forms.TextBox txtRecoveryAnswer;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.Label lblTagline;
	}
}