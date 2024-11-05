using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class HttpResponseSplitting : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AddHeader("name", Request.Params["value"]);
        }
    }
}