using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgWeatherDisasterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgWeatherDisasterInfo : AopObject
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
        /// 预测日期，YYYYMMDD
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 高温预警指数，值域0～1
        /// </summary>
        [XmlElement("high_temperature_index")]
        public string HighTemperatureIndex { get; set; }

        /// <summary>
        /// 高温风险等级，值域0～5，按严重程度递增
        /// </summary>
        [XmlElement("high_temperature_level")]
        public long HighTemperatureLevel { get; set; }

        /// <summary>
        /// 低温预警指数，值域0～1
        /// </summary>
        [XmlElement("low_temperature_index")]
        public string LowTemperatureIndex { get; set; }

        /// <summary>
        /// 低温风险等级，值域0～5，按严重程度递增
        /// </summary>
        [XmlElement("low_temperature_level")]
        public string LowTemperatureLevel { get; set; }

        /// <summary>
        /// 暴雨预警指数，值域0～1
        /// </summary>
        [XmlElement("rainstorm_index")]
        public string RainstormIndex { get; set; }

        /// <summary>
        /// 暴雨风险等级，值域0～3，按严重程度递增
        /// </summary>
        [XmlElement("rainstorm_level")]
        public long RainstormLevel { get; set; }
    }
}
