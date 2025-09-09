using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UrlInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class UrlInfoList : AopObject
    {
        /// <summary>
        /// 是否为AI
        /// </summary>
        [XmlElement("ai")]
        public bool Ai { get; set; }

        /// <summary>
        /// 收藏类型
        /// </summary>
        [XmlElement("collect_type")]
        public string CollectType { get; set; }

        /// <summary>
        /// 藏品图片
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 藏品副标题
        /// </summary>
        [XmlElement("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// 藏品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 原始链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
