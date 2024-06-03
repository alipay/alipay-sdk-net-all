using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class TextMsgVO : AopObject
    {
        /// <summary>
        /// 文本消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
