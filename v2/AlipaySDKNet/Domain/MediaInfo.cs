using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MediaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MediaInfo : AopObject
    {
        /// <summary>
        /// 素材资源地址
        /// </summary>
        [XmlElement("media_source")]
        public string MediaSource { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [XmlElement("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 素材资源地址
        /// </summary>
        [XmlElement("media_url")]
        public string MediaUrl { get; set; }
    }
}
