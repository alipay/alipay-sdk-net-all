using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderAgentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderAgentCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝会员UID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家开放网关openId
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// order_create_type为order_str的话，该值为使用base64 encode之后的支付宝支付支付订单串
        /// </summary>
        [XmlElement("order_create_content")]
        public string OrderCreateContent { get; set; }

        /// <summary>
        /// 代理下单时，商户原始的创单类型
        /// </summary>
        [XmlElement("order_create_type")]
        public string OrderCreateType { get; set; }
    }
}
