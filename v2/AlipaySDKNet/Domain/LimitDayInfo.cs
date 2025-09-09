using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LimitDayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LimitDayInfo : AopObject
    {
        /// <summary>
        /// 周一到周日可用列表。设置卡的可用时间段，按周维度设置
        /// </summary>
        [XmlArray("days_of_week")]
        [XmlArrayItem("string")]
        public List<string> DaysOfWeek { get; set; }

        /// <summary>
        /// 限制结束时间（HH:mm:ss）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 限制结束时间类型。表示end_time是当天还是次日的时间
        /// </summary>
        [XmlElement("end_time_type")]
        public string EndTimeType { get; set; }

        /// <summary>
        /// 限制开始时间（HH:mm:ss）。表示限制到具体时间区间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
