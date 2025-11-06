using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderPayRefundResponse.
    /// </summary>
    public class AlipayCommerceRentOrderPayRefundResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付创建时传入的商户外部交易ID
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
