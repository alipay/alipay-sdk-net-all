using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentDeliverySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentDeliverySubmitModel : AopObject
    {
        /// <summary>
        /// 智能体唯一标识
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 待投放的智能体版本号
        /// </summary>
        [XmlElement("agent_version")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 投放目标渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
