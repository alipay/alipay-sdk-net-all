using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechWeatherHistorySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechWeatherHistorySubmitModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 查询气象的结束日期，忽略时分秒。 结束日期 大于等于 开始日期。 开始日期和结束日期间隔不能超过7天
        /// </summary>
        [XmlElement("date_end")]
        public string DateEnd { get; set; }

        /// <summary>
        /// 查询气象的开始日期，忽略时分秒。 结束日期 大于等于 开始日期。 开始日期和结束日期间隔不能超过21天
        /// </summary>
        [XmlElement("date_start")]
        public string DateStart { get; set; }

        /// <summary>
        /// 纬度，单位°
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，单位°
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 请求流水
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 8 - Asia/Shanghai （北京时间，UTC+8）
        /// </summary>
        [XmlElement("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// 气象变量标记
        /// </summary>
        [XmlElement("weather_variables_mark")]
        public WeatherVariablesMark WeatherVariablesMark { get; set; }
    }
}
