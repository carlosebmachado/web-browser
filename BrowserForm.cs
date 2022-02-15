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
            if (e.Button == MouseButtons.Left)
            {
                var tabRect = tabControl.GetTabRect(tabControl.SelectedIndex);
                if (e.X > tabRect.Right - 20 && e.X < tabRect.Right)
                {
                    if (IsOpenTab()) return;
                    if (tabControl.SelectedTab.ContainsFocus) return;
                    CheckLastAndCloseTab();
                    return;
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                for (var i = 0; i < tabControl.TabPages.Count; ++i)
                {
                    if (tabControl.GetTabRect(i).Contains(e.Location))
                    {
                        if (IsOpenTab()) return;
                        tabControl.SelectedTab = tabControl.TabPages[i];
                        CheckLastAndCloseTab();
                        return;
                    }
                }
            }
        }

        private bool IsOpenTab()
        {
            return tabControl.SelectedTab.Name.Equals("tabNew");
        }

        private void CheckLastAndCloseTab()
        {
            if (tabControl.SelectedIndex == 0 && tabControl.TabCount <= 2)
            {
                //((TabUC)tabControl.SelectedTab.Controls[0]).Navigate();
                Close();
            }
            else
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
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
            HandleNewTabClick();
        }

        private void HandleNewTabClick()
        {
            if (tabControl.SelectedTab == null) return;
            if (!tabControl.SelectedTab.Name.Equals("tabNew")) return;
            NewTab();
        }

        private void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl.TabPages.Count >= 3)
            {
                var dr = MessageBox.Show("Do you want to close all tabs?", "Quit Browser", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
