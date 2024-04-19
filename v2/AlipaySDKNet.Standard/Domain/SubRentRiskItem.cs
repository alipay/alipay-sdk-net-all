using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubRentRiskItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubRentRiskItem : AopObject
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }

        /// <summary>
        /// 极低风险
        /// </summary>
        [XmlElement("risk_rank")]
        public string RiskRank { get; set; }
    }
}
