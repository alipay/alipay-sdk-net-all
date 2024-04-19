using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalConsultResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalConsultResponse : AopResponse
    {
        /// <summary>
        /// 签约平台地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
