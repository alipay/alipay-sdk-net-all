using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderModifyModel : AopObject
    {
        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentOrderReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 默认退货寄回地址
        /// </summary>
        [XmlElement("default_receiving_address")]
        public RentOrderReceiverAddressInfoDTO DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 订单履约信息
        /// </summary>
        [XmlElement("delivery_info")]
        public RentOrderDeliveryInfoDTO DeliveryInfo { get; set; }

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
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租赁分期计划
        /// </summary>
        [XmlElement("rent_plan_info")]
        public OrderModifyRentPlanInfo RentPlanInfo { get; set; }

        /// <summary>
        /// 订单信息的修改类型
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
