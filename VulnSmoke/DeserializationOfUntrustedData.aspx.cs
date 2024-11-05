using System;
using System.IO;
using System.Text;
using System.Web.UI;
using ProtoBuf;

namespace VulnSmoke
{
    public partial class DeserializationOfUntrustedData : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(Request["param"])))
            {
                Serializer.Deserialize<ProtoClass>(stream);
            }
        }
        [ProtoContract]
        class ProtoClass
        {
            [ProtoMember(1)]
            public string Item { get; set; }
        }
    }
}