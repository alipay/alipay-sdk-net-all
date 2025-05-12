using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPricing Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPricing : AopObject
    {
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 是否默认定价
        /// </summary>
        [XmlElement("default_credit_pricing")]
        public bool DefaultCreditPricing { get; set; }

        /// <summary>
        /// 年利率，如为8%，则为0.08
        /// </summary>
        [XmlElement("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// 贷款期限长度，单位根据loan_term_unit字段决定(Y年/M月/D日)
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位：Y、M、D分别代表年月日
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }
    }
}
