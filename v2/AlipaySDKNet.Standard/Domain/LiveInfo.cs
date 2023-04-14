using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LiveInfo : AopObject
    {
        /// <summary>
        /// 直播内容信息列表
        /// </summary>
        [XmlArray("content_info_list")]
        [XmlArrayItem("live_content_info")]
        public List<LiveContentInfo> ContentInfoList { get; set; }

        /// <summary>
        /// 直播结束时间
        /// </summary>
        [XmlElement("live_end_time")]
        public string LiveEndTime { get; set; }

        /// <summary>
        /// 直播ID
        /// </summary>
        [XmlElement("live_id")]
        public string LiveId { get; set; }

        /// <summary>
        /// 直播开始时间
        /// </summary>
        [XmlElement("live_start_time")]
        public string LiveStartTime { get; set; }

        /// <summary>
        /// 直播摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 直播标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
