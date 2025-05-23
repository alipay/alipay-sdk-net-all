using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemCreateModel : AopObject
    {
        /// <summary>
        /// 商品属性，通过alipay.open.app.localitem.template.query获取本地商品模板信息接口得到商品属性key，is_required=1时属性必填
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商品提报，如果需要自动推广则传此参数true，如没有这需求传false
        /// </summary>
        [XmlElement("auto_marketing_delivery")]
        public bool AutoMarketingDelivery { get; set; }

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
        /// 商品类型
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
        /// 商品的售卖状态，默认：可售卖(AVAILABLE)。
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("local_item_sku_create_v_o")]
        public List<LocalItemSkuCreateVO> Skus { get; set; }

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
        /// 商品名称。 商品名称，字符类型，最少不低于3，最长不超过100个字。注：1.商品名称只允许汉字、数字、英文字母、特殊字符集；2.商品名称不得仅为数字、字母、特殊字符集或上述三种的组合。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
