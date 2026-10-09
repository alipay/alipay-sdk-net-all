using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoChatCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoChatCreateResponse : AopResponse
    {
        /// <summary>
        /// 消息内容。其中，chat 事件和 message 事件的格式不同。 chat 事件中，data 为 Chat Object。 message、audio 事件中，data 为 Message Object。
        /// </summary>
        [XmlElement("data")]
        public ChatResponseData Data { get; set; }

        /// <summary>
        /// 当前流式返回的数据包事件。
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }
    }
}
