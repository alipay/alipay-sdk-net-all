using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeatherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WeatherInfo : AopObject
    {
        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("addition_info")]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 数据预报时间
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 降水值
        /// </summary>
        [XmlElement("precipitation")]
        public string Precipitation { get; set; }

        /// <summary>
        /// 辐射值
        /// </summary>
        [XmlElement("radiation")]
        public string Radiation { get; set; }

        /// <summary>
        /// 温度值
        /// </summary>
        [XmlElement("temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// 风速值
        /// </summary>
        [XmlElement("wind_speed")]
        public string WindSpeed { get; set; }
    }
}
