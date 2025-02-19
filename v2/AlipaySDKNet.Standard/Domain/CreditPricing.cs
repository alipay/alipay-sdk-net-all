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
        /// 年利率，如为8%，则为0.08
        /// </summary>
        [XmlElement("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// 贷款期限长度
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
