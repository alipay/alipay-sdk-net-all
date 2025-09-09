using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderVerifyphotoNpassporterQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderVerifyphotoNpassporterQueryResponse : AopResponse
    {
        /// <summary>
        /// 字符串
        /// </summary>
        [XmlElement("photo_url")]
        public string PhotoUrl { get; set; }
    }
}
