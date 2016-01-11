using System;
using System.Windows.Forms;

namespace Wwing4
{
    public partial class Form1 : Form
    {
        private int PageNum;
        public Form1()
        {
            InitializeComponent();
            WebTabPage newTabPage = new WebTabPage("http://www.google.co.jp/",addressBox);
            tabControlEx1.TabPages.Add(newTabPage);
            PageNum ++;
        }


        private void newTabButton_Click(object sender, EventArgs e)
        {
            WebTabPage newTabPage = new WebTabPage("http://www.google.co.jp/",addressBox);
            tabControlEx1.TabPages.Add(newTabPage);
            PageNum++;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string address = this.addressBox.Text;
            if (address.StartsWith("http://")|| address.StartsWith("https://")|| address.StartsWith("ftp://"))
            {
                WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
                openTabPage.TabWebBrowser.Navigate(address);
            }
            else {
                WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
                openTabPage.TabWebBrowser.Navigate("http://www.google.co.jp/search?q=" + address);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
            openTabPage.TabWebBrowser.GoBack();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
            openTabPage.TabWebBrowser.GoForward();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
            openTabPage.TabWebBrowser.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
            openTabPage.TabWebBrowser.Stop();
        }

        private void addressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string address = this.addressBox.Text;
                if (address.StartsWith("http://") || address.StartsWith("https://") || address.StartsWith("ftp://"))
                {
                    WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
                    openTabPage.TabWebBrowser.Navigate(address);
                }
                else {
                    WebTabPage openTabPage = (WebTabPage)tabControlEx1.SelectedTab;
                    openTabPage.TabWebBrowser.Navigate("http://www.google.co.jp/search?q=" + address);
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = !menuPanel.Visible;
        }

        private void closeMenuButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void versionButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            MessageBox.Show("Wwing4 version4.0");
        }
    }
}
