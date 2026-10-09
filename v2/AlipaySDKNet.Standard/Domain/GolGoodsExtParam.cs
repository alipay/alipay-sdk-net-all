using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GolGoodsExtParam Data Structure.
    /// </summary>
    [Serializable]
    public class GolGoodsExtParam : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商品描述文案
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品优惠文案
        /// </summary>
        [XmlElement("discount_content")]
        public string DiscountContent { get; set; }

        /// <summary>
        /// 是否包税。 Y - 包税 N - 不包税
        /// </summary>
        [XmlElement("is_tax_free")]
        public string IsTaxFree { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [XmlArray("specifications")]
        [XmlArrayItem("string")]
        public List<string> Specifications { get; set; }

        /// <summary>
        /// 库存状态。 库存充裕：STOCK_SUFFICIENT 库存紧张：STOCK_INSUFFICIENT 库存为零：OUT_OF_STOCK
        /// </summary>
        [XmlElement("stock_status")]
        public string StockStatus { get; set; }

        /// <summary>
        /// 率百分比数字，按照百分比传字符串。不包税的商品必填。精度：小数点后2位。
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
