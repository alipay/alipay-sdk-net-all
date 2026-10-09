using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAccountFundBudgetInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAccountFundBudgetInfoDTO : AopObject
    {
        /// <summary>
        /// 退回预算，实际可能未退资金，单位：元
        /// </summary>
        [XmlElement("back_budget")]
        public string BackBudget { get; set; }

        /// <summary>
        /// 退回资金，单位：元
        /// </summary>
        [XmlElement("back_cash")]
        public string BackCash { get; set; }

        /// <summary>
        /// 追加预算总额，实际可能没有真实入金；单位：元
        /// </summary>
        [XmlElement("in_budget")]
        public string InBudget { get; set; }

        /// <summary>
        /// 入金金额，真实追加的资金，单位：元
        /// </summary>
        [XmlElement("in_cash")]
        public string InCash { get; set; }
    }
}
