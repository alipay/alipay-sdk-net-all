using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerSettlementRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerSettlementRefundResponse : AopResponse
    {
        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 退款支付时间
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 退款外部请求号，多次退款会有
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝收单： "RI", "退款中"; "R", "已退款"; "PR", "部分退款"; 银行收单： "PART_PROCESS_REFUND", "受理部分退款"; "IN_PROCESSING_REFUND", "受理退款中"; "PROCESS_REFUND", "已受理退款".
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
