using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePromoterRelationDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePromoterRelationDeleteModel : AopObject
    {
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
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
