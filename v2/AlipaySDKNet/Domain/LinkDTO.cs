using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkDTO : AopObject
    {
        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
