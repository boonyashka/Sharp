using System;
using System.Web.UI;
using System.Security.Cryptography;

namespace VulnSmoke
{
    public partial class BrokenOrRiskyCryptographicAlgorithm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var rc2 = RC2.Create();
        }
    }
}