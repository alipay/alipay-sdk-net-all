using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalItemSkuModifyVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocalItemSkuModifyVO : AopObject
    {
        /// <summary>
        /// sku原价，分为单位。
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
        /// sku售卖状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku销售属性列表
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("item_sku_attr_v_o")]
        public List<ItemSkuAttrVO> SkuAttrs { get; set; }

        /// <summary>
        /// 支付宝平台侧商品sku的唯一标识
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public string StockNum { get; set; }
    }
}
