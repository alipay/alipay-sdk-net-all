using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcommunityContentUrlIndex Data Structure.
    /// </summary>
    [Serializable]
    public class IcommunityContentUrlIndex : AopObject
    {
        /// <summary>
        /// 内容关联的链接值
        /// </summary>
        [XmlElement("content_link_url")]
        public string ContentLinkUrl { get; set; }

        /// <summary>
        /// 内容关联超链接名称
        /// </summary>
        [XmlElement("content_link_url_name")]
        public string ContentLinkUrlName { get; set; }

        /// <summary>
        /// 关联超链接的内容对象在内容文本中的结束位置
        /// </summary>
        [XmlElement("url_end_index")]
        public string UrlEndIndex { get; set; }

        /// <summary>
        /// 关联超链接的内容对象在内容文本中的起始位置
        /// </summary>
        [XmlElement("url_start_index")]
        public string UrlStartIndex { get; set; }
    }
}
