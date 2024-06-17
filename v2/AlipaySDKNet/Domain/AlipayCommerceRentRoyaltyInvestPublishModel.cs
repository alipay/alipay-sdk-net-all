using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRoyaltyInvestPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRoyaltyInvestPublishModel : AopObject
    {
        /// <summary>
        /// 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息; 其中buyer_id与buyer_open_id不能同时为空
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 资方appId
        /// </summary>
        [XmlElement("invest_app_id")]
        public string InvestAppId { get; set; }

        /// <summary>
        /// 资方pid，2088开头
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 分账计划信息
        /// </summary>
        [XmlArray("royalty_publish_detail")]
        [XmlArrayItem("rent_royalty_publish_detail_request")]
        public List<RentRoyaltyPublishDetailRequest> RoyaltyPublishDetail { get; set; }
    }
}
