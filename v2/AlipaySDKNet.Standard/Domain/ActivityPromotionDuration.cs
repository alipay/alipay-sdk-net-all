using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityPromotionDuration Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityPromotionDuration : AopObject
    {
        /// <summary>
        /// 参数allowed_days表示允许的星期枚举集合，取值范围为星期至星期日，共7个明确的枚举值。
        /// </summary>
        [XmlArray("allowed_days")]
        [XmlArrayItem("string")]
        public List<string> AllowedDays { get; set; }

        /// <summary>
        /// 允许的时间集合
        /// </summary>
        [XmlArray("allowed_times")]
        [XmlArrayItem("activity_time_range")]
        public List<ActivityTimeRange> AllowedTimes { get; set; }

        /// <summary>
        /// 活动时间限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
