using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSettlementQueryResponse : AopResponse
    {
        /// <summary>
        /// 行程描述等展示信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行程单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 行程总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号，只有交易支付成功后才会返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行程扣款状态： "I":"待支付"; "PI":"支付中（请重试）"; "S":"支付成功"; "F":"支付失败"; "RI":"退款中（请重试）"; "R":"已退款"
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付宝收到行程后的ETC行程Id
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }
    }
}
