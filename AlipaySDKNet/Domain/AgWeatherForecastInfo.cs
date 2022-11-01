using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgWeatherForecastInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgWeatherForecastInfo : AopObject
    {
        /// <summary>
        /// 数据实际日期，YYYYMMDD
        /// </summary>
        [XmlElement("actual_date")]
        public string ActualDate { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("addition_info")]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 平均温度，单位摄氏度
        /// </summary>
        [XmlElement("avg_temperature")]
        public string AvgTemperature { get; set; }

        /// <summary>
        /// 预报日期，YYYYMMDD
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 降水值，单位mm
        /// </summary>
        [XmlElement("precipitation")]
        public string Precipitation { get; set; }

        /// <summary>
        /// 辐射值，单位瓦
        /// </summary>
        [XmlElement("radiation")]
        public string Radiation { get; set; }

        /// <summary>
        /// 风速值，单位米/秒
        /// </summary>
        [XmlElement("wind_speed")]
        public string WindSpeed { get; set; }
    }
}
