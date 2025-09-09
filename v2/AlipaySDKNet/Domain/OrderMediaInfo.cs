using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderMediaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderMediaInfo : AopObject
    {
        /// <summary>
        /// 资源封面地址
        /// </summary>
        [XmlElement("poster_url")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资源访问链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
