using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApeSkuInfo : AopObject
    {
        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// sku的唯一标识
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku规格
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 状态，1为有效、0为无效，对应sku的上架和下架
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
