using System;
using System.Web.UI;
using System.Security.Cryptography;

namespace VulnSmoke
{
    public partial class WeakCryptographicHash : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var md5 = MD5.Create();
        }
    }
}