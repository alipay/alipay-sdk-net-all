using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingParamBean Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingParamBean : AopObject
    {
        /// <summary>
        /// 商品优惠sku
        /// </summary>
        [XmlElement("item_discount_sku_id")]
        public string ItemDiscountSkuId { get; set; }

        /// <summary>
        /// 限购数量 ，单位：个/份
        /// </summary>
        [XmlElement("limit_cnt")]
        public long LimitCnt { get; set; }

        /// <summary>
        /// 原始sku
        /// </summary>
        [XmlElement("origin_sku_id")]
        public string OriginSkuId { get; set; }
    }
}
