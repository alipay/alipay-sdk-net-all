using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemModifyModel : AopObject
    {
        /// <summary>
        /// 商品属性
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品业务模式，租赁业务模式包含（短租：0；长租：1）
        /// </summary>
        [XmlElement("business_model")]
        public string BusinessModel { get; set; }

        /// <summary>
        /// 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过<a href="https://opendocs.alipay.com/b/0a8xi8">商品类目表</a>获取。仅叶子类目支持创建商品。
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 导购描述，用于介绍商品卖点
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品详情信息
        /// </summary>
        [XmlElement("desc_info")]
        public ItemDescInfoVO DescInfo { get; set; }

        /// <summary>
        /// 商品立即购买链接地址
        /// </summary>
        [XmlElement("direct_path")]
        public string DirectPath { get; set; }

        /// <summary>
        /// 导购信息
        /// </summary>
        [XmlArray("guide_info")]
        [XmlArrayItem("guide_info_v_o")]
        public List<GuideInfoVO> GuideInfo { get; set; }

        /// <summary>
        /// 商品主图，图片宽高为750px*750px，宽高比1:1，800kb以内。支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 商品子图，作为平台详情页组件的轮播图，图片宽高为750px*750px，宽高比1:1，800kb以内，不超过 3 个图片。支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 1=官方插件版，商品详情页链接不传入 0=自定义详情页版，商品详情页链接必须传入 当前字段已废弃(该字段下线展示，无需传入，默认填写自定义详情页版商品详情页链接)
        /// </summary>
        [XmlElement("item_details_page_model")]
        public string ItemDetailsPageModel { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型，默认为实物商品
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品原价，分为单位。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页地址
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品售价，分为单位。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品的售卖状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 修改商品跳过算法检测
        /// </summary>
        [XmlElement("skip_algorithm_check")]
        public string SkipAlgorithmCheck { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_v_o")]
        public List<ItemSkuVO> Skus { get; set; }

        /// <summary>
        /// 若填写了skus[]数组，此字段不用填写。 若未填写skus[]数组，此字段选填。目前支持库存区间为0-99999999。
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品名称，字符类型，最少不低于3，最长不超过100个字。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
