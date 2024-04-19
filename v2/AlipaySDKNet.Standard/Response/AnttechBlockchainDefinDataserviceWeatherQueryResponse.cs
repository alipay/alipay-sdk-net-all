using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceWeatherQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceWeatherQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据预报时间
        /// </summary>
        [XmlElement("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 湿度值
        /// </summary>
        [XmlElement("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 降水值
        /// </summary>
        [XmlElement("precipitation")]
        public string Precipitation { get; set; }

        /// <summary>
        /// 温度值
        /// </summary>
        [XmlElement("temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// 天气描述信息
        /// </summary>
        [XmlElement("weather_desc")]
        public string WeatherDesc { get; set; }

        /// <summary>
        /// 风速值
        /// </summary>
        [XmlElement("wind_speed")]
        public string WindSpeed { get; set; }
    }
}
