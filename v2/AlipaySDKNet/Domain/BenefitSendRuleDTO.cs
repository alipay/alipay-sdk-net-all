using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitSendRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitSendRuleDTO : AopObject
    {
        /// <summary>
        /// 预算
        /// </summary>
        [XmlElement("budget")]
        public BenefitBudgetDTO Budget { get; set; }

        /// <summary>
        /// 领取规则限制
        /// </summary>
        [XmlArray("collect_limit_rules")]
        [XmlArrayItem("collect_limit_rule_d_t_o")]
        public List<CollectLimitRuleDTO> CollectLimitRules { get; set; }
    }
}
