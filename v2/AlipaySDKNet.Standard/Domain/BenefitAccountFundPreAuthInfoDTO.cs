using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAccountFundPreAuthInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAccountFundPreAuthInfoDTO : AopObject
    {
        /// <summary>
        /// 权益账户可采买金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 预授权预算ID
        /// </summary>
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 充值总金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
