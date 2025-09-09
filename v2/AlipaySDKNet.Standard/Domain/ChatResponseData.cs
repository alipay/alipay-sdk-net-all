using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatResponseData Data Structure.
    /// </summary>
    [Serializable]
    public class ChatResponseData : AopObject
    {
        /// <summary>
        /// 要进行会话聊天的智能体ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 要进行会话聊天的智能体版本。百宝箱智能体的版本号是”v1.0“，这里需要传入”1.0“。
        /// </summary>
        [XmlElement("agent_version")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 要进行会话聊天的智能体ID。
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 要进行会话聊天的智能体版本。
        /// </summary>
        [XmlElement("bot_version")]
        public string BotVersion { get; set; }

        /// <summary>
        /// 创建消息时的附加消息，获取消息时也会返回此附加消息。
        /// </summary>
        [XmlElement("business_data")]
        public string BusinessData { get; set; }

        /// <summary>
        /// 对话 ID，即对话的唯一标识。
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 对话完成时间
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// 消息内容，包含文本、图片或文件。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 会话 ID，即会话的唯一标识。
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 对话创建时间
        /// </summary>
        [XmlElement("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 记录最后一次错误信息（当status=FAILED时有效）
        /// </summary>
        [XmlElement("last_error")]
        public string LastError { get; set; }

        /// <summary>
        /// Message ID，即消息的唯一标识。
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 对话的运行状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 消息更新时间
        /// </summary>
        [XmlElement("updated_time")]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// 会话资源使用情况统计。
        /// </summary>
        [XmlElement("usage")]
        public ChatUsage Usage { get; set; }
    }
}
