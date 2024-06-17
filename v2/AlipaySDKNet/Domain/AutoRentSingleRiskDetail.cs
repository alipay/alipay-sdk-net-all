using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AutoRentSingleRiskDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AutoRentSingleRiskDetail : AopObject
    {
        /// <summary>
        /// 综合风险的描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 风控等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险分
        /// </summary>
        [XmlElement("risk_score")]
        public string RiskScore { get; set; }

        /// <summary>
        /// 提供风控服务的厂商
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
