using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatVideos Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatVideos : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 视频详细信息
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("video_value_request")]
        public List<VideoValueRequest> Value { get; set; }
    }
}
