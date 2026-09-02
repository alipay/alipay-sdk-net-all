using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechWeatherLongrangeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechWeatherLongrangeQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 预测天数，限制 16-45。
        /// </summary>
        [XmlElement("forecast_days")]
        public long ForecastDays { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，表示地理位置的经度坐标，单位为度。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 取值范围： temperature2m dewPoint2m apparentTemperature relativeHumidity2m pressureMsl surfacePressure weatherCode precipitation cloudCover windSpeed10m windSpeed100m windSpeed200m windDirection10m windDirection100m windDirection200m shortwaveRadiationInstant directRadiationInstant diffuseRadiationInstant shortwaveRadiation directRadiation diffuseRadiation windGusts10m temperatureMax2m temperatureMin2m
        /// </summary>
        [XmlArray("weather_variables")]
        [XmlArrayItem("string")]
        public List<string> WeatherVariables { get; set; }
    }
}
