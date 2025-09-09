using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniGeneralChatSendResponse.
    /// </summary>
    public class AlipayOpenMiniGeneralChatSendResponse : AopResponse
    {
        /// <summary>
        /// 标注返回的流式结构内容
        /// </summary>
        [XmlElement("data")]
        public AmpeChatContent Data { get; set; }

        /// <summary>
        /// 标注返回的流式结构类型
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 标注返回的流式结构序号
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
