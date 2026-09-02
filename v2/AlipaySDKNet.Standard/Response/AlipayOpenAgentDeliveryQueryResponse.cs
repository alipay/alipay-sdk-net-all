using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentDeliveryQueryResponse.
    /// </summary>
    public class AlipayOpenAgentDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 能体唯一标识
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 投放的版本号
        /// </summary>
        [XmlElement("agent_version")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 投放目标渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 该次投放的当前状态
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
