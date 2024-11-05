using System;
using System.Web.UI;
using System.Diagnostics;

namespace VulnSmoke
{
    public partial class OsCommanding : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Process.Start(Request["param"]);
        }
    }
}