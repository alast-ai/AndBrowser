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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			WindowState = FormWindowState.Maximized;
			
			browser.Navigate("https://duckduckgo.com/");
			
			this.browser.Navigated += (s, e) => URLBar.Text = browser.Url.ToString();
		}
		
		void URLBarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter) 
			{
				if(Uri.IsWellFormedUriString(URLBar.Text, UriKind.RelativeOrAbsolute))
				{
					browser.Navigate(URLBar.Text);
				}
			}
		}
	}
}
