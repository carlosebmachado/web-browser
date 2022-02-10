using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    public class BrowserTab : TabPage
    {
        private TableLayoutPanel tableMain;
        private TableLayoutPanel tableControls;
        private Button btnRefresh;
        private Button btnForward;
        private Button btnSettings;
        private Button btnHome;
        private Button btnPrevious;
        private Button btnWebsiteConfig;
        private Panel panelUrl;
        private TextBox txtUrl;

        public WebBrowser WebBrowser { get; set; }

        public BrowserTab() : base()
        {
            InitializeComponent();

            Navigate(Settings.HomePageURL);
        }

        private void WebBrowser_LoadCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = WebBrowser.DocumentTitle;
        }

        private void TxtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUrl.Text.Length == 0) return;
                Navigate(txtUrl.Text);
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser.Refresh();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Navigate(Settings.HomePageURL);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.", "Settings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
        }

        private void Navigate(string url)
        {
            txtUrl.Text = url;
            WebBrowser.Navigate(url.StartsWith(Constants.HTTPS) ? url : Constants.HTTPS + url);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BrowserTab));

            tableMain = new TableLayoutPanel();
            tableControls = new TableLayoutPanel();
            btnRefresh = new Button();
            btnForward = new Button();
            btnSettings = new Button();
            btnHome = new Button();
            btnPrevious = new Button();
            panelUrl = new Panel();
            btnWebsiteConfig = new Button();
            txtUrl = new TextBox();
            WebBrowser = new WebBrowser();

            // suspend layouts
            SuspendLayout();
            tableMain.SuspendLayout();
            tableControls.SuspendLayout();
            btnRefresh.SuspendLayout();
            btnForward.SuspendLayout();
            btnSettings.SuspendLayout();
            btnHome.SuspendLayout();
            btnPrevious.SuspendLayout();
            panelUrl.SuspendLayout();
            btnWebsiteConfig.SuspendLayout();
            txtUrl.SuspendLayout();
            WebBrowser.SuspendLayout();

            // tableMain
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.Controls.Add(tableControls, 0, 0);
            tableMain.Controls.Add(WebBrowser, 0, 1);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Margin = new Padding(0);
            tableMain.Name = "tableMain";
            tableMain.RowCount = 2;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableMain.Size = new Size(800, 450);
            tableMain.TabIndex = 2;

            // tableControls
            tableControls.ColumnCount = 6;
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableControls.Controls.Add(btnRefresh, 0, 0);
            tableControls.Controls.Add(btnForward, 0, 0);
            tableControls.Controls.Add(btnSettings, 5, 0);
            tableControls.Controls.Add(btnHome, 2, 0);
            tableControls.Controls.Add(btnPrevious, 0, 0);
            tableControls.Controls.Add(panelUrl, 4, 0);
            tableControls.Dock = DockStyle.Fill;
            tableControls.Location = new Point(0, 0);
            tableControls.Margin = new Padding(0);
            tableControls.Name = "tableControls";
            tableControls.RowCount = 1;
            tableControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableControls.Size = new Size(800, 30);
            tableControls.TabIndex = 7;

            // btnRefresh
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.Click += BtnRefresh_Click;
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(63, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.TabIndex = 3;
            btnRefresh.UseVisualStyleBackColor = true;

            // btnForward
            btnForward.BackgroundImage = (Image)resources.GetObject("btnForward.BackgroundImage");
            btnForward.Click += BtnForward_Click;
            btnForward.BackgroundImageLayout = ImageLayout.Center;
            btnForward.Dock = DockStyle.Fill;
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Location = new Point(33, 3);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(24, 24);
            btnForward.TabIndex = 2;
            btnForward.UseVisualStyleBackColor = true;

            // btnSettings
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.Click += BtnSettings_Click;
            btnSettings.BackgroundImageLayout = ImageLayout.Center;
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(773, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(24, 24);
            btnSettings.TabIndex = 6;
            btnSettings.UseVisualStyleBackColor = true;

            // btnHome
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.Click += BtnHome_Click;
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(93, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(24, 24);
            btnHome.TabIndex = 4;
            btnHome.UseVisualStyleBackColor = true;

            // btnPrevious
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.Click += BtnPrevious_Click;
            btnPrevious.BackgroundImageLayout = ImageLayout.Center;
            btnPrevious.Dock = DockStyle.Fill;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(3, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(24, 24);
            btnPrevious.TabIndex = 1;
            btnPrevious.UseVisualStyleBackColor = true;

            // panelUrl
            panelUrl.BackColor = SystemColors.Window;
            panelUrl.Controls.Add(btnWebsiteConfig);
            panelUrl.Controls.Add(txtUrl);
            panelUrl.Dock = DockStyle.Fill;
            panelUrl.Location = new Point(123, 3);
            panelUrl.Name = "panelUrl";
            panelUrl.Padding = new Padding(24, 4, 5, 3);
            panelUrl.Size = new Size(644, 24);
            panelUrl.TabIndex = 7;

            // btnWebsiteConfig
            btnWebsiteConfig.FlatAppearance.BorderSize = 0;
            btnWebsiteConfig.FlatStyle = FlatStyle.Flat;
            btnWebsiteConfig.Location = new Point(3, 4);
            btnWebsiteConfig.Name = "btnWebsiteConfig";
            btnWebsiteConfig.Size = new Size(17, 17);
            btnWebsiteConfig.TabIndex = 7;
            btnWebsiteConfig.UseVisualStyleBackColor = true;

            // txtUrl
            txtUrl.BackColor = SystemColors.Window;
            txtUrl.BorderStyle = BorderStyle.None;
            txtUrl.Dock = DockStyle.Fill;
            txtUrl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUrl.KeyDown += TxtUrl_KeyDown;
            txtUrl.Location = new Point(24, 4);
            txtUrl.Margin = new Padding(0, 3, 0, 3);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(615, 17);
            txtUrl.TabIndex = 5;

            // webBrowser
            WebBrowser.Dock = DockStyle.Fill;
            WebBrowser.DocumentCompleted += WebBrowser_LoadCompleted;
            WebBrowser.Location = new Point(0, 30);
            WebBrowser.Margin = new Padding(0);
            WebBrowser.MinimumSize = new Size(20, 20);
            WebBrowser.Name = "webBrowser";
            WebBrowser.Size = new Size(800, 420);
            WebBrowser.TabIndex = 8;

            // this
            Controls.Add(tableMain);
            Dock = DockStyle.Fill;
            txtUrl.Location = new Point(800, 450);
            txtUrl.Margin = new Padding(0, 0, 0, 0);

            // resume layouts
            ResumeLayout(false);
            tableMain.ResumeLayout(false);
            tableControls.ResumeLayout(false);
            btnRefresh.ResumeLayout(false);
            btnForward.ResumeLayout(false);
            btnSettings.ResumeLayout(false);
            btnHome.ResumeLayout(false);
            btnPrevious.ResumeLayout(false);
            panelUrl.ResumeLayout(false);
            btnWebsiteConfig.ResumeLayout(false);
            txtUrl.ResumeLayout(false);
            WebBrowser.ResumeLayout(false);
        }
    }
}
