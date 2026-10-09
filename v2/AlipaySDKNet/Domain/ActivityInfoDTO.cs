using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityInfoDTO : AopObject
    {
        /// <summary>
        /// 活动编码ID，活动的唯一标识
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动所在的城市名
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动票链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 活动地点
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
