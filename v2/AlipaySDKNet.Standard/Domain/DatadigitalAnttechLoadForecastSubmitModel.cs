using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechLoadForecastSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechLoadForecastSubmitModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 需要预测的时间点位，时间间隔一致，建议数量在history_date长度的1/3及以下
        /// </summary>
        [XmlArray("future_date")]
        [XmlArrayItem("date")]
        public List<string> FutureDate { get; set; }

        /// <summary>
        /// 要求时间点连续，时间间隔一致。 时间长度最长支持21天。
        /// </summary>
        [XmlArray("history_date")]
        [XmlArrayItem("date")]
        public List<string> HistoryDate { get; set; }

        /// <summary>
        /// 负荷数据历史y值，要求与时间点按顺序一一对应。 单位无限制，与数值保持一致即可。
        /// </summary>
        [XmlArray("history_value")]
        [XmlArrayItem("string")]
        public List<string> HistoryValue { get; set; }

        /// <summary>
        /// 业务请求ID，调用方需要确保唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
