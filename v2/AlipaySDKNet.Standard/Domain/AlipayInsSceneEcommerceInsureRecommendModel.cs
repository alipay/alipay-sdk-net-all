using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsureRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceInsureRecommendModel : AopObject
    {
        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("authorized_token")]
        public string AuthorizedToken { get; set; }

        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 客户端渠道:ios / android / pc / wx_applet(微信小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
