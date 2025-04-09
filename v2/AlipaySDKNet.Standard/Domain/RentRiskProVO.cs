using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRiskProVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRiskProVO : AopObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险级别数据类型
        /// </summary>
        [XmlElement("risk_level_type")]
        public string RiskLevelType { get; set; }
    }
}
