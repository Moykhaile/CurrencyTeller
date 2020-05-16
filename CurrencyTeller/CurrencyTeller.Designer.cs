namespace CurrencyTracker
{
	partial class CurrencyTeller
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
			this.DollarLabel = new System.Windows.Forms.Label();
			this.CaDolLabel = new System.Windows.Forms.Label();
			this.LibraLabel = new System.Windows.Forms.Label();
			this.EuroLabel = new System.Windows.Forms.Label();
			this.IeneLabel = new System.Windows.Forms.Label();
			this.AusDolLabel = new System.Windows.Forms.Label();
			this.CurrencyTimer = new System.Windows.Forms.Timer(this.components);
			this.LoadingGif = new System.Windows.Forms.PictureBox();
			this.InternetConnectionLabel = new System.Windows.Forms.Label();
			this.RestartButton = new System.Windows.Forms.Button();
			this.CheckForInternetConnectionTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
			this.SuspendLayout();
			// 
			// DollarLabel
			// 
			this.DollarLabel.BackColor = System.Drawing.Color.Transparent;
			this.DollarLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DollarLabel.ForeColor = System.Drawing.Color.White;
			this.DollarLabel.Location = new System.Drawing.Point(12, 12);
			this.DollarLabel.Name = "DollarLabel";
			this.DollarLabel.Size = new System.Drawing.Size(210, 50);
			this.DollarLabel.TabIndex = 0;
			this.DollarLabel.Text = " $ 0,00";
			this.DollarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CaDolLabel
			// 
			this.CaDolLabel.BackColor = System.Drawing.Color.Transparent;
			this.CaDolLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CaDolLabel.ForeColor = System.Drawing.Color.White;
			this.CaDolLabel.Location = new System.Drawing.Point(12, 68);
			this.CaDolLabel.Name = "CaDolLabel";
			this.CaDolLabel.Size = new System.Drawing.Size(210, 50);
			this.CaDolLabel.TabIndex = 1;
			this.CaDolLabel.Text = "C$ 0,00";
			this.CaDolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LibraLabel
			// 
			this.LibraLabel.BackColor = System.Drawing.Color.Transparent;
			this.LibraLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LibraLabel.ForeColor = System.Drawing.Color.White;
			this.LibraLabel.Location = new System.Drawing.Point(12, 236);
			this.LibraLabel.Name = "LibraLabel";
			this.LibraLabel.Size = new System.Drawing.Size(210, 50);
			this.LibraLabel.TabIndex = 2;
			this.LibraLabel.Text = " £ 0,00";
			this.LibraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EuroLabel
			// 
			this.EuroLabel.BackColor = System.Drawing.Color.Transparent;
			this.EuroLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EuroLabel.ForeColor = System.Drawing.Color.White;
			this.EuroLabel.Location = new System.Drawing.Point(12, 180);
			this.EuroLabel.Name = "EuroLabel";
			this.EuroLabel.Size = new System.Drawing.Size(210, 50);
			this.EuroLabel.TabIndex = 3;
			this.EuroLabel.Text = " € 0,00";
			this.EuroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IeneLabel
			// 
			this.IeneLabel.BackColor = System.Drawing.Color.Transparent;
			this.IeneLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IeneLabel.ForeColor = System.Drawing.Color.White;
			this.IeneLabel.Location = new System.Drawing.Point(12, 292);
			this.IeneLabel.Name = "IeneLabel";
			this.IeneLabel.Size = new System.Drawing.Size(210, 50);
			this.IeneLabel.TabIndex = 4;
			this.IeneLabel.Text = " ¥ 0,00";
			this.IeneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AusDolLabel
			// 
			this.AusDolLabel.BackColor = System.Drawing.Color.Transparent;
			this.AusDolLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AusDolLabel.ForeColor = System.Drawing.Color.White;
			this.AusDolLabel.Location = new System.Drawing.Point(12, 124);
			this.AusDolLabel.Name = "AusDolLabel";
			this.AusDolLabel.Size = new System.Drawing.Size(210, 50);
			this.AusDolLabel.TabIndex = 5;
			this.AusDolLabel.Text = "A$ 0,00";
			this.AusDolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrencyTimer
			// 
			this.CurrencyTimer.Enabled = true;
			this.CurrencyTimer.Interval = 60000;
			this.CurrencyTimer.Tick += new System.EventHandler(this.CurrencyTimer_Tick);
			// 
			// LoadingGif
			// 
			this.LoadingGif.BackColor = System.Drawing.Color.Transparent;
			this.LoadingGif.Image = global::CurrencyTracker.Properties.Resources.loading;
			this.LoadingGif.InitialImage = null;
			this.LoadingGif.Location = new System.Drawing.Point(40, 28);
			this.LoadingGif.Name = "LoadingGif";
			this.LoadingGif.Size = new System.Drawing.Size(20, 20);
			this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LoadingGif.TabIndex = 6;
			this.LoadingGif.TabStop = false;
			this.LoadingGif.Visible = false;
			// 
			// InternetConnectionLabel
			// 
			this.InternetConnectionLabel.AutoSize = true;
			this.InternetConnectionLabel.BackColor = System.Drawing.Color.Transparent;
			this.InternetConnectionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InternetConnectionLabel.ForeColor = System.Drawing.Color.White;
			this.InternetConnectionLabel.Location = new System.Drawing.Point(6, 337);
			this.InternetConnectionLabel.Name = "InternetConnectionLabel";
			this.InternetConnectionLabel.Size = new System.Drawing.Size(186, 15);
			this.InternetConnectionLabel.TabIndex = 7;
			this.InternetConnectionLabel.Text = "No internet connection available";
			this.InternetConnectionLabel.Visible = false;
			// 
			// RestartButton
			// 
			this.RestartButton.BackColor = System.Drawing.Color.Transparent;
			this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RestartButton.Enabled = false;
			this.RestartButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RestartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
			this.RestartButton.Location = new System.Drawing.Point(189, 335);
			this.RestartButton.Name = "RestartButton";
			this.RestartButton.Size = new System.Drawing.Size(40, 20);
			this.RestartButton.TabIndex = 1;
			this.RestartButton.Text = "Retry";
			this.RestartButton.UseVisualStyleBackColor = false;
			this.RestartButton.Visible = false;
			this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
			// 
			// CheckForInternetConnectionTimer
			// 
			this.CheckForInternetConnectionTimer.Enabled = true;
			this.CheckForInternetConnectionTimer.Interval = 1000;
			this.CheckForInternetConnectionTimer.Tick += new System.EventHandler(this.CheckForInternetConnectionTimer_Tick);
			// 
			// CurrencyTeller
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(234, 361);
			this.Controls.Add(this.RestartButton);
			this.Controls.Add(this.InternetConnectionLabel);
			this.Controls.Add(this.LoadingGif);
			this.Controls.Add(this.AusDolLabel);
			this.Controls.Add(this.IeneLabel);
			this.Controls.Add(this.EuroLabel);
			this.Controls.Add(this.LibraLabel);
			this.Controls.Add(this.CaDolLabel);
			this.Controls.Add(this.DollarLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(2566, 132);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(250, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 400);
			this.Name = "CurrencyTeller";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Currency Tracker";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DollarLabel;
		private System.Windows.Forms.Label CaDolLabel;
		private System.Windows.Forms.Label LibraLabel;
		private System.Windows.Forms.Label EuroLabel;
		private System.Windows.Forms.Label IeneLabel;
		private System.Windows.Forms.Label AusDolLabel;
		private System.Windows.Forms.Timer CurrencyTimer;
		private System.Windows.Forms.PictureBox LoadingGif;
		private System.Windows.Forms.Label InternetConnectionLabel;
		private System.Windows.Forms.Button RestartButton;
		private System.Windows.Forms.Timer CheckForInternetConnectionTimer;
	}
}

