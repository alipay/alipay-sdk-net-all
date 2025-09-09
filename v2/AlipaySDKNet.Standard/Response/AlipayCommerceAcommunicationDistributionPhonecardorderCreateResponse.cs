using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardorderCreateResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionPhonecardorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 合作方创单传入的订单ID
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
