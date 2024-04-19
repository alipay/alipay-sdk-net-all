using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuDto Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuDto : AopObject
    {
        /// <summary>
        /// sku条形码信息
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// sku原价，单位为分
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
        /// sku售价，单位为分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品售卖状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 销售属性列表
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("item_attr_dto")]
        public List<ItemAttrDto> SkuAttrs { get; set; }

        /// <summary>
        /// sku库存，目前支持库存区间为0-99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品sku小图
        /// </summary>
        [XmlElement("thumb_img")]
        public string ThumbImg { get; set; }
    }
}
