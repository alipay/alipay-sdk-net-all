using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskBasicInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskBasicInfoVO : AopObject
    {
        /// <summary>
        /// 风控策略
        /// </summary>
        [XmlElement("risk_policy_value")]
        public string RiskPolicyValue { get; set; }

        /// <summary>
        /// 订单风控评估ID
        /// </summary>
        [XmlElement("risk_scheme_id")]
        public string RiskSchemeId { get; set; }
    }
}
