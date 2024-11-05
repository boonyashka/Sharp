using System;
using System.Web.UI;
using System.Reflection;
using System.Text;

namespace VulnSmoke
{
    public partial class DllInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Assembly.Load(Request["param"]);
        }
    }
}