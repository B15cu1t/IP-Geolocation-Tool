using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class MapViewerForm : Form
    {
        public MapViewerForm(string mapUrl)
        {
            InitializeComponent();

            // Load the map URL into WebView2
            webView21.Source = new Uri(mapUrl);

            // Optionally, set the WebView2 to fill the form
            webView21.Dock = DockStyle.Fill;
        }

        private void MapViewerForm_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
