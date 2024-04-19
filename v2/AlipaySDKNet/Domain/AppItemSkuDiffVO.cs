using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemSkuDiffVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemSkuDiffVO : AopObject
    {
        /// <summary>
        /// sku条形码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// sku原价，分为单位
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧sku ID，APPID维度下全局唯一
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE)
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku信息新增（CREATE），sku信息修改（MODIFY），sku信息删除（DELETE）
        /// </summary>
        [XmlElement("sku_modify_type")]
        public string SkuModifyType { get; set; }

        /// <summary>
        /// sku库存，目前支持库存区间为0-99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 图片url，宽高为400px*400px，宽高比1:1
        /// </summary>
        [XmlElement("thumb_img")]
        public string ThumbImg { get; set; }
    }
}
