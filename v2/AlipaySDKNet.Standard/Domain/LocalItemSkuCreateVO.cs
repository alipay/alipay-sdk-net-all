using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalItemSkuCreateVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocalItemSkuCreateVO : AopObject
    {
        /// <summary>
        /// sku原价，分为单位。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧自定义的app下唯一的skuId
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
        /// sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 图片afts文件ID，可以通过 <a href="https://opendocs.alipay.com/mini/3fade898_alipay.marketing.image.enhance.upload?scene=a07c8e4fcf3e490f97d959445f393b01&pathHash=a941a783" target="_blank">alipay.marketing.image.enhance.upload</a> 获取图片文件id
        /// </summary>
        [XmlElement("thumb_img_id")]
        public string ThumbImgId { get; set; }
    }
}
