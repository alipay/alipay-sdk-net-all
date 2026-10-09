using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatReference Data Structure.
    /// </summary>
    [Serializable]
    public class ChatReference : AopObject
    {
        /// <summary>
        /// 引用内容链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 引用内容title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
