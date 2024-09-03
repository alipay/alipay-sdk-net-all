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
        /// 视频原始的Ur
        /// </summary>
        [XmlElement("origin_url")]
        public string OriginUrl { get; set; }

        /// <summary>
        /// 视频转存在oss中的地址url
        /// </summary>
        [XmlElement("oss_url")]
        public string OssUrl { get; set; }

        /// <summary>
        /// 视频封面图片url
        /// </summary>
        [XmlElement("poster_url")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// 可以用来识别内容相同的视频
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }

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
