using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentChatContent Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentChatContent : AopObject
    {
        /// <summary>
        /// 具体会话内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容类型，当前仅支持text
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }
    }
}
