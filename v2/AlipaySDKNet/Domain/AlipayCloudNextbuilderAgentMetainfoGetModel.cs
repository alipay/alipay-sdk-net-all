using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentMetainfoGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentMetainfoGetModel : AopObject
    {
        /// <summary>
        /// AI创作平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
