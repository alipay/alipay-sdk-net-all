using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindPreconsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExternalaccountBindPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
