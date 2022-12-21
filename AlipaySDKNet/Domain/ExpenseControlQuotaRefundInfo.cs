using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseControlQuotaRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseControlQuotaRefundInfo : AopObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款单据号
        /// </summary>
        [XmlElement("refund_no")]
        public string RefundNo { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
