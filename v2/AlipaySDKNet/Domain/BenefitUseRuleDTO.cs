using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitUseRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitUseRuleDTO : AopObject
    {
        /// <summary>
        /// 权益使用规则
        /// </summary>
        [XmlElement("benefit_use_limit")]
        public BenefitUseLimitDTO BenefitUseLimit { get; set; }

        /// <summary>
        /// 权益生效时间
        /// </summary>
        [XmlElement("benefit_valid_period")]
        public BenefitValidPeriodDTO BenefitValidPeriod { get; set; }

        /// <summary>
        /// 权益的使用范围
        /// </summary>
        [XmlElement("usage_scope")]
        public BenefitUsageScopeDTO UsageScope { get; set; }
    }
}
