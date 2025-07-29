using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusItemmodifySyncResponse.
    /// </summary>
    public class AlipayOfflineMarketingAiplayfieldbusItemmodifySyncResponse : AopResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
