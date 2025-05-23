using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAiAgentChatModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAiAgentChatModel : AopObject
    {
        /// <summary>
        /// 对话消息体，包含提问内容，附件列表，上下文参数等
        /// </summary>
        [XmlElement("chat_payload")]
        public ChatPayload ChatPayload { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 会话发起者id
        /// </summary>
        [XmlElement("initiator_id")]
        public string InitiatorId { get; set; }

        /// <summary>
        /// 会话发起者id
        /// </summary>
        [XmlElement("initiator_open_id")]
        public string InitiatorOpenId { get; set; }

        /// <summary>
        /// 会话发起者类型
        /// </summary>
        [XmlElement("initiator_type")]
        public string InitiatorType { get; set; }

        /// <summary>
        /// 会话ID，用来串联同一次会话的多轮对话。如果调用方不传入则由平台生成。会在请求结果中返回。 默认情况下session 超过6个小时自动关闭
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 智能应用特性设置
        /// </summary>
        [XmlElement("specifications")]
        public ChatSpecifications Specifications { get; set; }
    }
}
