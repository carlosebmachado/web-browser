using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class TabUC : UserControl
    {
        private CoreWebView2 WebBrowserCore;
        private readonly BrowserForm form;
        private readonly TabPage tabPage;
        private readonly string referrer;
        private bool pageLoadComplete;

        public TabUC(BrowserForm form, TabPage tabPage, string url = "", string referrer = "")
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.tabPage = tabPage;
            this.form = form;
            this.referrer = referrer;
            Navigate(url);
            txtUrl.AutoCompleteCustomSource = Data.history;
            WebBrowserCore = WebBrowser.CoreWebView2;
            btnPrevious.Enabled = false;
            btnForward.Enabled = false;
            SetTabTitle("New Tab");
        }

        private void WebBrowser_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            SetTabTitle(WebBrowser.CoreWebView2.DocumentTitle);
            var stringUri = WebBrowser.Source.ToString();
            txtUrl.Text = stringUri;
            if (stringUri.StartsWith(Constants.HTTPS))
            {
                //WebBrowserCore.
            }
            else
            {
                MessageBox.Show("Essa página não usa HTTPS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnRefresh.BackgroundImage = imgsLoading.Images["Redo"];
            pageLoadComplete = true;
        }

        private void WebBrowser_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
            pageLoadComplete = false;
            btnRefresh.BackgroundImage = imgsLoading.Images["XMark"];
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
            if (WebBrowserCore.CanGoBack)
            {
                WebBrowserCore.GoBack();
            }
            SetCanGoBackBtn();
            SetCanGoForwardBtn();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (WebBrowserCore == null) return;
            if (WebBrowserCore.CanGoForward)
            { 
                WebBrowserCore.GoForward(); 
            }
        }

        private void SetCanGoBackBtn()
        {
            if (WebBrowserCore == null) return;
            btnPrevious.Enabled = WebBrowserCore.CanGoBack;
        }

        private void SetCanGoForwardBtn()
        {
            if (WebBrowserCore == null) return;
            btnPrevious.Enabled = WebBrowserCore.CanGoForward;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (pageLoadComplete)
            {
                WebBrowserCore.Reload();
            }
            else
            {
                WebBrowserCore.Stop();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Navigate(string.IsNullOrEmpty(referrer) ? Settings.HomePageURL : referrer);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        public void Navigate(string url = "")
        {
            if (string.IsNullOrEmpty(url))
            {
                url = Constants.HTTPS + Settings.HomePageURL;
            }
            else
            {
                if (!url.StartsWith(Constants.HTTP) && !url.StartsWith(Constants.HTTPS))
                {
                    if (Util.IsURI(url) || Util.IsIP(url))
                    {
                        url = Constants.HTTPS + url;
                    }
                    else
                    {
                        url = Constants.HTTPS + Settings.SearchEngineURL + url;
                    }
                }
                else if (url.Length <= Constants.HTTPS.Length)
                {
                    return;
                }
            }
            Data.history.Add(url);
            txtUrl.Text = url;
            WebBrowser.Source = new Uri(url);
        }

        private void TxtUrl_Enter(object sender, EventArgs e)
        {
            SelectAllURL();
        }

        private void TxtUrl_Leave(object sender, EventArgs e)
        {
            UnselectAllURL();
        }

        private void SelectAllURL()
        {
            txtUrl.SelectionStart = 0;
            txtUrl.SelectionLength = txtUrl.Text.Length;
            txtUrl.HideSelection = false;
        }

        private void UnselectAllURL()
        {
            txtUrl.SelectionStart = txtUrl.Text.Length;
            txtUrl.SelectionLength = 0;
            txtUrl.HideSelection = true;
        }

        private void WebBrowser_NewWindowRequested(object sender, WebViewControlNewWindowRequestedEventArgs e)
        {
            form.NewTab(e.Uri.ToString(), e.Referrer.ToString());
            e.Handled = true;
        }

        private void WebBrowser_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.WebMessageAsJson);
        }

        private void SetTabTitle(string title)
        {
            if (tabPage == null) return;
            var tabTitle = title;
            if (tabTitle.Length > 20)
            {
                tabTitle = tabTitle.Substring(0, 20) + " ...";
            }
            tabTitle += "   ✕";
            tabPage.Text = tabTitle;
            tabPage.ToolTipText = title;
        }
    }
}
