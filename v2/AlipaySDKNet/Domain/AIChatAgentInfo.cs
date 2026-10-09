using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIChatAgentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AIChatAgentInfo : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 所有者id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 智能体场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
