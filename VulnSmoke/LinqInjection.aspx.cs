using System;
using System.Web.UI;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq.Dynamic;

namespace VulnSmoke
{
    public partial class LinqInjection :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn = new MySqlConnection { ConnectionString = "connection" };
            conn.Open();
            var command = new MySqlCommand("command", conn);
            command.ExecuteNonQuery();
            var da = new MySqlDataAdapter(command);
            var table = new DataTable();
            da.Fill(table);
            var data = table.Select().AsQueryable();
            data.Aggregate(Request.Params["function"], "member");
        }
    }
}