using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionBatchRefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionBatchRefundDetail : AopObject
    {
        /// <summary>
        /// 当前退款单对应的对款金额，单位元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款单状态，如果是PENDING状态，则会继续重试退款
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 实际退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 退款的交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 针对当前的交易单号对应的退款单号，针对一笔交易单trade_no允许多次退款。多次退款时，每次退款的id不同即可
        /// </summary>
        [XmlElement("trade_refund_id")]
        public string TradeRefundId { get; set; }
    }
}
