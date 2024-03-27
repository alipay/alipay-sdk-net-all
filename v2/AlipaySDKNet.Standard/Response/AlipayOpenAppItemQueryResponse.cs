using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品属性列表，kv形式
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商品条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

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
        /// 商品直接购买链接
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
        /// 商品是否在线版本，true在线，false最新版本
        /// </summary>
        [XmlElement("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// 1=官方插件版，商品详情页链接不传入 0=自定义详情页版，商品详情页链接必须传入
        /// </summary>
        [XmlElement("item_details_page_model")]
        public string ItemDetailsPageModel { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品原价，分为单位。若填写了skus[]数组，此字段不返回值
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页链接
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 商品价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品有冻结、驳回时，展示对应的具体问题
        /// </summary>
        [XmlArray("risk_info")]
        [XmlArrayItem("item_risk_info")]
        public List<ItemRiskInfo> RiskInfo { get; set; }

        /// <summary>
        /// 商品售价，分为单位。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品在对应场景屏蔽，展示对应的具体问题
        /// </summary>
        [XmlArray("scene_risk_info")]
        [XmlArrayItem("item_scene_risk_info")]
        public List<ItemSceneRiskInfo> SceneRiskInfo { get; set; }

        /// <summary>
        /// 商品sku信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_search_v_o")]
        public List<ItemSkuSearchVO> Skus { get; set; }

        /// <summary>
        /// 审核驳回：商品审核失败时，商品状态为审核驳回。 审核中：商品处于审核流程中时，商品状态为审核中。 已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。 可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。 冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。  当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，商品状态则为“可售卖”。
        /// </summary>
        [XmlElement("spu_status")]
        public string SpuStatus { get; set; }

        /// <summary>
        /// 目前支持库存区间0~99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。 美味甜甜圈
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品最新更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
