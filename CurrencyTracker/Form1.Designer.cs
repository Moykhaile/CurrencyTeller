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
			this.DollarLabel = new System.Windows.Forms.Label();
			this.EuroLabel = new System.Windows.Forms.Label();
			this.LibraLabel = new System.Windows.Forms.Label();
			this.CaDolLabel = new System.Windows.Forms.Label();
			this.IeneLabel = new System.Windows.Forms.Label();
			this.AusDolLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DollarLabel
			// 
			this.DollarLabel.BackColor = System.Drawing.Color.Transparent;
			this.DollarLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DollarLabel.Location = new System.Drawing.Point(12, 12);
			this.DollarLabel.Name = "DollarLabel";
			this.DollarLabel.Size = new System.Drawing.Size(210, 50);
			this.DollarLabel.TabIndex = 0;
			this.DollarLabel.Text = " $ 0,00";
			this.DollarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EuroLabel
			// 
			this.EuroLabel.BackColor = System.Drawing.Color.Transparent;
			this.EuroLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EuroLabel.Location = new System.Drawing.Point(12, 68);
			this.EuroLabel.Name = "EuroLabel";
			this.EuroLabel.Size = new System.Drawing.Size(210, 50);
			this.EuroLabel.TabIndex = 1;
			this.EuroLabel.Text = "C$ 0,00";
			this.EuroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LibraLabel
			// 
			this.LibraLabel.BackColor = System.Drawing.Color.Transparent;
			this.LibraLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LibraLabel.Location = new System.Drawing.Point(12, 236);
			this.LibraLabel.Name = "LibraLabel";
			this.LibraLabel.Size = new System.Drawing.Size(210, 50);
			this.LibraLabel.TabIndex = 2;
			this.LibraLabel.Text = " £ 0,00";
			this.LibraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CaDolLabel
			// 
			this.CaDolLabel.BackColor = System.Drawing.Color.Transparent;
			this.CaDolLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CaDolLabel.Location = new System.Drawing.Point(12, 180);
			this.CaDolLabel.Name = "CaDolLabel";
			this.CaDolLabel.Size = new System.Drawing.Size(210, 50);
			this.CaDolLabel.TabIndex = 3;
			this.CaDolLabel.Text = " € 0,00";
			this.CaDolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IeneLabel
			// 
			this.IeneLabel.BackColor = System.Drawing.Color.Transparent;
			this.IeneLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.AusDolLabel.Location = new System.Drawing.Point(12, 124);
			this.AusDolLabel.Name = "AusDolLabel";
			this.AusDolLabel.Size = new System.Drawing.Size(210, 50);
			this.AusDolLabel.TabIndex = 5;
			this.AusDolLabel.Text = "A$ 0,00";
			this.AusDolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrencyTracker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 361);
			this.Controls.Add(this.AusDolLabel);
			this.Controls.Add(this.IeneLabel);
			this.Controls.Add(this.CaDolLabel);
			this.Controls.Add(this.LibraLabel);
			this.Controls.Add(this.EuroLabel);
			this.Controls.Add(this.DollarLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(250, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 400);
			this.Name = "CurrencyTracker";
			this.ShowIcon = false;
			this.Text = "Currency Tracker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label DollarLabel;
		private System.Windows.Forms.Label EuroLabel;
		private System.Windows.Forms.Label LibraLabel;
		private System.Windows.Forms.Label CaDolLabel;
		private System.Windows.Forms.Label IeneLabel;
		private System.Windows.Forms.Label AusDolLabel;
	}
}

