using System;
using System.Windows.Forms;


namespace Wwing4
{
    public class WebTabPage : TabPage
    {
        public WebBrowser TabWebBrowser;
        private ComboBox addressBox;

        public WebTabPage(string url,ComboBox addressBoxConst)
        {
            InitializeComponent();
            this.TabWebBrowser.Navigate(new Uri(url));
            this.addressBox = addressBoxConst;
        }

        private void InitializeComponent()
        {
            
            this.TabWebBrowser = new WebBrowserEx();
            this.SuspendLayout();
            // 
            // TabWebBrowser
            // 
            this.TabWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.TabWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TabWebBrowser.Size = new System.Drawing.Size(250, 250);
            this.TabWebBrowser.Dock = DockStyle.Fill;
            this.TabWebBrowser.TabIndex = 0;
            this.TabWebBrowser.Name = "TabWebBrowser";
            this.Text = "";
            this.TabWebBrowser.ScriptErrorsSuppressed = true;
            //イベントハンドラ
            this.TabWebBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(TabWebBrowser_Complete);
            this.TabWebBrowser.Navigating += new WebBrowserNavigatingEventHandler(TabWebBrowser_Loading);

            this.ResumeLayout(false);
            this.Controls.Add(this.TabWebBrowser);
        }

        private void TabWebBrowser_Loading(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Loading...";
        }
        public void TabWebBrowser_Complete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = this.TabWebBrowser.DocumentTitle;
            addressBox.Text = this.TabWebBrowser.Url.ToString();
            addressBox.Items.Add(this.TabWebBrowser.Url.ToString());
        }
    }
}
