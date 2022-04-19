using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSkuInfo : AopObject
    {
        /// <summary>
        /// 商品金额, 单位为元,小数点后保留两位数
        /// </summary>
        [XmlElement("price_money")]
        public string PriceMoney { get; set; }

        /// <summary>
        /// 金额展示信息
        /// </summary>
        [XmlElement("price_text")]
        public string PriceText { get; set; }

        /// <summary>
        /// sku属性路径
        /// </summary>
        [XmlElement("prop_path")]
        public string PropPath { get; set; }

        /// <summary>
        /// 该sku库存信息
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku描述信息
        /// </summary>
        [XmlElement("sku_desc")]
        public string SkuDesc { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
