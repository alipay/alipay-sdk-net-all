using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReplyChatContent Data Structure.
    /// </summary>
    [Serializable]
    public class ReplyChatContent : AopObject
    {
        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("content")]
        public OpenChatContent Content { get; set; }

        /// <summary>
        /// 消息内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 上下文信息
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("unit_id")]
        public string UnitId { get; set; }
    }
}
