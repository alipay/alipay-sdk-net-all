using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuVO : AopObject
    {
        /// <summary>
        /// sku条形码信息
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

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
        /// 商品价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

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
        /// 销售属性列表
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("item_sku_attr_v_o")]
        public List<ItemSkuAttrVO> SkuAttrs { get; set; }

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
        /// sku小图。图片宽高为400px*400px，宽高比1:1。文件id通过alipay.open.file.upload上传资源获取。
        /// </summary>
        [XmlElement("thumb_img")]
        public string ThumbImg { get; set; }
    }
}
