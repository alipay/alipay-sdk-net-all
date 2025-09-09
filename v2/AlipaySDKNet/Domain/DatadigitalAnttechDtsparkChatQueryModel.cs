using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechDtsparkChatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechDtsparkChatQueryModel : AopObject
    {
        /// <summary>
        /// AI智库配置的智能会话助手唯一id
        /// </summary>
        [XmlElement("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 智能体对应secret，用于校验智能体是否正确
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 标识同一次多轮对话的id，session_id相同表示用户在同一会话中
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 标识调用的场景，可由调用方自行定义：如网页端可用web等等
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
