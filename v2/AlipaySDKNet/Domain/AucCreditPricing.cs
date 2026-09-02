using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AucCreditPricing Data Structure.
    /// </summary>
    [Serializable]
    public class AucCreditPricing : AopObject
    {
        /// <summary>
        /// 资金利率，如为12.3%，则为0.123
        /// </summary>
        [XmlElement("funding_rate")]
        public string FundingRate { get; set; }

        /// <summary>
        /// 年利率，最终对客的利率，或称综合利率。 int_rate = funding_rate + serv_rate 如为12.6%，则为0.126
        /// </summary>
        [XmlElement("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// 贷款期限长度
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// 服务费率（融担费率、保险费率等），如为0.3%，则为0.003 注：如果不存在担保费率，则该字段不要传任何值（null） 0.003
        /// </summary>
        [XmlElement("serv_rate")]
        public string ServRate { get; set; }
    }
}
