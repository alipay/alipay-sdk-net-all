using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAllocateruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolAllocateruleCreateModel : AopObject
    {
        /// <summary>
        /// 转账规则
        /// </summary>
        [XmlElement("allocation_rule")]
        public InstCashPoolAllocationRuleVO AllocationRule { get; set; }

        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 对应的规则组ID
        /// </summary>
        [XmlElement("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
