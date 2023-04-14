using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveChatSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveChatSendModel : AopObject
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息类型： TEXT，代表文本消息，此时content字段是文本； IMG，代表图片消息，此时content内容是可访问的图片URL
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// DT端会话ID
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 访问DT的渠道 11:LINKS 12:HELLO_BIKE
        /// </summary>
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// 渠道端用户唯一标识
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// 访客名字
        /// </summary>
        [XmlElement("visitor_name")]
        public string VisitorName { get; set; }

        /// <summary>
        /// DT端访客token，即本次的消息发送者
        /// </summary>
        [XmlElement("visitor_token")]
        public string VisitorToken { get; set; }

        /// <summary>
        /// 访客类型：1,代表匿名访客；2,代表有名访客
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }
    }
}
