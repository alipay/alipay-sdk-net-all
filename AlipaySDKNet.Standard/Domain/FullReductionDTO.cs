using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FullReductionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FullReductionDTO : AopObject
    {
        /// <summary>
        /// 是否仅满减商品（Y/N）
        /// </summary>
        [XmlElement("full_reduction_only")]
        public string FullReductionOnly { get; set; }

        /// <summary>
        /// 满减skuId
        /// </summary>
        [XmlArray("full_reduction_sku_id")]
        [XmlArrayItem("string")]
        public List<string> FullReductionSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [XmlElement("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [XmlElement("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销商品skuId
        /// </summary>
        [XmlArray("promotion_sku_id")]
        [XmlArrayItem("string")]
        public List<string> PromotionSkuId { get; set; }

        /// <summary>
        /// 满减金额，两位小数，如果有阶梯规则，用英文逗号分割
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }
    }
}
