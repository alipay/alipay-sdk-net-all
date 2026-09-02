using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerPaymentsRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerPaymentsRefundModel : AopObject
    {
        /// <summary>
        /// 支付单ID
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public MultiCurrencyMoneyDTO RefundAmount { get; set; }

        /// <summary>
        /// 退款通知地址
        /// </summary>
        [XmlElement("refund_notify_url")]
        public string RefundNotifyUrl { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求ID
        /// </summary>
        [XmlElement("refund_request_id")]
        public string RefundRequestId { get; set; }
    }
}
