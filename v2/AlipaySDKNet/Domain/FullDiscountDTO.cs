using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FullDiscountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FullDiscountDTO : AopObject
    {
        /// <summary>
        /// 折扣，如果有阶梯规则，则用英文逗号分隔
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 是否仅满折商品（Y/N）
        /// </summary>
        [XmlElement("full_discount_only")]
        public string FullDiscountOnly { get; set; }

        /// <summary>
        /// 满折skuId
        /// </summary>
        [XmlArray("full_discount_sku_id")]
        [XmlArrayItem("string")]
        public List<string> FullDiscountSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，则用英文逗号分隔
        /// </summary>
        [XmlElement("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [XmlElement("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销skuId
        /// </summary>
        [XmlArray("promotion_sku_id")]
        [XmlArrayItem("string")]
        public List<string> PromotionSkuId { get; set; }
    }
}
