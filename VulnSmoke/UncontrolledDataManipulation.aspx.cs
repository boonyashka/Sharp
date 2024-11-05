using System;
using System.Web.UI;
using System.IO;
using System.Security.AccessControl;

namespace VulnSmoke
{
    public partial class UncontrolledDataManipulation : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            File.SetAccessControl(Request.Params["file"], new FileSecurity());
        }
    }
}