using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmMiniappServiceurlQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmMiniappServiceurlQueryResponse : AopResponse
    {
        /// <summary>
        /// alipayScheme链接
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
