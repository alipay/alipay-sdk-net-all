using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Recurring Data Structure.
    /// </summary>
    [Serializable]
    public class Recurring : AopObject
    {
        /// <summary>
        /// 订阅周期类型，目前支持DAY跟MONTH
        /// </summary>
        [XmlElement("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// 订阅周期数量，目前周期单位只支持月或日
        /// </summary>
        [XmlElement("interval_count")]
        public long IntervalCount { get; set; }

        /// <summary>
        /// 试用期天数
        /// </summary>
        [XmlElement("trial_period_days")]
        public long TrialPeriodDays { get; set; }

        /// <summary>
        /// 计费模式
        /// </summary>
        [XmlElement("usage_type")]
        public string UsageType { get; set; }
    }
}
