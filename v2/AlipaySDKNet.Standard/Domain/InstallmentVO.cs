using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentVO : AopObject
    {
        /// <summary>
        /// 会计日
        /// </summary>
        [XmlElement("accounting_date")]
        public string AccountingDate { get; set; }

        /// <summary>
        /// 分期结束时间
        /// </summary>
        [XmlElement("installment_end_date")]
        public string InstallmentEndDate { get; set; }

        /// <summary>
        /// 分期号，第几期
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 分期开始时间
        /// </summary>
        [XmlElement("installment_start_date")]
        public string InstallmentStartDate { get; set; }

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
        /// 还款方式 AVERAGE_CAPITAL_PLUS_INTEREST 等额本息 BALLOON_MORTGAGE 按期付息到期还本
        /// </summary>
        [XmlElement("repayment_method")]
        public string RepaymentMethod { get; set; }

        /// <summary>
        /// 分期状态 NEW - 正常 OVERDUE - 逾期 SETTLED - 结清
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分期总期数 6/11/12
        /// </summary>
        [XmlElement("total_installment_no")]
        public long TotalInstallmentNo { get; set; }

        /// <summary>
        /// 未还款利息，单位元，保留2位小数
        /// </summary>
        [XmlElement("unpaid_interest")]
        public string UnpaidInterest { get; set; }

        /// <summary>
        /// 未还款罚息，单位元，保留2位小数
        /// </summary>
        [XmlElement("unpaid_penalty")]
        public string UnpaidPenalty { get; set; }

        /// <summary>
        /// 未还本金（正常本金+逾期本金），元，保留2位小数
        /// </summary>
        [XmlElement("unpaid_principal")]
        public string UnpaidPrincipal { get; set; }

        /// <summary>
        /// 应还总金额，单位元，保留小数点后两位
        /// </summary>
        [XmlElement("unpaid_total_amount")]
        public string UnpaidTotalAmount { get; set; }
    }
}
