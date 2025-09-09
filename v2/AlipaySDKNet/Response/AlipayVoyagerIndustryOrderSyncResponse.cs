using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerIndustryOrderSyncResponse.
    /// </summary>
    public class AlipayVoyagerIndustryOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 消费状态
        /// </summary>
        [XmlElement("consume_status")]
        public string ConsumeStatus { get; set; }
    }
}
