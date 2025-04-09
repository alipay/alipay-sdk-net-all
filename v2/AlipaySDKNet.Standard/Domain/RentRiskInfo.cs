using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentRiskInfo : AopObject
    {
        /// <summary>
        /// 风控结果
        /// </summary>
        [XmlElement("risk_result")]
        public string RiskResult { get; set; }

        /// <summary>
        /// 风控结果描述
        /// </summary>
        [XmlElement("risk_result_desc")]
        public string RiskResultDesc { get; set; }

        /// <summary>
        /// 风控场景
        /// </summary>
        [XmlElement("risk_sense")]
        public string RiskSense { get; set; }
    }
}
