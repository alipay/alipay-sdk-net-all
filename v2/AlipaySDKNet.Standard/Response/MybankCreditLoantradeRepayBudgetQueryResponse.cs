using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeRepayBudgetQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeRepayBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请还款本金
        /// </summary>
        [XmlElement("apply_repay_prin")]
        public string ApplyRepayPrin { get; set; }

        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 当前应还费用（提前还款费除外）
        /// </summary>
        [XmlElement("should_repay_fee")]
        public string ShouldRepayFee { get; set; }

        /// <summary>
        /// 当前应还利息
        /// </summary>
        [XmlElement("should_repay_int")]
        public string ShouldRepayInt { get; set; }

        /// <summary>
        /// 当前应还罚息
        /// </summary>
        [XmlElement("should_repay_penalty")]
        public string ShouldRepayPenalty { get; set; }

        /// <summary>
        /// 提前还款费
        /// </summary>
        [XmlElement("should_repay_pre_fee")]
        public string ShouldRepayPreFee { get; set; }

        /// <summary>
        /// 当前应还本金
        /// </summary>
        [XmlElement("should_repay_prin")]
        public string ShouldRepayPrin { get; set; }
    }
}
