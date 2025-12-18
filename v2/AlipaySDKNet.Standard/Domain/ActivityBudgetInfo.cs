using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityBudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityBudgetInfo : AopObject
    {
        /// <summary>
        /// 活动的预算金额，单位元；当优惠类型为折扣或者满立减时，预算金额需要大于最高优惠金额的5倍
        /// </summary>
        [XmlElement("budget_amount")]
        public string BudgetAmount { get; set; }

        /// <summary>
        /// 出资方的支付宝账号
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 活动预算的出资方
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }
    }
}
