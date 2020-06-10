namespace CurrencyTracker
{
	partial class CurrencyTracker
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.CurrencyTimer = new System.Windows.Forms.Timer(this.components);
			this.CheckForInternetConnectionTimer = new System.Windows.Forms.Timer(this.components);
			this.SettingsButton = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Loading = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Loading)).BeginInit();
			this.SuspendLayout();
			// 
			// CurrencyTimer
			// 
			this.CurrencyTimer.Enabled = true;
			this.CurrencyTimer.Interval = 1000;
			this.CurrencyTimer.Tick += new System.EventHandler(this.CurrencyTimer_Tick);
			// 
			// CheckForInternetConnectionTimer
			// 
			this.CheckForInternetConnectionTimer.Enabled = true;
			this.CheckForInternetConnectionTimer.Interval = 1000;
			this.CheckForInternetConnectionTimer.Tick += new System.EventHandler(this.CheckForInternetConnectionTimer_Tick);
			// 
			// SettingsButton
			// 
			this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
			this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SettingsButton.Image = global::CurrencyTracker.Properties.Resources.Settings;
			this.SettingsButton.Location = new System.Drawing.Point(297, 12);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(50, 50);
			this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SettingsButton.TabIndex = 1;
			this.SettingsButton.TabStop = false;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// Loading
			// 
			this.Loading.BackColor = System.Drawing.Color.Transparent;
			this.Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Loading.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Loading.Image = global::CurrencyTracker.Properties.Resources.Loading;
			this.Loading.Location = new System.Drawing.Point(235, 12);
			this.Loading.Name = "Loading";
			this.Loading.Size = new System.Drawing.Size(50, 50);
			this.Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Loading.TabIndex = 3;
			this.Loading.TabStop = false;
			this.Loading.Visible = false;
			// 
			// CurrencyTracker
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(359, 461);
			this.Controls.Add(this.Loading);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SettingsButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(2266, 132);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(375, 500);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(375, 500);
			this.Name = "CurrencyTracker";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Currency Tracker";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Loading)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer CurrencyTimer;
		private System.Windows.Forms.Timer CheckForInternetConnectionTimer;
		private System.Windows.Forms.PictureBox SettingsButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox Loading;
	}
}

