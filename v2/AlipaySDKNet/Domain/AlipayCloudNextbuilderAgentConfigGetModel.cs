using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentConfigGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentConfigGetModel : AopObject
    {
        /// <summary>
        /// 创作者平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
