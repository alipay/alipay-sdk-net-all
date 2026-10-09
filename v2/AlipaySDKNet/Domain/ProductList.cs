using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductList Data Structure.
    /// </summary>
    [Serializable]
    public class ProductList : AopObject
    {
        /// <summary>
        /// 商品折扣价，单位为元。
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 商品标价，单位为元。
        /// </summary>
        [XmlElement("listed_price")]
        public string ListedPrice { get; set; }

        /// <summary>
        /// 商品价格单位。
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品 SKU 编码。
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
