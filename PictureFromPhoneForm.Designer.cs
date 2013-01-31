namespace Surla.Mobi.PictureFromPhone
{
    partial class PictureFromPhoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(724, 530);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://surla.mobi/upload/livewriter", System.UriKind.Absolute);
            this.webBrowser.Visible = false;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(118, 24);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Initializing...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureFromPhoneForm
            // 
            this.ClientSize = new System.Drawing.Size(724, 530);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PictureFromPhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert picture from phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelStatus;
    }
}