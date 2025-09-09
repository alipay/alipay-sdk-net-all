using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentAppBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentAppBindModel : AopObject
    {
        /// <summary>
        /// 百灵智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体code
        /// </summary>
        [XmlElement("app_agentcode")]
        public string AppAgentcode { get; set; }
    }
}
