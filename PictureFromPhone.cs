using System;
using System.Collections.Generic;
using System.Text;
using WindowsLive.Writer.Api;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Surla.Mobi.PictureFromPhone
{
    [WriterPlugin(
        "E43AE20F-38C7-467D-8838-7B71C208FACE", 
        "Picture from Phone", 
        PublisherUrl = "http://surla.mobi", 
        Description = "Paste pictures from your phone into your blog",
        HasEditableOptions = false,
        Name = "Picture from Phone",
        ImagePath = "phone.png"),
    InsertableContentSource("Picture from phone")]
    public class PictureFromPhone : ContentSource
    {
        public PictureFromPhone() 
        { 
        }

        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            using (PictureFromPhoneForm form = new PictureFromPhoneForm())
            {
                form.ShowDialog(dialogOwner);
                if (!string.IsNullOrEmpty(form.Uri))
                {
                    string tempFile = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".jpg";
                    string tempDir = Path.GetTempPath();
                    Directory.CreateDirectory(tempDir);
                    string fullFileName = Path.Combine(tempDir, tempFile);
                    WebClient client = new WebClient();
                    client.DownloadFile(form.Uri, fullFileName);
                    content = "<img src=\"" + fullFileName + "\"/>";
                    return DialogResult.OK;
                }
                else {
                    return DialogResult.Cancel;
                }
            }
        }
    }

}
