using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentVersionDeliveryQueryResponse.
    /// </summary>
    public class AlipayOpenAgentVersionDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 该版本该渠道最新投放记录ID，查无记录时为空
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 最新投放状态，查无记录时为空
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 投放驳回原因，非驳回为空
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
