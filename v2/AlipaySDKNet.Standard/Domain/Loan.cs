using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Loan Data Structure.
    /// </summary>
    [Serializable]
    public class Loan : AopObject
    {
        /// <summary>
        /// 支用受理单号，蚂蚁侧生成
        /// </summary>
        [XmlElement("institution_loan_apply_no")]
        public string InstitutionLoanApplyNo { get; set; }

        /// <summary>
        /// 蚂蚁侧借据号
        /// </summary>
        [XmlElement("institution_loan_no")]
        public string InstitutionLoanNo { get; set; }

        /// <summary>
        /// 利率，年利率，360，保留6位小数
        /// </summary>
        [XmlElement("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// 支用放款金额，元，保留2位小数
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 外部渠道支用申请单号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 借款结束时间（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("loan_end_date")]
        public string LoanEndDate { get; set; }

        /// <summary>
        /// 支用日(放款日)，（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("loan_start_date")]
        public string LoanStartDate { get; set; }

        /// <summary>
        /// 贷款期限 6/11/12
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位 MONTH - 月
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 每期固定还款日 1到28
        /// </summary>
        [XmlElement("repayment_day")]
        public long RepaymentDay { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [XmlElement("repayment_method")]
        public string RepaymentMethod { get; set; }

        /// <summary>
        /// 借据状态 NEW - 正常 OVERDUE - 逾期 SETTLED - 结清
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 未还款分期数
        /// </summary>
        [XmlElement("unpaid_installment_count")]
        public long UnpaidInstallmentCount { get; set; }

        /// <summary>
        /// 未还款利息
        /// </summary>
        [XmlElement("unpaid_interest")]
        public string UnpaidInterest { get; set; }

        /// <summary>
        /// 未还罚息（逾期本金罚息+逾期利息罚息）
        /// </summary>
        [XmlElement("unpaid_penalty")]
        public string UnpaidPenalty { get; set; }

        /// <summary>
        /// 未还本金（正常本金+逾期本金），元，保留2位小数
        /// </summary>
        [XmlElement("unpaid_principal")]
        public string UnpaidPrincipal { get; set; }
    }
}
