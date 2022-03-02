using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSettlementRefundResponse : AopResponse
    {
        /// <summary>
        /// 行程单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退款外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝收单：  "I","未知，原请求单号需要重试";  "RI", "退款中，原请求单号需要重试";  "R", "已退款";  "PR", "部分退款";
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款完成时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
