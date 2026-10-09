using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechPvForecastSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechPvForecastSubmitModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 需要预测的时间点位，频率为15min 建议长度在history_date长度的1/3及以下 由于气象数据限制，最大长度限制在14天
        /// </summary>
        [XmlArray("future_date")]
        [XmlArrayItem("date")]
        public List<string> FutureDate { get; set; }

        /// <summary>
        /// 要求时间点连续，频率必须为15min
        /// </summary>
        [XmlArray("history_date")]
        [XmlArrayItem("date")]
        public List<string> HistoryDate { get; set; }

        /// <summary>
        /// 要求与时间点按顺序一一对应
        /// </summary>
        [XmlArray("history_value")]
        [XmlArrayItem("string")]
        public List<string> HistoryValue { get; set; }

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
        /// 请求 ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
