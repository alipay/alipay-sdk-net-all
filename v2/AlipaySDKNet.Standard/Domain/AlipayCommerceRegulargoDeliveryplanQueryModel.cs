using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRegulargoDeliveryplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRegulargoDeliveryplanQueryModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
