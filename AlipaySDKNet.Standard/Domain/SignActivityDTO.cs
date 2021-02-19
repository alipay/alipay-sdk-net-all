using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignActivityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignActivityDTO : AopObject
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 活动报名时间
        /// </summary>
        [XmlElement("activity_entry_time")]
        public string ActivityEntryTime { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 活动打标名称
        /// </summary>
        [XmlElement("activity_tag_name")]
        public string ActivityTagName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }
    }
}
