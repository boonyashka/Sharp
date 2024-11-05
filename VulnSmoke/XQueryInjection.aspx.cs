using Saxon.Api;
using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class XQueryInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var proc = new Processor(false);
            var comp = proc.NewXQueryCompiler();
            comp.Compile(Request.Params["query"]);
        }
    }
}