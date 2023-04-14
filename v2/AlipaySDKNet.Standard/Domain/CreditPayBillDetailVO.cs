using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayBillDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayBillDetailVO : AopObject
    {
        /// <summary>
        /// 出账日
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单期次描述，如9月或，9月第1周
        /// </summary>
        [XmlElement("bill_term_desc")]
        public string BillTermDesc { get; set; }

        /// <summary>
        /// 还款日
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 还款费用
        /// </summary>
        [XmlElement("repay_fee_amt")]
        public CreditPayMoneyVO RepayFeeAmt { get; set; }

        /// <summary>
        /// 还款利息金额
        /// </summary>
        [XmlElement("repay_int_amt")]
        public CreditPayMoneyVO RepayIntAmt { get; set; }

        /// <summary>
        /// 还款本金
        /// </summary>
        [XmlElement("repay_prin_amt")]
        public CreditPayMoneyVO RepayPrinAmt { get; set; }

        /// <summary>
        /// 总还款金额
        /// </summary>
        [XmlElement("total_repay_amt")]
        public CreditPayMoneyVO TotalRepayAmt { get; set; }
    }
}
