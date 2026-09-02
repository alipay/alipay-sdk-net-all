using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeatherShortTermRainDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WeatherShortTermRainDTO : AopObject
    {
        /// <summary>
        /// 预报时间
        /// </summary>
        [XmlElement("forecast_time")]
        public string ForecastTime { get; set; }

        /// <summary>
        /// 降水量，单位 mm
        /// </summary>
        [XmlElement("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 降水类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
