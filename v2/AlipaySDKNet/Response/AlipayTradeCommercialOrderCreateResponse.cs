using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCommercialOrderCreateResponse.
    /// </summary>
    public class AlipayTradeCommercialOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 本次支付的收银台地址，可用于302跳转
        /// </summary>
        [XmlElement("checkout_url")]
        public string CheckoutUrl { get; set; }

        /// <summary>
        /// 本次支付的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 本次订单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
