using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelatedDocumentFragments Data Structure.
    /// </summary>
    [Serializable]
    public class RelatedDocumentFragments : AopObject
    {
        /// <summary>
        /// 文档片段内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文档片段标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
