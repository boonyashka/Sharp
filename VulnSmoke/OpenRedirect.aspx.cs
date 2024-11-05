using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class OpenRedirect : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AddHeader(Request.Params["name"], Request.Params["value"]);
        }
    }
}