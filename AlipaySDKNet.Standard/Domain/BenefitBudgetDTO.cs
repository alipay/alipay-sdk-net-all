using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitBudgetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitBudgetDTO : AopObject
    {
        /// <summary>
        /// 当前budget_type为amount时必填
        /// </summary>
        [XmlElement("amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// COUNT ： 数量类型;AMOUNT ： 金额行
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 当budgetType为COUNT时必填，填入的是权益的数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
