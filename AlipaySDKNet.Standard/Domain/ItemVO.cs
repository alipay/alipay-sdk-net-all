using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemVO : AopObject
    {
        /// <summary>
        /// 条形码信息，应用于扫一扫场景
        /// </summary>
        [XmlElement("barcode_info")]
        public BarcodeInfoVO BarcodeInfo { get; set; }

        /// <summary>
        /// 能否被搜索，可被搜索（true）,不可被搜索（false），默认true可以被搜索
        /// </summary>
        [XmlElement("can_be_search")]
        public string CanBeSearch { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品特征json字符串
        /// </summary>
        [XmlElement("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 详情图url列表，不超过3个图片
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 商品原价，分为单位
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 平台类目
        /// </summary>
        [XmlElement("platform_category")]
        public ItemCategoryVO PlatformCategory { get; set; }

        /// <summary>
        /// 平台侧商品id
        /// </summary>
        [XmlElement("platform_item_id")]
        public string PlatformItemId { get; set; }

        /// <summary>
        /// 商品价格，分为单位
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [XmlElement("src_path")]
        public string SrcPath { get; set; }

        /// <summary>
        /// 商品售卖状态，售罄(SOLD_OUT),冻结(FREEZE) 可售(AVAILABLE)
        /// </summary>
        [XmlElement("stock_status")]
        public string StockStatus { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
