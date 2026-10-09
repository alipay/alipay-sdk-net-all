using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HolidayRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HolidayRuleInfo : AopObject
    {
        /// <summary>
        /// 时间段
        /// </summary>
        [XmlElement("time_range_info")]
        public TimeRangeInfo TimeRangeInfo { get; set; }
    }
}
