using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionRefundResponse.
    /// </summary>
    public class AlipayTradeSubscriptionRefundResponse : AopResponse
    {
        /// <summary>
        /// 商户退款请求号，与请求参数中的商户退款请求号一致
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次申请的退款金额，单位为分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 支付宝订阅退款业务单号，可用于关联退款结果通知
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款状态： PENDING - 待处理； PROCESSING - 退款处理中； SUCCESS - 退款成功； PARTIAL_SUCCESS - 部分退款成功； FAILED - 退款失败
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 订阅ID
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 本次退款对应的支付宝原交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
