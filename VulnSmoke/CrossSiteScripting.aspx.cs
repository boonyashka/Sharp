using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class CrossSiteScripting :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
        }
    }
}