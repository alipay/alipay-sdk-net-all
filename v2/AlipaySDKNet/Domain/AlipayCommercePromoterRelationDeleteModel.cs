using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePromoterRelationDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePromoterRelationDeleteModel : AopObject
    {
        /// <summary>
        /// 角色类型，如店长、督导员、导购员
        /// </summary>
        [XmlElement("delete_role")]
        public string DeleteRole { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("promoter_id")]
        public string PromoterId { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("promoter_open_id")]
        public string PromoterOpenId { get; set; }

        /// <summary>
        /// 关联店铺id
        /// </summary>
        [XmlArray("related_shop_list")]
        [XmlArrayItem("string")]
        public List<string> RelatedShopList { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
