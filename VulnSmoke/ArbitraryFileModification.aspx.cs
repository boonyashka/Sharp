using System;
using System.Web.UI;
using System.IO;

namespace VulnSmoke
{
    public partial class ArbitraryFileModification : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            File.AppendAllText(Request["param"], "context");
        }
    }
}