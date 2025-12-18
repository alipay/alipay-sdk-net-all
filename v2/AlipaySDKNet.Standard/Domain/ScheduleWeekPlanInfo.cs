using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleWeekPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleWeekPlanInfo : AopObject
    {
        /// <summary>
        /// 每天可排期的结束时间 格式24小时制 21:30
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 周几  1-7
        /// </summary>
        [XmlElement("day_of_week")]
        public long DayOfWeek { get; set; }

        /// <summary>
        /// 每天可排期的开始时间 格式24小时制 09:30
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }
    }
}
