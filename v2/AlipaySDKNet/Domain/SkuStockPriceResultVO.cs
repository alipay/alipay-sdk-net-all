using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuStockPriceResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuStockPriceResultVO : AopObject
    {
        /// <summary>
        /// 商家的商品sku编码，该编码是商家侧内部自用的商品id，一般连锁商家模式下，该编码都是连锁维度全国唯一。购药内部系统，该编码与内部系统的商品skuID唯一对应。
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
