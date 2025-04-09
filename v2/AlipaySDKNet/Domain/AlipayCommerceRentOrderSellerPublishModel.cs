using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderSellerPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderSellerPublishModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝OPENID
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 资方pid，2088开头
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 交易组件订单Id，取值：租赁下单接口返回的orderId
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 分账计划详情，可为空
        /// </summary>
        [XmlElement("royalty_publish_detail")]
        public RoyaltyPublishDetailInfo RoyaltyPublishDetail { get; set; }
    }
}
