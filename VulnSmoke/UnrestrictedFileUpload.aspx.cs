using System;
using System.Web.UI;

namespace VulnSmoke
{
    public partial class UnrestrictedFileUpload : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            FileUploadControl.SaveAs(Request["param"]);
        }
    }
}