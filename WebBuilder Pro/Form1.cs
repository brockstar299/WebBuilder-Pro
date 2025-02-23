using System;
using System.Net.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebBuilderPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // This should be called to initialize all controls
        }

        // API URL
        private const string apiUrl = "https://aiwebsitecoder.brockstar299.workers.dev/";

        // Button click event to generate the website
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            // Get the inputs from the user
            string websitePurpose = txtWebsitePurpose.Text;
            string designPreferences = txtDesignPreferences.Text;

            // Check for empty inputs
            if (string.IsNullOrWhiteSpace(websitePurpose) || string.IsNullOrWhiteSpace(designPreferences))
            {
                MessageBox.Show("Please provide both website purpose and design preferences.");
                return;
            }

            // Show progress indication
            lblStatus.Text = "Generating website...";  // Show message
            progressBar.Visible = true;  // Show progress bar
            progressBar.Style = ProgressBarStyle.Marquee;  // Set progress bar to indeterminate style (for ongoing process)

            // Construct the request URL with query parameters
            string url = $"{apiUrl}?websitePurpose={Uri.EscapeDataString(websitePurpose)}&designPreferences={Uri.EscapeDataString(designPreferences)}";

            // Send the GET request to the API
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Get the generated HTML or code from the response
                    string responseData = await response.Content.ReadAsStringAsync();

                    // Display the HTML in the WebBrowser control
                    webBrowserPreview.DocumentText = responseData;  // Load HTML to the WebBrowser control

                    // Store the generated code (so we can copy it later)
                    _generatedHtmlCode = responseData;
                }
                else
                {
                    MessageBox.Show("Failed to generate website. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Hide progress indication
                lblStatus.Text = "";  // Clear status message
                progressBar.Visible = false;  // Hide progress bar
            }
        }

        // Store the generated HTML code for copying
        private string _generatedHtmlCode = string.Empty;

        // Copy the generated code to clipboard
        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_generatedHtmlCode))
            {
                Clipboard.SetText(_generatedHtmlCode);  // Copy HTML code to clipboard
                MessageBox.Show("HTML code copied to clipboard!");
            }
            else
            {
                MessageBox.Show("No code to copy. Please generate a website first.");
            }
        }
    }
}