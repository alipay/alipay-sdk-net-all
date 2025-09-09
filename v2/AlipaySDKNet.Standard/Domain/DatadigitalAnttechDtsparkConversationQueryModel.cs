using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechDtsparkConversationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechDtsparkConversationQueryModel : AopObject
    {
        /// <summary>
        /// AI智库配置的智能会话助手唯一id
        /// </summary>
        [XmlElement("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 智能体对应secret，用于校验智能体是否正确
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 会话ID，每次会话会产生唯一ID，根据ID可以获取历史对话记录
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
