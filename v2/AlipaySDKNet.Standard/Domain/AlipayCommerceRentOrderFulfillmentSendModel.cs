using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderFulfillmentSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderFulfillmentSendModel : AopObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("delivery_list")]
        [XmlArrayItem("fulfillment_delivery_info")]
        public List<FulfillmentDeliveryInfo> DeliveryList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 记录商品发货的时间
        /// </summary>
        [XmlElement("ship_done_time")]
        public string ShipDoneTime { get; set; }

        /// <summary>
        /// 发货类型。当前支持两种场景，一是商家发货寄出商品，二是用户到期归还寄回商品
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
