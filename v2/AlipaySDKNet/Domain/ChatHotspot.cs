using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatHotspot Data Structure.
    /// </summary>
    [Serializable]
    public class ChatHotspot : AopObject
    {
        /// <summary>
        /// 热点资讯的详细介绍
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 热点资讯图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 热点资讯标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 热点资讯链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
