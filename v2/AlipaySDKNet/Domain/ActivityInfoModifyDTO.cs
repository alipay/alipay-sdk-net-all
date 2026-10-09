using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 活动编码ID，活动的唯一标识
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 需要更新的活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 需要更新的活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 需要更新的活动票据链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 需要更新的活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 需要更新的活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
