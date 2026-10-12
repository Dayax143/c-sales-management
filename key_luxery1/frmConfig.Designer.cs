namespace key_luxery1
{
	partial class frmConfig
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
			this.label1 = new System.Windows.Forms.Label();
			this.grpConfig = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtServer = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TxtPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtDB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.chkShowPassword = new System.Windows.Forms.CheckBox();
			this.btnConfigure = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnDone = new System.Windows.Forms.Button();
			this.lblConTest = new System.Windows.Forms.Label();
			this.grpConfig.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.label1.Location = new System.Drawing.Point(205, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Database Configuration";
			// 
			// grpConfig
			// 
			this.grpConfig.Controls.Add(this.label2);
			this.grpConfig.Controls.Add(this.TxtServer);
			this.grpConfig.Controls.Add(this.label7);
			this.grpConfig.Controls.Add(this.TxtPort);
			this.grpConfig.Controls.Add(this.label3);
			this.grpConfig.Controls.Add(this.TxtDB);
			this.grpConfig.Controls.Add(this.label4);
			this.grpConfig.Controls.Add(this.TxtUser);
			this.grpConfig.Controls.Add(this.label5);
			this.grpConfig.Controls.Add(this.TxtPassword);
			this.grpConfig.Controls.Add(this.chkShowPassword);
			this.grpConfig.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.grpConfig.Location = new System.Drawing.Point(25, 55);
			this.grpConfig.Margin = new System.Windows.Forms.Padding(4);
			this.grpConfig.Name = "grpConfig";
			this.grpConfig.Padding = new System.Windows.Forms.Padding(4);
			this.grpConfig.Size = new System.Drawing.Size(430, 255);
			this.grpConfig.TabIndex = 1;
			this.grpConfig.TabStop = false;
			this.grpConfig.Text = "SQL Server Connection Settings";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Server :";
			// 
			// TxtServer
			// 
			this.TxtServer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.TxtServer.Location = new System.Drawing.Point(100, 32);
			this.TxtServer.Margin = new System.Windows.Forms.Padding(4);
			this.TxtServer.Name = "TxtServer";
			this.TxtServer.Size = new System.Drawing.Size(185, 29);
			this.TxtServer.Location = new System.Drawing.Point(120, 32);
			this.TxtServer.Margin = new System.Windows.Forms.Padding(4);
			this.TxtServer.Name = "TxtServer";
			this.TxtServer.Size = new System.Drawing.Size(165, 29);
			this.TxtServer.TabIndex = 0;
			this.TxtServer.Text = ".";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(295, 35);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "Port :";
			// 
			// TxtPort
			// 
			this.TxtPort.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.TxtPort.Location = new System.Drawing.Point(340, 32);
			this.TxtPort.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPort.Name = "TxtPort";
			this.TxtPort.Size = new System.Drawing.Size(65, 29);
			this.TxtPort.TabIndex = 1;
			this.TxtPort.Text = "1433";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 75);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Database :";
			// 
			// TxtDB
			// 
			this.TxtDB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.TxtDB.Location = new System.Drawing.Point(100, 72);
			this.TxtDB.Margin = new System.Windows.Forms.Padding(4);
			this.TxtDB.Name = "TxtDB";
			this.TxtDB.Size = new System.Drawing.Size(305, 29);
			this.TxtDB.Location = new System.Drawing.Point(120, 72);
			this.TxtDB.Margin = new System.Windows.Forms.Padding(4);
			this.TxtDB.Name = "TxtDB";
			this.TxtDB.Size = new System.Drawing.Size(285, 29);
			this.TxtDB.TabIndex = 2;
			this.TxtDB.Text = "Key_luxery";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 115);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "User :";
			// 
			// TxtUser
			// 
			this.TxtUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.TxtUser.Location = new System.Drawing.Point(100, 112);
			this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(305, 29);
			this.TxtUser.Location = new System.Drawing.Point(120, 112);
			this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(285, 29);
			this.TxtUser.TabIndex = 3;
			this.TxtUser.Text = "sa";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 155);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Password :";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.TxtPassword.Location = new System.Drawing.Point(100, 152);
			this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '●';
			this.TxtPassword.Size = new System.Drawing.Size(305, 29);
			this.TxtPassword.Location = new System.Drawing.Point(120, 152);
			this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '●';
			this.TxtPassword.Size = new System.Drawing.Size(285, 29);
			this.TxtPassword.TabIndex = 4;
			this.TxtPassword.Text = "123";
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.chkShowPassword.Location = new System.Drawing.Point(100, 185);
			this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(132, 24);
			this.chkShowPassword.TabIndex = 5;
			this.chkShowPassword.Text = "Show Password";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
			// 
			// btnConfigure
			// 
			this.btnConfigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnConfigure.FlatAppearance.BorderSize = 0;
			this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfigure.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnConfigure.ForeColor = System.Drawing.Color.White;
			this.btnConfigure.Location = new System.Drawing.Point(475, 65);
			this.btnConfigure.Margin = new System.Windows.Forms.Padding(4);
			this.btnConfigure.Name = "btnConfigure";
			this.btnConfigure.Size = new System.Drawing.Size(150, 38);
			this.btnConfigure.TabIndex = 2;
			this.btnConfigure.Text = "Configure";
			this.btnConfigure.UseVisualStyleBackColor = false;
			this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
			// 
			// btnTest
			// 
			this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnTest.FlatAppearance.BorderSize = 0;
			this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnTest.ForeColor = System.Drawing.Color.White;
			this.btnTest.Location = new System.Drawing.Point(475, 115);
			this.btnTest.Margin = new System.Windows.Forms.Padding(4);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(150, 38);
			this.btnTest.TabIndex = 3;
			this.btnTest.Text = "Test Connection";
			this.btnTest.UseVisualStyleBackColor = false;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnDone
			// 
			this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
			this.btnDone.FlatAppearance.BorderSize = 0;
			this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnDone.ForeColor = System.Drawing.Color.White;
			this.btnDone.Location = new System.Drawing.Point(475, 165);
			this.btnDone.Margin = new System.Windows.Forms.Padding(4);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(150, 38);
			this.btnDone.TabIndex = 4;
			this.btnDone.Text = "Done / Close";
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// lblConTest
			// 
			this.lblConTest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
			this.lblConTest.ForeColor = System.Drawing.Color.DimGray;
			this.lblConTest.Location = new System.Drawing.Point(25, 320);
			this.lblConTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblConTest.Name = "lblConTest";
			this.lblConTest.Size = new System.Drawing.Size(600, 25);
			this.lblConTest.TabIndex = 0;
			this.lblConTest.Text = "Status: Ready to configure database connection.";
			this.lblConTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(650, 360);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnConfigure);
			this.Controls.Add(this.grpConfig);
			this.Controls.Add(this.lblConTest);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Database Configuration";
			this.TopMost = true;
			this.grpConfig.ResumeLayout(false);
			this.grpConfig.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpConfig;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkShowPassword;
		public System.Windows.Forms.TextBox TxtServer;
		public System.Windows.Forms.TextBox TxtDB;
		public System.Windows.Forms.TextBox TxtUser;
		public System.Windows.Forms.TextBox TxtPassword;
		public System.Windows.Forms.TextBox TxtPort;
		public System.Windows.Forms.Button btnConfigure;
		public System.Windows.Forms.Button btnTest;
		public System.Windows.Forms.Button btnDone;
		public System.Windows.Forms.Label lblConTest;
	}
}