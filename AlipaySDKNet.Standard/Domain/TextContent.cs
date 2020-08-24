using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextContent Data Structure.
    /// </summary>
    [Serializable]
    public class TextContent : AopObject
    {
        /// <summary>
        /// 文本消息的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文本消息的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
