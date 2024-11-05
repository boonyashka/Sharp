using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class HardcodedPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var builder = new UriBuilder();
            builder.Password = "123";
        }
    }
}