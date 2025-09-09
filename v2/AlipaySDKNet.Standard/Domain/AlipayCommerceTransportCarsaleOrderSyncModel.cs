using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarsaleOrderSyncModel : AopObject
    {
        /// <summary>
        /// 原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 交车方式
        /// </summary>
        [XmlElement("delivery_method")]
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// 通知状态
        /// </summary>
        [XmlElement("notice_status")]
        public string NoticeStatus { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 车生活订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// out_order_id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 车商id
        /// </summary>
        [XmlElement("seller_partner_id")]
        public string SellerPartnerId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("seller_price")]
        public string SellerPrice { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
