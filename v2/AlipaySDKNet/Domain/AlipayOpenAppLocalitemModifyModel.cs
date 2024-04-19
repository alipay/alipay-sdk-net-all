using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemModifyModel : AopObject
    {
        /// <summary>
        /// 商品属性，通过alipay.open.app.localitem.template.query获取本地商品模板信息接口得到商品属性key
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商品类目ID，可通过alipay.open.app.localitem.allcategory.query接口获取
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 客服电话，包含区号+电话号码的座机号码格式，以及手机号码格式
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public PhoneStructVO CustomerServiceMobile { get; set; }

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
        /// 商品模版类型：1. 团购 2. 代金券 3. 次卡 4. 日历房
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlElement("skus")]
        public LocalItemSkuModifyVO Skus { get; set; }

        /// <summary>
        /// start_time描述售卖开始时间，end_time描述售卖结束时间，时间格式均为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("sold_time")]
        public TimeRangeStructVO SoldTime { get; set; }

        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品名称只允许汉字、数字、英文字母、特殊字符集；2.商品名称不得仅为数字、字母、特殊字符集或上述三种的组合。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
