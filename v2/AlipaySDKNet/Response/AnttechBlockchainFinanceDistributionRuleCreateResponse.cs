using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceDistributionRuleCreateResponse.
    /// </summary>
    public class AnttechBlockchainFinanceDistributionRuleCreateResponse : AopResponse
    {
        /// <summary>
        /// 收益分配规则Id
        /// </summary>
        [XmlElement("distribution_rule_id")]
        public string DistributionRuleId { get; set; }

        /// <summary>
        /// 规则状态: ACTIVE - 规则生效; INACTIVE - 规则未生效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
