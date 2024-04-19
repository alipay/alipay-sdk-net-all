using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillRepayBudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class BillRepayBudgetVO : AopObject
    {
        /// <summary>
        /// 申请金额，和入参一致
        /// </summary>
        [XmlElement("apply_amount")]
        public MultiCurrencyMoneyVO ApplyAmount { get; set; }

        /// <summary>
        /// 账单编号，和入参中的账单编号相同
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 利息总额(含利息和逾期利息)
        /// </summary>
        [XmlElement("should_repay_int_amt")]
        public MultiCurrencyMoneyVO ShouldRepayIntAmt { get; set; }

        /// <summary>
        /// 罚息总额(本罚利罚和费罚)
        /// </summary>
        [XmlElement("should_repay_pen_amt")]
        public MultiCurrencyMoneyVO ShouldRepayPenAmt { get; set; }

        /// <summary>
        /// 本金总额(含本和逾本)
        /// </summary>
        [XmlElement("should_repay_prin_amt")]
        public MultiCurrencyMoneyVO ShouldRepayPrinAmt { get; set; }
    }
}
