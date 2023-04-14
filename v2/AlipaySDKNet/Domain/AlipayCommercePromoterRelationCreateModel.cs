using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePromoterRelationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePromoterRelationCreateModel : AopObject
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

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
        /// 导购员角色 店长 MANAGER 普通导购员 GENERAL 临促员 TEMPORARY 默认值GENERAL
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 域外店铺id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
