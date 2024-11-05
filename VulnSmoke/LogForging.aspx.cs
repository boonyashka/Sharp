using System;
using System.Web.UI;
using Xtensive.Orm.Logging;

namespace VulnSmoke
{
    public partial class LogForging : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var logger = new LogManager().GetLog("log");
            logger.Debug(Request.Params["log"]);
        }
    }
}