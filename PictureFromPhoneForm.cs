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
        }

        public void PictureUploaded(string uri)
        {
            this.uri = uri;
            this.Close();
        }
    }
}
