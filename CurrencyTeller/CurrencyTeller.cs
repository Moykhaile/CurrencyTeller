using System;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Dollar html location: <div class="BNeawe iBp4i AP7Wnd"><div><div class="BNeawe iBp4i AP7Wnd">
namespace CurrencyTracker
{
	public partial class CurrencyTeller : Form
	{
		WebClient client = new WebClient();

		string location = "<div class=\"BNeawe iBp4i AP7Wnd\"><div><div class=\"BNeawe iBp4i AP7Wnd\">";
		string googlePage = "https://www.google.com/search?q=";

		string[] currencies = new string[] { "dólar", "dólar+canadense", "dólar+australiano", "euro", "libra+real", "iene" };
		string[] currencySigns = new string[] { "$", "C$", "A$", "€", "£", "¥" };
		Label[] labels;

		public CurrencyTeller()
		{
			InitializeComponent();
			SendToBack();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			client.Encoding = Encoding.UTF8;
			labels = new Label[] { DollarLabel, CaDolLabel, AusDolLabel, EuroLabel, LibraLabel, IeneLabel };

			Thread t = new Thread(new ThreadStart(UpdateCurrency));
			t.Start();

			SendToBack();
		}

		private void currencyTimer_Tick(object sender, EventArgs e)
		{
			Thread t = new Thread(new ThreadStart(UpdateCurrency));
			t.Start();

			SendToBack();
		}

		void UpdateCurrency()
		{
			for (int i = 0; i < currencies.Length; i++)
			{
				SetLoading(true);
				SetLoadingLocation(i);

				string downloadedString = client.DownloadString(googlePage + currencies[i]);

				float currency = float.Parse(downloadedString.Substring(downloadedString.IndexOf(location) + 71, 4), CultureInfo.InvariantCulture);
				SetText(currencySigns[i], " " + currency, i);

				Thread.Sleep(0);

				while (client.IsBusy) { }
			}
			SetLoading(false);
		}

		delegate void SetTextCallback(string currencySign, string text, int i);
		private void SetText(string currencySign, string text, int i)
		{
			if (labels[i].InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				Invoke(d, new object[] { currencySign, text, i });
			}
			else
			{
				if (currencySign.Length > 1)
					labels[i].Text = currencySign + text;
				else
					labels[i].Text = " " + currencySign + text;
			}
		}
		delegate void SetLoadingLocationCallback(int i);
		private void SetLoadingLocation(int i)
		{
			if (labels[i].InvokeRequired)
			{
				SetLoadingLocationCallback d = new SetLoadingLocationCallback(SetLoadingLocation);
				Invoke(d, new object[] { i });
			}
			else
			{
				LoadingGif.Location = new System.Drawing.Point(12, labels[i].Location.Y + 8);
			}
		}
		delegate void SetLoadingCallback(bool visible);
		void SetLoading(bool visible)
		{
			if (LoadingGif.InvokeRequired)
			{
				SetLoadingCallback d = new SetLoadingCallback(SetLoading);
				Invoke(d, new object[] { visible });
			}
			else
			{
				LoadingGif.Visible = visible;
			}
		}
	}
}