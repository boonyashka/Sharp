using System;
using System.Web.UI;
using System.Web.Configuration;
using System.Configuration;

namespace VulnSmoke
{
    public partial class ExternalControl : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var key = Request.Params["key"];
            var value = Request.Params["value"];

            var config = WebConfigurationManager.OpenWebConfiguration("/");
            var conStrSection = config.AppSettings;
            if (conStrSection.Settings[key] == null)
            {
                var newKey = new KeyValueConfigurationElement(key, value);
                conStrSection.Settings.Add(newKey);
                config.Save(ConfigurationSaveMode.Modified);
            }
        }
    }
}