using System;
using System.Web;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class CookieInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookieName = new HttpCookie("cookie") { Name = Request.Params["cookieName"] };
        }
    }
}