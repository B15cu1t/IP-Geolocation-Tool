using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InsertIP.TextAlign = HorizontalAlignment.Right;

            InsertIP.Font = new Font(InsertIP.Font.FontFamily, InsertIP.Font.Size * 2);
            InsertIP.Padding = new Padding(0, 0, 30, 0);
        }

        public class Data
        {
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string timezone { get; set; }
            public string ip { get; set; }
            public string loc { get; set; }
        }

        private async void StartProcess_Click(object sender, EventArgs e)
        {
            InsertIP.TextAlign = HorizontalAlignment.Center;

            string userInput = InsertIP.Text;
            string ip;

            // Check if input is an IP address or domain
            if (IPAddress.TryParse(userInput, out IPAddress ipAddress))
            {
                ip = userInput; // If it's an IP, use it directly
            }
            else
            {
                try
                {
                    // If it's not an IP, try to resolve the domain name to an IP address
                    IPHostEntry hostEntry = Dns.GetHostEntry(userInput);
                    ip = hostEntry.AddressList[0].ToString(); // Use the first resolved IP
                }
                catch (SocketException ex)
                {
                    MessageBox.Show($"Error resolving domain: {ex.Message}");
                    return; // Exit if domain resolution fails
                }
            }

            string url = $"https://ipinfo.io/{ip}/json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseData = await response.Content.ReadAsStringAsync();

                    Data ipInfo = JsonConvert.DeserializeObject<Data>(responseData);

                    CityResult.Text = ipInfo.city;
                    CountryResult.Text = ipInfo.country;
                    RegionResult.Text = ipInfo.region;
                    TimezoneResult.Text = ipInfo.timezone;
                    IPaddress.Text = ipInfo.ip;

                    // Generate Google Maps link
                    string[] coords = ipInfo.loc.Split(',');
                    string mapLink = $"https://www.google.com/maps/?q={coords[0]},{coords[1]}";

                    GoogleMapsLink.Text = mapLink;

                    // Open the new form to display the map
                    MapViewerForm mapViewer = new MapViewerForm(mapLink);
                    mapViewer.ShowDialog(); // Open as a modal dialog
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void GoogleMapsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void InsertIP_TextChanged(object sender, EventArgs e) { }

        private void CityResult_TextChanged(object sender, EventArgs e) { }

        private void CountryResult_TextChanged(object sender, EventArgs e) { }

        private void RegionResult_TextChanged(object sender, EventArgs e) { }

        private void TimezoneResult_TextChanged(object sender, EventArgs e) { }

        private void IPaddress_TextChanged(object sender, EventArgs e) { }

        private void GoogleMapsLink_TextChanged(object sender, EventArgs e) { }
    }
}
