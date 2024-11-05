using System;
using System.Web.UI;
using System.IO;

namespace VulnSmoke
{
    public partial class ArbitraryFileReading : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            File.ReadAllText(Request["param"]);
        }
    }
}