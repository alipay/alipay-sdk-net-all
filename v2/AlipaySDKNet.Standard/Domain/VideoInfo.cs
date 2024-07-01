using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VideoInfo : AopObject
    {
        /// <summary>
        /// 视频时长，单位为秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 视频高度
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 视频大小，单位为MB
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 视频URL地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 视频宽度
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
