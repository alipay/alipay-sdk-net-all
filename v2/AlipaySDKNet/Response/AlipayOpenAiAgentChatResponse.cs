using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAiAgentChatResponse.
    /// </summary>
    public class AlipayOpenAiAgentChatResponse : AopResponse
    {
        /// <summary>
        /// 对话返回事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 对话返回体
        /// </summary>
        [XmlElement("payloads")]
        public ReplyPayload Payloads { get; set; }

        /// <summary>
        /// 返回对话顺序。不同content类型，顺序会重置。
        /// </summary>
        [XmlElement("turn")]
        public string Turn { get; set; }
    }
}
