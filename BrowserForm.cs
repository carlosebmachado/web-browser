using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl.TabPages.Count <= 2) return;
            if (e.Button == MouseButtons.Left)
            {
                var tabRect = tabControl.GetTabRect(tabControl.SelectedIndex);
                if (e.X > tabRect.Right - 20 &&
                    e.X < tabRect.Right)
                {
                    if (tabControl.SelectedTab.Name.Equals("tabNew")) return;
                    tabControl.TabPages.Remove(tabControl.SelectedTab);
                    return;
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                for (var i = 0; i < tabControl.TabPages.Count; ++i)
                {
                    if (tabControl.GetTabRect(i).Contains(e.Location))
                    {
                        if (tabControl.TabPages[i].Name.Equals("tabNew")) return;
                        tabControl.TabPages.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public void NewTab(string url = "", string refferer = "")
        {
            var browserTab = new TabPage();
            var tabUC = new TabUC(this, browserTab, url, refferer);
            browserTab.Controls.Add(tabUC);
            tabControl.TabPages.Insert(tabControl.TabPages.Count - 1, browserTab);
            tabControl.SelectTab(browserTab);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null) return;
            if (!tabControl.SelectedTab.Name.Equals("tabNew")) return;
            NewTab();
        }
    }
}
