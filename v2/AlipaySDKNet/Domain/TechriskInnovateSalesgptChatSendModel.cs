using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateSalesgptChatSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateSalesgptChatSendModel : AopObject
    {
        /// <summary>
        /// 对话机器人id，由AI导购平台提供
        /// </summary>
        [XmlElement("chat_bot_id")]
        public string ChatBotId { get; set; }

        /// <summary>
        /// 支付宝开放平台中的商户id
        /// </summary>
        [XmlElement("mer_pid")]
        public string MerPid { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 消息类型，默认text
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 支付宝开放平台OpenId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝开放平台中的appId
        /// </summary>
        [XmlElement("source_app_id")]
        public string SourceAppId { get; set; }

        /// <summary>
        /// 用户唯一id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
