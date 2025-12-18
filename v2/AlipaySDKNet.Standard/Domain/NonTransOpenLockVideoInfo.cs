using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NonTransOpenLockVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NonTransOpenLockVideoInfo : AopObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 摄像头类型
        /// </summary>
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频地址集合
        /// </summary>
        [XmlArray("video_urls")]
        [XmlArrayItem("string")]
        public List<string> VideoUrls { get; set; }
    }
}
