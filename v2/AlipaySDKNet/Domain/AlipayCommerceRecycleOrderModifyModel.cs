using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderModifyModel : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address_info")]
        public RecycleModifyAddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 竞拍履约信息
        /// </summary>
        [XmlElement("auction_delivery_info")]
        public RecycleAuctionDeliveryInfoVO AuctionDeliveryInfo { get; set; }

        /// <summary>
        /// 修改原因
        /// </summary>
        [XmlElement("modify_reason")]
        public string ModifyReason { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 回收工程师信息
        /// </summary>
        [XmlElement("send_order_contact_info")]
        public RecycleSendContactInfo SendOrderContactInfo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
