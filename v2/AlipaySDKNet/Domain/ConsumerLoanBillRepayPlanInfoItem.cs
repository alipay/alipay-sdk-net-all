using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillRepayPlanInfoItem Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillRepayPlanInfoItem : AopObject
    {
        /// <summary>
        /// 该还款计划详情关联的账单ID
        /// </summary>
        [XmlElement("bill_id")]
        public string BillId { get; set; }

        /// <summary>
        /// 当前该笔还款所归属的借据号
        /// </summary>
        [XmlElement("loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// 在该项还款计划所关联的借据中的期号
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 还款金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("repay_amount")]
        public long RepayAmount { get; set; }

        /// <summary>
        /// 账单还款日，日期格式为YYYY-MM-DD hh:mm:ss
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 还款计划状态，包含逾期（OVER_DUE）或正常（NORMAL）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
