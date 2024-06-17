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
        /// 分期金额
        /// </summary>
        [XmlElement("term_amount")]
        public BillTermAmountVO TermAmount { get; set; }

        /// <summary>
        /// 分期期数
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
