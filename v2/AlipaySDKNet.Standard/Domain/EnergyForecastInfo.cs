using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyForecastInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyForecastInfo : AopObject
    {
        /// <summary>
        /// 预测服务对应的预测值
        /// </summary>
        [XmlElement("prediction")]
        public string Prediction { get; set; }

        /// <summary>
        /// 预测时间点
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
