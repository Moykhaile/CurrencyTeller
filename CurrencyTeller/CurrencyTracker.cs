using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

// Dollar html location: <div class="BNeawe iBp4i AP7Wnd"><div><div class="BNeawe iBp4i AP7Wnd">
namespace CurrencyTracker
{
	public partial class CurrencyTracker : Form
	{
		WebClient client = new WebClient();
		string yahooPath = "https://finance.yahoo.com/quote/";
		string yahooPathEnd = "%3DX";
		string location = "<div class=\"BNeawe iBp4i AP7Wnd\"><div><div class=\"BNeawe iBp4i AP7Wnd\">";

		string path = AppDomain.CurrentDomain.BaseDirectory;
		string currenciesFile = @"currencies.json";

		Currency[] currencies = new Currency[16];

		public CurrencyTracker()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			client.Encoding = Encoding.UTF8;

			//SaveJson();
			LoadJson();

			Console.WriteLine(currencies);
		}

		void LoadJson()
		{
			string currenciesPath = path + currenciesFile;
			Console.WriteLine(currenciesPath);
			if (File.Exists(currenciesPath))
			{
				string jsonString = File.ReadAllText(currenciesPath);
				currencies = JsonConvert.DeserializeObject(jsonString) as Currency[];
			}
		}

		void SaveJson()
		{
			string currenciesPath = path + currenciesFile;
			string jsonString = JsonConvert.SerializeObject(currencies);
		}

		private void CurrencyTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				foreach (Currency currency in currencies)
				{
					Console.WriteLine(currency.currencyName + ", " + currency.isActive);
				}
			}
			catch (Exception error)
			{
				Console.WriteLine("Error: {0}", error.Source);
			}
			//Thread t = new Thread(new ThreadStart(UpdateCurrency));
			//t.Start();
		}

		/*void UpdateCurrency()
		{
			if (!CheckForInternetConnection()) return;

			for (int i = 0; i < currencies.Length; i++)
			{
				if (!CheckForInternetConnection()) return;

				try
				{
					SetLoading(true);
					SetLoadingLocation(i);

					string downloadedString = client.DownloadString(yahooPage + currencies[i]);

					float currency = float.Parse(downloadedString.Substring(downloadedString.IndexOf(location) + 71, 4), CultureInfo.InvariantCulture);
					SetText(currencySigns[i], " " + currency, i);

					Thread.Sleep(0);

					while (client.IsBusy) { }
				}
				catch
				{
					SetLoading(false);
				}
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
				LoadingGif.Location = new System.Drawing.Point(40, labels[i].Location.Y + 16);
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

		bool CheckForInternetConnection()
		{
			bool hasInternet = false;

			try
			{
				using (var client = new WebClient())
				using (client.OpenRead("http://google.com/generate_204"))
					hasInternet = true;
			}
			catch
			{
				hasInternet = false;
			}

			SetInternetConnectionLabel(hasInternet);
			return hasInternet;
		}

		delegate void SetInternetConnectionLabelCallback(bool hasInternet);
		void SetInternetConnectionLabel(bool hasInternet)
		{
			if (LoadingGif.InvokeRequired)
			{
				SetInternetConnectionLabelCallback d = new SetInternetConnectionLabelCallback(SetInternetConnectionLabel);
				Invoke(d, new object[] { hasInternet });
			}
			else
			{
				InternetConnectionLabel.Visible = !hasInternet;
				RestartButton.Visible = !hasInternet;
				RestartButton.Enabled = !hasInternet;
			}
		}*/
		private void CheckForInternetConnectionTimer_Tick(object sender, EventArgs e)
		{
			//CheckForInternetConnection();
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{

		}
	}

	public class Currency
	{
		public string currencyName { get; set; }
		public bool isActive { get; set; }
	}
}