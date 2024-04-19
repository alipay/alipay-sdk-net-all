using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialPriceDTO : AopObject
    {
        /// <summary>
        /// 最少份数，如果有阶梯规则，多个值用英文逗号分割，例如：3,5
        /// </summary>
        [XmlElement("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销活动skuid
        /// </summary>
        [XmlArray("promotion_sku_id")]
        [XmlArrayItem("string")]
        public List<string> PromotionSkuId { get; set; }

        /// <summary>
        /// 活动价，必须是数字格式，且最多两位小数点。 如果有阶梯规则，多个值用英文逗号分割，例如：10,5
        /// </summary>
        [XmlElement("special_price")]
        public string SpecialPrice { get; set; }

        /// <summary>
        /// 是否仅特价商品（Y/N）
        /// </summary>
        [XmlElement("special_price_only")]
        public string SpecialPriceOnly { get; set; }

        /// <summary>
        /// 特价skuId
        /// </summary>
        [XmlArray("special_price_sku_id")]
        [XmlArrayItem("string")]
        public List<string> SpecialPriceSkuId { get; set; }
    }
}
