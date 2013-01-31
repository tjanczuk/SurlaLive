using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Surla.Mobi.PictureFromPhone
{
    [ComVisibleAttribute(true)]
    public partial class PictureFromPhoneForm : Form
    {
        string uri;

        public string Uri { get { return this.uri; } }

        public PictureFromPhoneForm()
        {
            InitializeComponent();

            this.webBrowser.ObjectForScripting = this;
            this.webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.webBrowser.DocumentText) 
                && this.webBrowser.DocumentText.Contains("This surla.mobi page has loaded")) {
                this.labelStatus.Visible = false;
                this.webBrowser.Visible = true;
            }
            else 
            {
                this.labelStatus.Text = "Error accessing http://surla.mobi service, try again later.";
                this.labelStatus.PerformLayout();
            }
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
 	        base.OnLayout(levent);

            this.labelStatus.Location = new Point(
                (this.ClientSize.Width - this.labelStatus.Width) / 2,
                (this.ClientSize.Height - this.labelStatus.Height) / 2);
        }
        
        public void PictureUploaded(string uri, string contentType)
        {
            this.uri = uri;
            this.Close();
        }

        public void UploadError(string id)
        {
        }
    }
}
