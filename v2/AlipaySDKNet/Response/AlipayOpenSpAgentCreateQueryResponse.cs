using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpAgentCreateQueryResponse.
    /// </summary>
    public class AlipayOpenSpAgentCreateQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
