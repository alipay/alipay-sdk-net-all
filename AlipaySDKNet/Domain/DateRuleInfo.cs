using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DateRuleInfo : AopObject
    {
        /// <summary>
        /// 日期范围
        /// </summary>
        [XmlElement("date_range_info")]
        public DateRangeInfo DateRangeInfo { get; set; }

        /// <summary>
        /// 时间段
        /// </summary>
        [XmlElement("time_range_info")]
        public TimeRangeInfo TimeRangeInfo { get; set; }
    }
}
