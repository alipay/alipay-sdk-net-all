using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderDeliverySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderDeliverySendModel : AopObject
    {
        /// <summary>
        /// 物流履约信息
        /// </summary>
        [XmlElement("delivery_info")]
        public ResaleDeliveryVO DeliveryInfo { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
