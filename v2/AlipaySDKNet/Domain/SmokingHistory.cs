using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmokingHistory Data Structure.
    /// </summary>
    [Serializable]
    public class SmokingHistory : AopObject
    {
        /// <summary>
        /// 日吸烟量（支）
        /// </summary>
        [XmlElement("daily_smoking")]
        public string DailySmoking { get; set; }

        /// <summary>
        /// 单位（支）、包
        /// </summary>
        [XmlElement("daily_smoking_unit")]
        public string DailySmokingUnit { get; set; }

        /// <summary>
        /// 最后吸烟时间
        /// </summary>
        [XmlElement("last_smoking")]
        public string LastSmoking { get; set; }

        /// <summary>
        /// 是否戒烟
        /// </summary>
        [XmlElement("smoking_cessation")]
        public string SmokingCessation { get; set; }

        /// <summary>
        /// 吸烟时间（年）
        /// </summary>
        [XmlElement("smoking_time")]
        public string SmokingTime { get; set; }

        /// <summary>
        /// 吸烟时间，单位 年、月、日
        /// </summary>
        [XmlElement("smoking_time_unit")]
        public string SmokingTimeUnit { get; set; }
    }
}
