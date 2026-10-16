namespace key_luxery1
{
	partial class frmLogin
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
			this.pnlBrand = new System.Windows.Forms.Panel();
			this.lblBrandTitle = new System.Windows.Forms.Label();
			this.lblBrandSubtitle = new System.Windows.Forms.Label();
			this.lblLoginHeader = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.lblPass = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.chkShowPassword = new System.Windows.Forms.CheckBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.pnlBrand.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBrand
			// 
			this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.pnlBrand.Controls.Add(this.lblBrandTitle);
			this.pnlBrand.Controls.Add(this.lblBrandSubtitle);
			this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlBrand.Location = new System.Drawing.Point(0, 0);
			this.pnlBrand.Name = "pnlBrand";
			this.pnlBrand.Size = new System.Drawing.Size(260, 420);
			this.pnlBrand.TabIndex = 0;
			// 
			// lblBrandTitle
			// 
			this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
			this.lblBrandTitle.Location = new System.Drawing.Point(20, 150);
			this.lblBrandTitle.Name = "lblBrandTitle";
			this.lblBrandTitle.Size = new System.Drawing.Size(220, 80);
			this.lblBrandTitle.TabIndex = 0;
			this.lblBrandTitle.Text = "KEY LUXURY";
			this.lblBrandTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBrandSubtitle
			// 
			this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
			this.lblBrandSubtitle.Location = new System.Drawing.Point(20, 230);
			this.lblBrandSubtitle.Name = "lblBrandSubtitle";
			this.lblBrandSubtitle.Size = new System.Drawing.Size(220, 40);
			this.lblBrandSubtitle.TabIndex = 1;
			this.lblBrandSubtitle.Text = "Business Management System";
			this.lblBrandSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLoginHeader
			// 
			this.lblLoginHeader.AutoSize = true;
			this.lblLoginHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.lblLoginHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblLoginHeader.Location = new System.Drawing.Point(310, 45);
			this.lblLoginHeader.Name = "lblLoginHeader";
			this.lblLoginHeader.Size = new System.Drawing.Size(170, 37);
			this.lblLoginHeader.TabIndex = 0;
			this.lblLoginHeader.Text = "User Sign In";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.lblUser.Location = new System.Drawing.Point(310, 105);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(81, 21);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "Username";
			// 
			// TxtUser
			// 
			this.TxtUser.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.TxtUser.Location = new System.Drawing.Point(310, 128);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(325, 31);
			this.TxtUser.TabIndex = 2;
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.lblPass.Location = new System.Drawing.Point(310, 175);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(76, 21);
			this.lblPass.TabIndex = 3;
			this.lblPass.Text = "Password";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.TxtPassword.Location = new System.Drawing.Point(310, 198);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '●';
			this.TxtPassword.Size = new System.Drawing.Size(325, 31);
			this.TxtPassword.TabIndex = 4;
			this.TxtPassword.UseSystemPasswordChar = true;
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.chkShowPassword.Location = new System.Drawing.Point(310, 235);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(132, 24);
			this.chkShowPassword.TabIndex = 5;
			this.chkShowPassword.Text = "Show Password";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(310, 338);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(150, 40);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.btnExit.Location = new System.Drawing.Point(485, 338);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(150, 40);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.btnConfig.Location = new System.Drawing.Point(635, 12);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(35, 35);
			this.btnConfig.TabIndex = 8;
			this.btnConfig.Text = "⚙";
			this.btnConfig.UseVisualStyleBackColor = false;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(682, 420);
			this.Controls.Add(this.btnConfig);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.chkShowPassword);
			this.Controls.Add(this.TxtPassword);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.TxtUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblLoginHeader);
			this.Controls.Add(this.pnlBrand);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Authentication";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
			this.pnlBrand.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlBrand;
		private System.Windows.Forms.Label lblBrandTitle;
		private System.Windows.Forms.Label lblBrandSubtitle;
		private System.Windows.Forms.Label lblLoginHeader;
		private System.Windows.Forms.Label lblUser;
		public System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.Label lblPass;
		public System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.CheckBox chkShowPassword;
		public System.Windows.Forms.Button btnLogin;
		public System.Windows.Forms.Button btnExit;
		public System.Windows.Forms.Button btnConfig;
	}
}