using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBotSessionConsultResponse.
    /// </summary>
    public class AlipayEbppIndustryBotSessionConsultResponse : AopResponse
    {
        /// <summary>
        /// 机器人对话问答的回复
        /// </summary>
        [XmlElement("answer")]
        public BotAnswer Answer { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 机器人会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
