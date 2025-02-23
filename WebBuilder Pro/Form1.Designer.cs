namespace WebBuilderPro
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtWebsitePurpose;
        private System.Windows.Forms.TextBox txtDesignPreferences;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCopyCode;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtWebsitePurpose = new TextBox();
            txtDesignPreferences = new TextBox();
            webBrowserPreview = new WebBrowser();
            btnGenerate = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            btnCopyCode = new Button();
            SuspendLayout();

            // txtWebsitePurpose
            txtWebsitePurpose.Location = new Point(15, 15);
            txtWebsitePurpose.Name = "txtWebsitePurpose";
            txtWebsitePurpose.PlaceholderText = "Enter the purpose of the website...";
            txtWebsitePurpose.Size = new Size(360, 27);
            txtWebsitePurpose.TabIndex = 0;

            // txtDesignPreferences
            txtDesignPreferences.Location = new Point(15, 55);
            txtDesignPreferences.Name = "txtDesignPreferences";
            txtDesignPreferences.PlaceholderText = "Enter design preferences (e.g., color, layout, etc.)...";
            txtDesignPreferences.Size = new Size(360, 27);
            txtDesignPreferences.TabIndex = 1;

            // webBrowserPreview
            webBrowserPreview.Location = new Point(15, 135);
            webBrowserPreview.Name = "webBrowserPreview";
            webBrowserPreview.Size = new Size(360, 180);
            webBrowserPreview.TabIndex = 2;

            // btnGenerate
            btnGenerate.Location = new Point(15, 95);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 30);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.Click += btnGenerate_Click;

            // progressBar
            progressBar.Location = new Point(120, 95);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(255, 30);
            progressBar.TabIndex = 4;
            progressBar.Visible = false;
            progressBar.Style = ProgressBarStyle.Marquee;

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(120, 135);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "";

            // btnCopyCode
            btnCopyCode.Location = new Point(120, 320);
            btnCopyCode.Name = "btnCopyCode";
            btnCopyCode.Size = new Size(150, 30);
            btnCopyCode.TabIndex = 6;
            btnCopyCode.Text = "Copy Code";
            btnCopyCode.Click += btnCopyCode_Click;

            // Form1
            ClientSize = new Size(400, 370);
            Controls.Add(txtWebsitePurpose);
            Controls.Add(txtDesignPreferences);
            Controls.Add(webBrowserPreview);
            Controls.Add(btnGenerate);
            Controls.Add(progressBar);
            Controls.Add(lblStatus);
            Controls.Add(btnCopyCode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WebBuilderPro";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}