namespace key_luxery1
{
	partial class uSettings
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
			this.panelCard = new System.Windows.Forms.Panel();
			this.btnRestoreDb = new System.Windows.Forms.Button();
			this.btnBackupDb = new System.Windows.Forms.Button();
			this.lblBackupTitle = new System.Windows.Forms.Label();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.chkAutoBackup = new System.Windows.Forms.CheckBox();
			this.lblGeneralTitle = new System.Windows.Forms.Label();
			this.cmbCurrency = new System.Windows.Forms.ComboBox();
			this.lblCurrency = new System.Windows.Forms.Label();
			this.cmbTheme = new System.Windows.Forms.ComboBox();
			this.lblTheme = new System.Windows.Forms.Label();
			this.txtDbServer = new System.Windows.Forms.TextBox();
			this.lblDbServer = new System.Windows.Forms.Label();
			this.lblDbTitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panelCard.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCard
			// 
			this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelCard.BackColor = System.Drawing.Color.White;
			this.panelCard.Controls.Add(this.btnRestoreDb);
			this.panelCard.Controls.Add(this.btnBackupDb);
			this.panelCard.Controls.Add(this.lblBackupTitle);
			this.panelCard.Controls.Add(this.btnSaveSettings);
			this.panelCard.Controls.Add(this.chkAutoBackup);
			this.panelCard.Controls.Add(this.lblGeneralTitle);
			this.panelCard.Controls.Add(this.cmbCurrency);
			this.panelCard.Controls.Add(this.lblCurrency);
			this.panelCard.Controls.Add(this.cmbTheme);
			this.panelCard.Controls.Add(this.lblTheme);
			this.panelCard.Controls.Add(this.txtDbServer);
			this.panelCard.Controls.Add(this.lblDbServer);
			this.panelCard.Controls.Add(this.lblDbTitle);
			this.panelCard.Controls.Add(this.lblTitle);
			this.panelCard.Location = new System.Drawing.Point(40, 40);
			this.panelCard.Name = "panelCard";
			this.panelCard.Size = new System.Drawing.Size(1139, 680);
			this.panelCard.TabIndex = 0;
			// 
			// btnRestoreDb
			// 
			this.btnRestoreDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnRestoreDb.FlatAppearance.BorderSize = 0;
			this.btnRestoreDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestoreDb.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnRestoreDb.ForeColor = System.Drawing.Color.White;
			this.btnRestoreDb.Location = new System.Drawing.Point(220, 560);
			this.btnRestoreDb.Name = "btnRestoreDb";
			this.btnRestoreDb.Size = new System.Drawing.Size(150, 38);
			this.btnRestoreDb.TabIndex = 6;
			this.btnRestoreDb.Text = "Restore Database";
			this.btnRestoreDb.UseVisualStyleBackColor = false;
			this.btnRestoreDb.Click += new System.EventHandler(this.btnRestoreDb_Click);
			// 
			// btnBackupDb
			// 
			this.btnBackupDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnBackupDb.FlatAppearance.BorderSize = 0;
			this.btnBackupDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupDb.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnBackupDb.ForeColor = System.Drawing.Color.White;
			this.btnBackupDb.Location = new System.Drawing.Point(50, 560);
			this.btnBackupDb.Name = "btnBackupDb";
			this.btnBackupDb.Size = new System.Drawing.Size(150, 38);
			this.btnBackupDb.TabIndex = 5;
			this.btnBackupDb.Text = "Backup Database";
			this.btnBackupDb.UseVisualStyleBackColor = false;
			this.btnBackupDb.Click += new System.EventHandler(this.btnBackupDb_Click);
			// 
			// lblBackupTitle
			// 
			this.lblBackupTitle.AutoSize = true;
			this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblBackupTitle.Location = new System.Drawing.Point(50, 510);
			this.lblBackupTitle.Name = "lblBackupTitle";
			this.lblBackupTitle.Size = new System.Drawing.Size(262, 21);
			this.lblBackupTitle.TabIndex = 10;
			this.lblBackupTitle.Text = "Database Backup && Maintenance";
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnSaveSettings.FlatAppearance.BorderSize = 0;
			this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
			this.btnSaveSettings.Location = new System.Drawing.Point(50, 435);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(180, 40);
			this.btnSaveSettings.TabIndex = 4;
			this.btnSaveSettings.Text = "Save Configuration";
			this.btnSaveSettings.UseVisualStyleBackColor = false;
			this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
			// 
			// chkAutoBackup
			// 
			this.chkAutoBackup.AutoSize = true;
			this.chkAutoBackup.Checked = true;
			this.chkAutoBackup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.chkAutoBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.chkAutoBackup.Location = new System.Drawing.Point(50, 385);
			this.chkAutoBackup.Name = "chkAutoBackup";
			this.chkAutoBackup.Size = new System.Drawing.Size(262, 21);
			this.chkAutoBackup.TabIndex = 3;
			this.chkAutoBackup.Text = "Enable Automatic Daily Database Backups";
			this.chkAutoBackup.UseVisualStyleBackColor = true;
			// 
			// lblGeneralTitle
			// 
			this.lblGeneralTitle.AutoSize = true;
			this.lblGeneralTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblGeneralTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblGeneralTitle.Location = new System.Drawing.Point(50, 230);
			this.lblGeneralTitle.Name = "lblGeneralTitle";
			this.lblGeneralTitle.Size = new System.Drawing.Size(161, 21);
			this.lblGeneralTitle.TabIndex = 8;
			this.lblGeneralTitle.Text = "General Preferences";
			// 
			// cmbCurrency
			// 
			this.cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbCurrency.FormattingEnabled = true;
			this.cmbCurrency.Items.AddRange(new object[] {
			"USD ($)",
			"EUR (€)",
			"GBP (£)",
			"SAR (﷼)"});
			this.cmbCurrency.Location = new System.Drawing.Point(210, 325);
			this.cmbCurrency.Name = "cmbCurrency";
			this.cmbCurrency.Size = new System.Drawing.Size(300, 25);
			this.cmbCurrency.TabIndex = 2;
			this.cmbCurrency.Text = "USD ($)";
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.lblCurrency.Location = new System.Drawing.Point(50, 328);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(120, 17);
			this.lblCurrency.TabIndex = 6;
			this.lblCurrency.Text = "Receipt Currency :";
			// 
			// cmbTheme
			// 
			this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.cmbTheme.FormattingEnabled = true;
			this.cmbTheme.Items.AddRange(new object[] {
			"Deep Slate Blue (Default)",
			"Charcoal Dark",
			"Modern Minimalist Light"});
			this.cmbTheme.Location = new System.Drawing.Point(210, 275);
			this.cmbTheme.Name = "cmbTheme";
			this.cmbTheme.Size = new System.Drawing.Size(300, 25);
			this.cmbTheme.TabIndex = 1;
			this.cmbTheme.Text = "Deep Slate Blue (Default)";
			// 
			// lblTheme
			// 
			this.lblTheme.AutoSize = true;
			this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.lblTheme.Location = new System.Drawing.Point(50, 278);
			this.lblTheme.Name = "lblTheme";
			this.lblTheme.Size = new System.Drawing.Size(95, 17);
			this.lblTheme.TabIndex = 4;
			this.lblTheme.Text = "Interface Style :";
			// 
			// txtDbServer
			// 
			this.txtDbServer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.txtDbServer.Location = new System.Drawing.Point(210, 155);
			this.txtDbServer.Name = "txtDbServer";
			this.txtDbServer.Size = new System.Drawing.Size(300, 24);
			this.txtDbServer.TabIndex = 0;
			this.txtDbServer.Text = ".\\SQLEXPRESS";
			// 
			// lblDbServer
			// 
			this.lblDbServer.AutoSize = true;
			this.lblDbServer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblDbServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.lblDbServer.Location = new System.Drawing.Point(50, 158);
			this.lblDbServer.Name = "lblDbServer";
			this.lblDbServer.Size = new System.Drawing.Size(125, 17);
			this.lblDbServer.TabIndex = 2;
			this.lblDbServer.Text = "SQL Server Source :";
			// 
			// lblDbTitle
			// 
			this.lblDbTitle.AutoSize = true;
			this.lblDbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblDbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblDbTitle.Location = new System.Drawing.Point(50, 110);
			this.lblDbTitle.Name = "lblDbTitle";
			this.lblDbTitle.Size = new System.Drawing.Size(188, 21);
			this.lblDbTitle.TabIndex = 1;
			this.lblDbTitle.Text = "Database Configuration";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblTitle.Location = new System.Drawing.Point(45, 30);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(302, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "System Preferences";
			// 
			// uSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.panelCard);
			this.Name = "uSettings";
			this.Size = new System.Drawing.Size(1219, 764);
			this.Load += new System.EventHandler(this.uSettings_Load);
			this.panelCard.ResumeLayout(false);
			this.panelCard.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelCard;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDbTitle;
		private System.Windows.Forms.Label lblDbServer;
		public System.Windows.Forms.TextBox txtDbServer;
		private System.Windows.Forms.Label lblTheme;
		public System.Windows.Forms.ComboBox cmbTheme;
		private System.Windows.Forms.Label lblCurrency;
		public System.Windows.Forms.ComboBox cmbCurrency;
		private System.Windows.Forms.Label lblGeneralTitle;
		public System.Windows.Forms.CheckBox chkAutoBackup;
		public System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.Label lblBackupTitle;
		public System.Windows.Forms.Button btnBackupDb;
		public System.Windows.Forms.Button btnRestoreDb;
	}
}