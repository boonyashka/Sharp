using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class InformationExposure : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.Write(Request["param"]);
        }
    }
}