using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechEnergyPredictionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechEnergyPredictionQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 预测类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 预测查询结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 预测对象，场站的就是场站id，电价就是
        /// </summary>
        [XmlElement("forecast_id")]
        public string ForecastId { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 预测查询开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
