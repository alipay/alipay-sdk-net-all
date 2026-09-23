using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDirectTradeRefundResponse.
    /// </summary>
    public class AlipayCommerceMedicalDirectTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 支付宝jiao yi dan ha
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部交易单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额，单位是元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款失败原因
        /// </summary>
        [XmlElement("refund_msg")]
        public string RefundMsg { get; set; }

        /// <summary>
        /// 退款请求流水号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 退款成功
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款成功时该字段有值
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 逸康交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
