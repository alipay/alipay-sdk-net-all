using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemConsultInfo : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品优惠金额，单位为元
        /// </summary>
        [XmlElement("promo_amount")]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 商品优惠数量
        /// </summary>
        [XmlElement("promo_count")]
        public string PromoCount { get; set; }
    }
}
