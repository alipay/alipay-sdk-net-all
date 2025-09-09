using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BotChatLog Data Structure.
    /// </summary>
    [Serializable]
    public class BotChatLog : AopObject
    {
        /// <summary>
        /// 机器人回答
        /// </summary>
        [XmlElement("answer")]
        public BotAnswer Answer { get; set; }

        /// <summary>
        /// 用户提问时间戳
        /// </summary>
        [XmlElement("ask_time")]
        public string AskTime { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 用户提问
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 对话评价
        /// </summary>
        [XmlElement("vote_type")]
        public string VoteType { get; set; }
    }
}
