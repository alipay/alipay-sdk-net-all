using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonItemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonItemUploadModel : AopObject
    {
        /// <summary>
        /// 行业商品信息，对应不同的扩展属性模型
        /// </summary>
        [XmlArray("biz_item_info")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> BizItemInfo { get; set; }

        /// <summary>
        /// 行业商品类型，对应不同的扩展属性模型
        /// </summary>
        [XmlElement("biz_item_type")]
        public string BizItemType { get; set; }

        /// <summary>
        /// 标识商品提报的场景类型 电商 ：ECOMMERCE_CAMP
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝商品类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品的投放信息
        /// </summary>
        [XmlElement("delivery_infos")]
        public ItemDeliveryInfoSyncRequest DeliveryInfos { get; set; }

        /// <summary>
        /// 扩展属性，具体字段sop给出
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> ExtInfo { get; set; }

        /// <summary>
        /// 商品的描述
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 商品的售卖亮点
        /// </summary>
        [XmlArray("item_highlight_list")]
        [XmlArrayItem("string")]
        public List<string> ItemHighlightList { get; set; }

        /// <summary>
        /// 商家侧商品id，同appId下唯一
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品的副图的集合，调用alipay.open.file.upload得到的fileId
        /// </summary>
        [XmlArray("item_image_list")]
        [XmlArrayItem("string")]
        public List<string> ItemImageList { get; set; }

        /// <summary>
        /// 商品的主图通过alipay.open.file.upload上传得到的fileId
        /// </summary>
        [XmlElement("item_main_image")]
        public string ItemMainImage { get; set; }

        /// <summary>
        /// 管理商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品自定义属性，list<kv>类型
        /// </summary>
        [XmlArray("item_spec_list")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> ItemSpecList { get; set; }

        /// <summary>
        /// 商品标题，商品c端透出名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 点击商品跳转的详情页url
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品的原价（划线价），单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品价格，单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品价格类型（元/件、元/次、元/日、元/季），透出在c端
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品营销信息
        /// </summary>
        [XmlElement("promo_infos")]
        public ItemPromoInfoSyncRequest PromoInfos { get; set; }

        /// <summary>
        /// 商品上下架状态，DELISTING：下架，AVAILABLE：上架
        /// </summary>
        [XmlElement("sell_status")]
        public string SellStatus { get; set; }

        /// <summary>
        /// 商品sku集合
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("industry_item_sku_sync_request")]
        public List<IndustryItemSkuSyncRequest> SkuList { get; set; }

        /// <summary>
        /// 商品的库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
