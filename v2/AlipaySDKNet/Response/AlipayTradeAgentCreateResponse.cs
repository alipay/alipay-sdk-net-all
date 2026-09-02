using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAgentCreateResponse.
    /// </summary>
    public class AlipayTradeAgentCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧智能体唯一ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体审核申请单号。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 当前申请状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
