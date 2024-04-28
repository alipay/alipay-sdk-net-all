using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalItemSkuQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocalItemSkuQueryVO : AopObject
    {
        /// <summary>
        /// 用于需要透出sku属性的场景。如线路游需要透出sku销售属性
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("item_sku_attr_v_o")]
        public List<ItemSkuAttrVO> Attrs { get; set; }

        /// <summary>
        /// sku原价，分为单位
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧sku ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE)
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
