using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeekRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WeekRuleInfo : AopObject
    {
        /// <summary>
        /// 时间段
        /// </summary>
        [XmlElement("time_range_info")]
        public TimeRangeInfo TimeRangeInfo { get; set; }

        /// <summary>
        /// 星期数，以“,”连接多个星期数
        /// </summary>
        [XmlElement("week_day")]
        public string WeekDay { get; set; }
    }
}
