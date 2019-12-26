using System.Xml.Serialization;

namespace Aop.Api
{
    public class AlipayOpenAppAlipaycertDownloadResponse : AopResponse
    {
        [XmlElement("alipay_cert_content")]        public string AlipayCertContent { get; set; }
    }
}
