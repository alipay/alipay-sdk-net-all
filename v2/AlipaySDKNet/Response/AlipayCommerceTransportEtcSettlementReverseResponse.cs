using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementReverseResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSettlementReverseResponse : AopResponse
    {
        /// <summary>
        /// 商户行程单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 交易状态：仅“C”代表撤销完成，其他参考交易状态</br> "I":"待支付，未撤销完成"; </br> "PI":"支付中，未撤销完成"; </br> "S":"支付成功，未撤销完成"; </br> "F":"支付失败，未撤销完成"; </br> "RI":"退款中，不支持撤销"; </br> "R":"已退款，不支持撤销";</br> "C":"已撤销，说明撤销完成";</br>
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
