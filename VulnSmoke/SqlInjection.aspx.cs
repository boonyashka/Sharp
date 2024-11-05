using System;
using System.Web.UI;
using System.Data.Entity;
using System.Data.Metadata.Edm;

namespace VulnSmoke
{
    public partial class SqlInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dbc = new DbContext("connection");
            dbc.Database.SqlQuery<EntityType>(Request.Params["command"]);
        }
    }
}