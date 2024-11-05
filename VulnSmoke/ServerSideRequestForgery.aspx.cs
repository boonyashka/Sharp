using System;
using System.Web.UI;
using System.Data.Entity;

namespace VulnSmoke
{
    public partial class ServerSideRequestForgery : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database.Exists(Request["param"]);
        }
    }
}