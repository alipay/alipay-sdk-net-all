using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAllocaterulePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolAllocaterulePayModel : AopObject
    {
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
        /// 资金池规则组唯一标识
        /// </summary>
        [XmlElement("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
