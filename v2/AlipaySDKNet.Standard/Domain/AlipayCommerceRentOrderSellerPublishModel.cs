using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        /// 资方appid，可选，如果需要向非资商关系中的appid发送通知消息，可传递本参数
        /// </summary>
        [XmlElement("invest_app_id")]
        public string InvestAppId { get; set; }

        /// <summary>
        /// 资方pid，2088开头
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 不传值时默认为create
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 交易组件订单Id，取值：租赁下单接口返回的orderId
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("royalty_publish_detail")]
        [XmlArrayItem("royalty_publish_detail_info")]
        public List<RoyaltyPublishDetailInfo> RoyaltyPublishDetail { get; set; }
    }
}
