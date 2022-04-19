using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FloorVideo Data Structure.
    /// </summary>
    [Serializable]
    public class FloorVideo : AopObject
    {
        /// <summary>
        /// 货柜层号
        /// </summary>
        [XmlElement("floor_id")]
        public string FloorId { get; set; }

        /// <summary>
        /// 当前人工层是否有变化
        /// </summary>
        [XmlElement("if_changed")]
        public bool IfChanged { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        [XmlArray("video_urls")]
        [XmlArrayItem("string")]
        public List<string> VideoUrls { get; set; }
    }
}
