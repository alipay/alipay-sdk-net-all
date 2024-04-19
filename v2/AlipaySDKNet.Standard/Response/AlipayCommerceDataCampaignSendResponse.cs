using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataCampaignSendResponse.
    /// </summary>
    public class AlipayCommerceDataCampaignSendResponse : AopResponse
    {
        /// <summary>
        /// 用户订阅消息状态，其中true：已订阅；false：未订阅；unknown：未知状态
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }
    }
}
