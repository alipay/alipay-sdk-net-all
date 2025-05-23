using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechWeatherFutureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechWeatherFutureQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 需要预测的天数,为 0 到 14 之间的整数
        /// </summary>
        [XmlElement("forecast_days")]
        public long ForecastDays { get; set; }

        /// <summary>
        /// 纬度，单位°
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，单位 °
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 此前预测的天数, 为 1 到 5 之间的整数，此前几天的预测结果
        /// </summary>
        [XmlElement("past_days")]
        public long PastDays { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 8 - Asia/Shanghai （北京时间，UTC+8）
        /// </summary>
        [XmlElement("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// 气象变量查询标记
        /// </summary>
        [XmlElement("weather_variables_mark")]
        public WeatherVariablesMark WeatherVariablesMark { get; set; }
    }
}
