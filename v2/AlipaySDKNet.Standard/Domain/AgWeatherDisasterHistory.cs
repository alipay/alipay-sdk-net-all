using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgWeatherDisasterHistory Data Structure.
    /// </summary>
    [Serializable]
    public class AgWeatherDisasterHistory : AopObject
    {
        /// <summary>
        /// 数据生产日期，YYYYMMDD
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 高温一年灾害天数
        /// </summary>
        [XmlElement("high_temperature_days")]
        public string HighTemperatureDays { get; set; }

        /// <summary>
        /// 高温一年灾害频率等级： 0-无风险，1-极低频，2-较低频，3-中度，4-较高频，5-极高频
        /// </summary>
        [XmlElement("high_temperature_level")]
        public string HighTemperatureLevel { get; set; }

        /// <summary>
        /// 低温一年灾害天数
        /// </summary>
        [XmlElement("low_temperature_days")]
        public string LowTemperatureDays { get; set; }

        /// <summary>
        /// 低温一年灾害频率等级： 0-无风险，1-极低频，2-较低频，3-中度，4-较高频，5-极高频
        /// </summary>
        [XmlElement("low_temperature_level")]
        public string LowTemperatureLevel { get; set; }

        /// <summary>
        /// 暴雨一年灾害天数
        /// </summary>
        [XmlElement("rainstorm_days")]
        public string RainstormDays { get; set; }

        /// <summary>
        /// 暴雨一年灾害频率等级： 0-无风险，1-极低频，2-较低频，3-中度，4-较高频，5-极高频
        /// </summary>
        [XmlElement("rainstorm_level")]
        public string RainstormLevel { get; set; }

        /// <summary>
        /// 数据更新日期，YYYYMMDD
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }
    }
}
