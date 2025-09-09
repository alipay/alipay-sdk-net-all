using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayPlanTermDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayPlanTermDTO : AopObject
    {
        /// <summary>
        /// 优惠后本期总金额，单位:分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 是否逾期
        /// </summary>
        [XmlElement("overdue")]
        public bool Overdue { get; set; }

        /// <summary>
        /// 逾期金额，单位:分
        /// </summary>
        [XmlElement("overdue_amount")]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// 逾期天数
        /// </summary>
        [XmlElement("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 剩余应还还款金额，单位:分
        /// </summary>
        [XmlElement("payable_term_amount")]
        public string PayableTermAmount { get; set; }

        /// <summary>
        /// 剩余应还利息罚息，单位：分，有待还时必传
        /// </summary>
        [XmlElement("payable_term_inter_penalty")]
        public string PayableTermInterPenalty { get; set; }

        /// <summary>
        /// 剩余应还还款利息，单位：分，有待还时必传
        /// </summary>
        [XmlElement("payable_term_interest")]
        public string PayableTermInterest { get; set; }

        /// <summary>
        /// 剩余应还罚息，单位：分，有待还时必传
        /// </summary>
        [XmlElement("payable_term_penalty")]
        public string PayableTermPenalty { get; set; }

        /// <summary>
        /// 剩余应还本金罚息，单位：分，有待还时必传
        /// </summary>
        [XmlElement("payable_term_prin_penalty")]
        public string PayableTermPrinPenalty { get; set; }

        /// <summary>
        /// 剩余应还还款本金，单位：分，有待还时必传
        /// </summary>
        [XmlElement("payable_term_principal")]
        public string PayableTermPrincipal { get; set; }

        /// <summary>
        /// 应还款日期, yyyyMMdd
        /// </summary>
        [XmlElement("should_repay_date")]
        public string ShouldRepayDate { get; set; }

        /// <summary>
        /// 优惠前本期应还总额,单位: 分(termAmount=termPrincipal+termInterest)
        /// </summary>
        [XmlElement("term_amount")]
        public string TermAmount { get; set; }

        /// <summary>
        /// 本期应还利息罚息，单位：分
        /// </summary>
        [XmlElement("term_inter_penalty")]
        public string TermInterPenalty { get; set; }

        /// <summary>
        /// 优惠前本期应还利息，单位：分
        /// </summary>
        [XmlElement("term_interest")]
        public string TermInterest { get; set; }

        /// <summary>
        /// 期次
        /// </summary>
        [XmlElement("term_no")]
        public long TermNo { get; set; }

        /// <summary>
        /// 本期应还罚息，单位：分
        /// </summary>
        [XmlElement("term_penalty")]
        public string TermPenalty { get; set; }

        /// <summary>
        /// 本期应还本金罚息，单位：分
        /// </summary>
        [XmlElement("term_prin_penalty")]
        public string TermPrinPenalty { get; set; }

        /// <summary>
        /// 本期应还本金，单位：分
        /// </summary>
        [XmlElement("term_principal")]
        public string TermPrincipal { get; set; }

        /// <summary>
        /// 当期状态（1-已结清, 2-待还款, 3-部分已还,   4-逾期, 5-宽限期），只有待还款和逾期
        /// </summary>
        [XmlElement("term_status")]
        public long TermStatus { get; set; }

        /// <summary>
        /// 本期优惠金额，单位：分
        /// </summary>
        [XmlElement("term_total_discount")]
        public string TermTotalDiscount { get; set; }
    }
}
