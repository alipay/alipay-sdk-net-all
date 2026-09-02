using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PredictionResultPointDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PredictionResultPointDTO : AopObject
    {
        /// <summary>
        /// 预测时间，格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("forecast_time")]
        public string ForecastTime { get; set; }

        /// <summary>
        /// 预测结果
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
