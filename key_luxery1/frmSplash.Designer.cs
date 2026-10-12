namespace key_luxery1
{
	partial class frmSplash
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
			this.components = new System.ComponentModel.Container();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.progressBarLoading = new System.Windows.Forms.ProgressBar();
			this.lblLoadingStatus = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.timerSplash = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(175, 120);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(307, 62);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "KEY LUXURY";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
			this.lblSubtitle.Location = new System.Drawing.Point(215, 185);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(270, 28);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Exclusive POS & Sales Manager";
			this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBarLoading
			// 
			this.progressBarLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBarLoading.Location = new System.Drawing.Point(100, 290);
			this.progressBarLoading.Name = "progressBarLoading";
			this.progressBarLoading.Size = new System.Drawing.Size(488, 10);
			this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarLoading.TabIndex = 2;
			// 
			// lblLoadingStatus
			// 
			this.lblLoadingStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLoadingStatus.AutoSize = true;
			this.lblLoadingStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblLoadingStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblLoadingStatus.Location = new System.Drawing.Point(100, 255);
			this.lblLoadingStatus.Name = "lblLoadingStatus";
			this.lblLoadingStatus.Size = new System.Drawing.Size(153, 23);
			this.lblLoadingStatus.TabIndex = 3;
			this.lblLoadingStatus.Text = "Loading modules...";
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblVersion.ForeColor = System.Drawing.Color.DarkGray;
			this.lblVersion.Location = new System.Drawing.Point(475, 335);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(91, 20);
			this.lblVersion.TabIndex = 4;
			this.lblVersion.Text = "Version 1.3.0";
			// 
			// timerSplash
			// 
			this.timerSplash.Enabled = true;
			this.timerSplash.Interval = 30;
			this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(688, 400);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblLoadingStatus);
			this.Controls.Add(this.progressBarLoading);
			this.Controls.Add(this.lblSubtitle);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Splash";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.ProgressBar progressBarLoading;
		private System.Windows.Forms.Label lblLoadingStatus;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Timer timerSplash;
	}
}