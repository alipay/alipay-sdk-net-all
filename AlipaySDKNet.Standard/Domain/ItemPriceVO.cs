using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPriceVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPriceVO : AopObject
    {
        /// <summary>
        /// 商品是否有价格
        /// </summary>
        [XmlElement("has_price")]
        public bool HasPrice { get; set; }

        /// <summary>
        /// sku原价，分为单位。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// sku售价，分为单位
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
