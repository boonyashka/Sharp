using System;
using System.IO;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class LocalFileInclusion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var writer = new StringWriter();
                string file = Request.Params["file"];
                Server.Execute(file);
        }
    }
}