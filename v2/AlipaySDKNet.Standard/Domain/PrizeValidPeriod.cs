using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeValidPeriod Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeValidPeriod : AopObject
    {
        /// <summary>
        /// 使用生效相对分钟数（相对时间）
        /// </summary>
        [XmlElement("active_min")]
        public long ActiveMin { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [XmlElement("active_mins")]
        public string ActiveMins { get; set; }

        /// <summary>
        /// 使用开始时间（绝对时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 使用截止相对分钟数（相对时间）
        /// </summary>
        [XmlElement("end_min")]
        public long EndMin { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [XmlElement("end_mins")]
        public string EndMins { get; set; }

        /// <summary>
        /// 使用截止时间（绝对时间）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// RELATIVE->相对时间 ABSOLUTE->绝对时间
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }
    }
}
