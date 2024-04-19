using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditBillGetResponse.
    /// </summary>
    public class AlipayCommerceEcCreditBillGetResponse : AopResponse
    {
        /// <summary>
        /// 当前期数
        /// </summary>
        [XmlElement("cp_numbers")]
        public string CpNumbers { get; set; }

        /// <summary>
        /// 本期应还利息，单位元，精度分
        /// </summary>
        [XmlElement("cp_payable_interest")]
        public string CpPayableInterest { get; set; }

        /// <summary>
        /// 本期应还罚息，单位元
        /// </summary>
        [XmlElement("cp_payable_penalty")]
        public string CpPayablePenalty { get; set; }

        /// <summary>
        /// 本期应还本金，单位元，精度分
        /// </summary>
        [XmlElement("cp_payable_principal")]
        public string CpPayablePrincipal { get; set; }

        /// <summary>
        /// 本期未还利息，单位元，精度分
        /// </summary>
        [XmlElement("cp_unpaid_interest")]
        public string CpUnpaidInterest { get; set; }

        /// <summary>
        /// 本期未还罚息，单位元
        /// </summary>
        [XmlElement("cp_unpaid_penalty")]
        public string CpUnpaidPenalty { get; set; }

        /// <summary>
        /// 本期未还本金，单位元，精度分
        /// </summary>
        [XmlElement("cp_unpaid_principal")]
        public string CpUnpaidPrincipal { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否预期：Y-逾期、N-未逾期
        /// </summary>
        [XmlElement("overdue")]
        public string Overdue { get; set; }

        /// <summary>
        /// 还款状态：Y-已还款、N-未还款
        /// </summary>
        [XmlElement("payment_status")]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// 还款日期，格式"yyyy-MM-dd"
        /// </summary>
        [XmlElement("repayment_date")]
        public string RepaymentDate { get; set; }
    }
}
