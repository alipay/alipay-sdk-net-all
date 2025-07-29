using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAccountFsFundInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAccountFsFundInfoDTO : AopObject
    {
        /// <summary>
        /// 账户查询时为出资金额；提现时为该出资方提现金额；单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 可核销金额，提现时不需要传，单位：元
        /// </summary>
        [XmlElement("current_amount")]
        public string CurrentAmount { get; set; }

        /// <summary>
        /// 商户出资
        /// </summary>
        [XmlElement("fund_provider")]
        public string FundProvider { get; set; }

        /// <summary>
        /// 出资资金类型，目前仅支持BALANCE
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 出资方的用户ID
        /// </summary>
        [XmlElement("fund_user_id")]
        public string FundUserId { get; set; }
    }
}
