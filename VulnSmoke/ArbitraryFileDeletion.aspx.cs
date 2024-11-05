using System;
using System.Web.UI;
using System.IO;

namespace VulnSmoke
{
    public partial class ArbitraryFileDeletion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            File.Delete(Request["param"]);
        }
    }
}