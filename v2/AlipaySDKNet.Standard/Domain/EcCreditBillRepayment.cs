using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcCreditBillRepayment Data Structure.
    /// </summary>
    [Serializable]
    public class EcCreditBillRepayment : AopObject
    {
        /// <summary>
        /// 银行借据单号
        /// </summary>
        [XmlElement("bank_loan_no")]
        public string BankLoanNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 企业当时借款剩余待还金额，单位元，精确到分
        /// </summary>
        [XmlElement("loan_balance")]
        public string LoanBalance { get; set; }

        /// <summary>
        /// 商户借款申请单号
        /// </summary>
        [XmlElement("loan_out_biz_no")]
        public string LoanOutBizNo { get; set; }

        /// <summary>
        /// 企业授信账单还款金额，单位元，精确到分
        /// </summary>
        [XmlElement("repay_capital")]
        public string RepayCapital { get; set; }

        /// <summary>
        /// 企业授信账单还款时间
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 企业授信账单还款利息，单位元，精确到分
        /// </summary>
        [XmlElement("repay_interest")]
        public string RepayInterest { get; set; }

        /// <summary>
        /// 枚举类型，P-部分还款、F-全额还款
        /// </summary>
        [XmlElement("repay_status")]
        public string RepayStatus { get; set; }
    }
}
