using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProductVO : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 采购方id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
