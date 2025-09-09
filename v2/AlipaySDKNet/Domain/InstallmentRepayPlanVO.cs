using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentRepayPlanVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentRepayPlanVO : AopObject
    {
        /// <summary>
        /// 账单到期还款日
        /// </summary>
        [XmlElement("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 实际还款金额:本金和利息 没有还款则为全部0
        /// </summary>
        [XmlElement("payed_amount")]
        public BillTermAmountVO PayedAmount { get; set; }

        /// <summary>
        /// 有还款,则返回最新的还款时间;没有还款:则为空
        /// </summary>
        [XmlElement("payed_date")]
        public string PayedDate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 账单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分期金额,是到期应还
        /// </summary>
        [XmlElement("term_amount")]
        public BillTermAmountVO TermAmount { get; set; }

        /// <summary>
        /// 分期期数，默认M，代表月份
        /// </summary>
        [XmlElement("term_num")]
        public string TermNum { get; set; }

        /// <summary>
        /// 账单待还款总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
