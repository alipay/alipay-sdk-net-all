using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CanNoUseLimitDayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CanNoUseLimitDayInfo : AopObject
    {
        /// <summary>
        /// 限制结束日期（yyyy-MM-dd）
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

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
        /// 限制开始日期（格式：yyyy-MM-dd）
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 限制开始时间（HH:mm:ss）。表示限制到具体时间区间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
