/*
 * User: t
 * Date: 11/26/2018
 * Time: 10:49 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gecko;

namespace AndBrowser
{
	/// <summary>
	/// The main form of AndBrowser.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			WindowState = FormWindowState.Maximized;
			
			browser.Navigate("https://duckduckgo.com/");
		}
		
		void URLBarKeyDown(object sender, KeyEventArgs e) { if(e.KeyCode == Keys.Enter) { if(Uri.IsWellFormedUriString(URLBar.Text, UriKind.RelativeOrAbsolute)) { browser.Navigate(URLBar.Text); } } }
		
		void BackClick(object sender, EventArgs e) { browser.GoBack(); }
		void ForwardClick(object sender, EventArgs e) { browser.GoForward(); }
		void BrowserCanGoBackChanged(object sender, EventArgs e) { back.ForeColor = browser.CanGoBack ? System.Drawing.Color.Black : System.Drawing.Color.Silver; }
		void BrowserCanGoForwardChanged(object sender, EventArgs e) { forward.ForeColor = browser.CanGoForward ? System.Drawing.Color.Black : System.Drawing.Color.Silver; }
		
		void BrowserNavigated(object sender, EventArgs e) 
		{
			URLBar.Text = browser.Url.ToString();
			secureLabel.ForeColor = browser.Url.Scheme == "https" ? System.Drawing.Color.ForestGreen : System.Drawing.Color.Silver;
		}
		
		protected override void OnClosed(EventArgs e)
		{
			browser.Dispose();
			Xpcom.Shutdown();
			base.OnClosed(e);
		}
	}
}