using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Globalization;

// Dollar html location: <div class="BNeawe iBp4i AP7Wnd"><div><div class="BNeawe iBp4i AP7Wnd">
namespace CurrencyTracker
{
	public partial class CurrencyTeller : Form
	{
		string location = "<div class=\"BNeawe iBp4i AP7Wnd\"><div><div class=\"BNeawe iBp4i AP7Wnd\">";

		float dollar = 0.00f;
		float caDol = 0.00f;
		float ausDol = 0.00f;
		float euro = 0.00f;
		float libra = 0.00f;
		float iene = 0.00f;

		public CurrencyTeller()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DollarLabel.Text = " $ " + dollar;
			CaDolLabel.Text = "C$ " + caDol;
			AusDolLabel.Text = "A$ " + ausDol;
			EuroLabel.Text = " € " + euro;
			LibraLabel.Text = " £ " + libra;
			IeneLabel.Text = " ¥ " + iene;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			// START CLIENT
			WebClient client = new WebClient();
			client.Encoding = Encoding.UTF8;

			// GET GOOGLE CURRENCY HTML
			string downloadedStringDollar = client.DownloadString("https://www.google.com/search?q=dólar");
			string downloadedStringCaDol = client.DownloadString("https://www.google.com/search?q=dólar+canadense");
			string downloadedStringAusDol = client.DownloadString("https://www.google.com/search?q=dólar+australiano");
			string downloadedStringEuro = client.DownloadString("https://www.google.com/search?q=euro");
			string downloadedStringLibra = client.DownloadString("https://www.google.com/search?q=libra+real");
			string downloadedStringIene = client.DownloadString("https://www.google.com/search?q=iene");

			// GET DOLLAR INDEX AND THE CURRENCY VALUE
			string dollarValue = downloadedStringDollar.Substring(downloadedStringDollar.IndexOf(location) + 71, 4);
			string caDolValue = downloadedStringCaDol.Substring(downloadedStringCaDol.IndexOf(location) + 71, 4);
			string ausDolValue = downloadedStringAusDol.Substring(downloadedStringAusDol.IndexOf(location) + 71, 4);
			string euroValue = downloadedStringEuro.Substring(downloadedStringEuro.IndexOf(location) + 71, 4);
			string libraValue = downloadedStringLibra.Substring(downloadedStringLibra.IndexOf(location) + 71, 4);
			string ieneValue = downloadedStringIene.Substring(downloadedStringIene.IndexOf(location) + 71, 4);

			dollar = float.Parse(dollarValue, CultureInfo.InvariantCulture);
			caDol = float.Parse(dollarValue, CultureInfo.InvariantCulture);
			ausDol = float.Parse(ausDolValue, CultureInfo.InvariantCulture);
			euro = float.Parse(euroValue, CultureInfo.InvariantCulture);
			libra = float.Parse(libraValue, CultureInfo.InvariantCulture);
			iene = float.Parse(ieneValue, CultureInfo.InvariantCulture);

			// INPUT VALUE INTO FORMS
			DollarLabel.Text =	" $ " + dollar;
			CaDolLabel.Text =	"C$ " + caDol;
			AusDolLabel.Text =	"A$ " + ausDol;
			EuroLabel.Text =	" € " + euro;
			LibraLabel.Text =	" £ " + libra;
			IeneLabel.Text =	" ¥ " + iene;
		}
	}
}