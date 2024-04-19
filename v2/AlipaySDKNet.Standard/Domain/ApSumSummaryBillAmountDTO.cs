using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApSumSummaryBillAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApSumSummaryBillAmountDTO : AopObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [XmlElement("bill_amount")]
        public MultiCurrencyMoneyOpenApi BillAmount { get; set; }

        /// <summary>
        /// 已出账金额
        /// </summary>
        [XmlElement("checkout_amount")]
        public MultiCurrencyMoneyOpenApi CheckoutAmount { get; set; }

        /// <summary>
        /// 已确认金额
        /// </summary>
        [XmlElement("confirmed_amount")]
        public MultiCurrencyMoneyOpenApi ConfirmedAmount { get; set; }

        /// <summary>
        /// 已结算金额
        /// </summary>
        [XmlElement("settled_amount")]
        public MultiCurrencyMoneyOpenApi SettledAmount { get; set; }

        /// <summary>
        /// 结算总金额
        /// </summary>
        [XmlElement("settling_amount")]
        public MultiCurrencyMoneyOpenApi SettlingAmount { get; set; }

        /// <summary>
        /// 待确认金额
        /// </summary>
        [XmlElement("un_confirmed_amount")]
        public MultiCurrencyMoneyOpenApi UnConfirmedAmount { get; set; }

        /// <summary>
        /// 待结算金额
        /// </summary>
        [XmlElement("un_settle_amount")]
        public MultiCurrencyMoneyOpenApi UnSettleAmount { get; set; }
    }
}
