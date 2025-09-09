using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceRentOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// orderType=BUYOUT时，使用trade_no拉起收银台支付
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
