using System;
using System.Web.UI;
using System.Xml;

namespace VulnSmoke
{
    public partial class XmlExternalEntities : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
            var reader = XmlReader.Create(Request.Params["xml"], settings);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        Console.Write(reader.Value);
                        break;
                }
            }
        }
    }
}