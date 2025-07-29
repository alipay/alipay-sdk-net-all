using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusUserpointQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketingAiplayfieldbusUserpointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户可兑奖卡数量
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
