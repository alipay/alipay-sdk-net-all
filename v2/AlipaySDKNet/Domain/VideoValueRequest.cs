using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VideoValueRequest Data Structure.
    /// </summary>
    [Serializable]
    public class VideoValueRequest : AopObject
    {
        /// <summary>
        /// 视频文件AFTS id，为afts返回
        /// </summary>
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频文件名字
        /// </summary>
        [XmlElement("video_name")]
        public string VideoName { get; set; }

        /// <summary>
        /// 视频文件大小
        /// </summary>
        [XmlElement("video_size")]
        public long VideoSize { get; set; }

        /// <summary>
        /// 视频类型
        /// </summary>
        [XmlElement("video_type")]
        public string VideoType { get; set; }
    }
}
