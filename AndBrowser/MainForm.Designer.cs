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
			this.browser = new Gecko.GeckoWebBrowser();
			this.back = new System.Windows.Forms.Button();
			this.forward = new System.Windows.Forms.Button();
			this.URLBar = new System.Windows.Forms.TextBox();
			this.secureLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// browser
			// 
			this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.browser.Location = new System.Drawing.Point(0, 56);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(1272, 544);
			this.browser.TabIndex = 1;
			this.browser.UseHttpActivityObserver = false;
			this.browser.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.BrowserNavigated);
			this.browser.CanGoBackChanged += new System.EventHandler(this.BrowserCanGoBackChanged);
			this.browser.CanGoForwardChanged += new System.EventHandler(this.BrowserCanGoForwardChanged);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.SystemColors.Control;
			this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.back.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.Color.Silver;
			this.back.Location = new System.Drawing.Point(12, 12);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(34, 34);
			this.back.TabIndex = 3;
			this.back.Text = "◀️";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.BackClick);
			// 
			// forward
			// 
			this.forward.BackColor = System.Drawing.SystemColors.Control;
			this.forward.FlatAppearance.BorderSize = 0;
			this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forward.ForeColor = System.Drawing.Color.Silver;
			this.forward.Location = new System.Drawing.Point(56, 12);
			this.forward.Name = "forward";
			this.forward.Size = new System.Drawing.Size(34, 34);
			this.forward.TabIndex = 4;
			this.forward.Text = "▶️ ";
			this.forward.UseVisualStyleBackColor = false;
			this.forward.Click += new System.EventHandler(this.ForwardClick);
			// 
			// URLBar
			// 
			this.URLBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.URLBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.URLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.URLBar.Location = new System.Drawing.Point(141, 12);
			this.URLBar.Name = "URLBar";
			this.URLBar.Size = new System.Drawing.Size(1119, 34);
			this.URLBar.TabIndex = 6;
			this.URLBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLBarKeyDown);
			// 
			// secureLabel
			// 
			this.secureLabel.BackColor = System.Drawing.Color.White;
			this.secureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secureLabel.ForeColor = System.Drawing.Color.ForestGreen;
			this.secureLabel.Location = new System.Drawing.Point(101, 12);
			this.secureLabel.Name = "secureLabel";
			this.secureLabel.Size = new System.Drawing.Size(34, 34);
			this.secureLabel.TabIndex = 7;
			this.secureLabel.Text = "🔒";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1272, 599);
			this.Controls.Add(this.secureLabel);
			this.Controls.Add(this.URLBar);
			this.Controls.Add(this.forward);
			this.Controls.Add(this.back);
			this.Controls.Add(this.browser);
			this.Name = "MainForm";
			this.Text = "AndBrowser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private GeckoWebBrowser browser;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox URLBar;
        private System.Windows.Forms.Label secureLabel;
    }
}
