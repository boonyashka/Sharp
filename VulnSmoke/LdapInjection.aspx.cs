using System;
using System.Web.UI;
using System.DirectoryServices;

namespace VulnSmoke
{
    public partial class LdapInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectoryEntry.Exists(Request.Params["path"]);
        }
    }
}