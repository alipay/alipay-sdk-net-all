using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIservicePromotioncoreChatCreateResponse.
    /// </summary>
    public class AlipayIservicePromotioncoreChatCreateResponse : AopResponse
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 消息id，用于幂等
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
