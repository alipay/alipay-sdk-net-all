using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbConversation Data Structure.
    /// </summary>
    [Serializable]
    public class NbConversation : AopObject
    {
        /// <summary>
        /// 创作者平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部用户标识
        /// </summary>
        [XmlElement("outer_user_id")]
        public string OuterUserId { get; set; }
    }
}
