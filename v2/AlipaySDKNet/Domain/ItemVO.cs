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
        /// 是否有价格：true-有价格，false-无价格
        /// </summary>
        [XmlElement("has_price")]
        public bool HasPrice { get; set; }

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
        /// 商品原价，分为单位。has_price为true时才可能有值
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
        /// 商品价格，分为单位。has_price为true时才有值
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 价格单元，在has_price为true时可设置。和商品价格、商品原价（数值的单位保持为分）配合使用，扩展单位描述。枚举值：元、元/小时、元/日、元/周、元/月、元/季、元/年、元/次、元/场、元起、m2。
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

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
