using System;
using System.Web.UI;
using StackExchange.Redis;

namespace VulnSmoke
{
    public partial class RemoteCodeExecution : Page
    {
        private IDatabase database;
        protected void Page_Load(object sender, EventArgs e)
        {
            var script = Request["param"];
            var luaScript = LuaScript.Prepare(script);
            database.ScriptEvaluate(script);
        }
    }
}