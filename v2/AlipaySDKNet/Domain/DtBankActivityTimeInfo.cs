using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankActivityTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankActivityTimeInfo : AopObject
    {
        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动时间区间列表，表示单日内活动时间区间。
        /// </summary>
        [XmlArray("time_period_list")]
        [XmlArrayItem("string")]
        public List<string> TimePeriodList { get; set; }

        /// <summary>
        /// 活动时间日列表。例如["MON","TUE","WEB"]表示周一、周二、周三可以参与活动。周一至周日分别使用以下字符串表示：MON，TUE，WEB，THU，FRI，SAT，SUN。
        /// </summary>
        [XmlArray("week_day_list")]
        [XmlArrayItem("string")]
        public List<string> WeekDayList { get; set; }
    }
}
