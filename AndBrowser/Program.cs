/*
 * User: t
 * Date: 11/26/2018
 * Time: 10:49 PM
 */
using System;
using System.Windows.Forms;

namespace AndBrowser
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
		
	}
}
