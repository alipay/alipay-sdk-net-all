using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndirectSmidQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderIndirectSmidQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
