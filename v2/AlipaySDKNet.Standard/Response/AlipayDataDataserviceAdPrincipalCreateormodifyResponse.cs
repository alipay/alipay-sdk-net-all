using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }
    }
}
