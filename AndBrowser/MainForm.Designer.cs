/*
 * User: t
 * Date: 11/26/2018
 * Time: 10:49 PM
 */
using Gecko;
 
namespace AndBrowser
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.browser = new Gecko.GeckoWebBrowser();
			this.URLBar = new System.Windows.Forms.TextBox();
			this.eventLog1 = new System.Diagnostics.EventLog();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 520);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1168, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// browser
			// 
			this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.browser.Location = new System.Drawing.Point(0, 56);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(1168, 461);
			this.browser.TabIndex = 1;
			this.browser.UseHttpActivityObserver = false;
			// 
			// URLBar
			// 
			this.URLBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.URLBar.BackColor = System.Drawing.SystemColors.Window;
			this.URLBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.URLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.URLBar.Location = new System.Drawing.Point(12, 12);
			this.URLBar.Name = "URLBar";
			this.URLBar.Size = new System.Drawing.Size(1144, 38);
			this.URLBar.TabIndex = 2;
			this.URLBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLBarKeyDown);
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 542);
			this.Controls.Add(this.URLBar);
			this.Controls.Add(this.browser);
			this.Controls.Add(this.statusStrip1);
			this.Name = "MainForm";
			this.Text = "AndBrowser";
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.StatusStrip statusStrip1;
        private GeckoWebBrowser browser;
        private System.Windows.Forms.TextBox URLBar;
        private System.Diagnostics.EventLog eventLog1;
    }
}
