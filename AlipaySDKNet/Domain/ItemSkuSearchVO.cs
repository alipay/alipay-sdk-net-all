using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuSearchVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuSearchVO : AopObject
    {
        /// <summary>
        /// sku条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

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
        /// sku销售属性
        /// </summary>
        [XmlElement("sku_attrs")]
        public ItemSkuAttrVO SkuAttrs { get; set; }

        /// <summary>
        /// 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku库存，目前支持库存区间为0-99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 图片url，宽高为400px*400px，宽高比1:1。
        /// </summary>
        [XmlElement("thumb_img")]
        public string ThumbImg { get; set; }
    }
}
