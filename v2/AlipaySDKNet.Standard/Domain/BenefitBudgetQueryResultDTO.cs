using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitBudgetQueryResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitBudgetQueryResultDTO : AopObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 金额型总预算
        /// </summary>
        [XmlElement("budget_total_amount")]
        public Amount BudgetTotalAmount { get; set; }

        /// <summary>
        /// 数量型总预算
        /// </summary>
        [XmlElement("budget_total_count")]
        public long BudgetTotalCount { get; set; }

        /// <summary>
        /// 预算类型
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 金额型预算剩余金额
        /// </summary>
        [XmlElement("remain_amount")]
        public Amount RemainAmount { get; set; }

        /// <summary>
        /// 数量型预算剩余数量,budgetType=COUNT 时有值
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }
    }
}
