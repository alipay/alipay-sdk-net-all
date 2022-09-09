using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePurchaseRecommendModel : AopObject
    {
        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("authorized_token")]
        public string AuthorizedToken { get; set; }

        /// <summary>
        /// 商品:订购主体为商品时必传
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 订购主体类型:PURCHASE_USER 订购人, ECOM_ITEM  商品
        /// </summary>
        [XmlElement("related_subject_type")]
        public string RelatedSubjectType { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 客户端渠道:ios,andriod,pc,wechat_applet
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
