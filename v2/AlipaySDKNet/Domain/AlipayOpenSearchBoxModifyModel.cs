using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxModifyModel : AopObject
    {
        /// <summary>
        /// 小程序直达配置的常用服务中带有门店信息时，可添加简称触发词
        /// </summary>
        [XmlArray("area_keywords")]
        [XmlArrayItem("string")]
        public List<string> AreaKeywords { get; set; }

        /// <summary>
        /// 品牌介绍，5-15个中文字符。当修改品牌介绍模块(module_type=BOX_EXCLUSIVE_BASE)时传入。 小程序直达时不支持设置
        /// </summary>
        [XmlElement("box_desc")]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 品牌id，参考<a href="https://opendocs.alipay.com/rules/029uy4"> 品牌认证说明 </a>
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 可通过配置来开启商圈权益模块，关闭后搜索直达不展示商圈权益模块
        /// </summary>
        [XmlElement("business_benefit_switch")]
        public bool BusinessBenefitSwitch { get; set; }

        /// <summary>
        /// 小程序已关联商圈时，可添加商圈id（目前仅对品牌直达开放，小程序直达暂未开放）
        /// </summary>
        [XmlArray("business_district_ids")]
        [XmlArrayItem("string")]
        public List<string> BusinessDistrictIds { get; set; }

        /// <summary>
        /// 自定义关键词，最多可配置6个，限1-8个中文字符。当修改触发词模块时(module_type=BOX_EXCLUSIVE_KEYWORD)传入。 小程序直达不支持设置
        /// </summary>
        [XmlElement("custom_keywords")]
        public string CustomKeywords { get; set; }

        /// <summary>
        /// 氛围图片id，调用 <a href="https://opendocs.alipay.com/mini/03hvl1?ref=api">支付宝文件上传接口</a> 上传图片获取图片id(bizCode：search_box_atmosphere)。 <a href="https://opendocs.alipay.com/b/03al6f">图片规范</a>  小程序直达不支持设置此项。
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 氛围图片名，当修改氛围图模块(module_type=BOX_ATMOSPHERE_IMAGE)时传入。 小程序直达不支持设置
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 搜索直达模块配置id，新增模块时可不传，更新模块时必传。从alipay.open.search.box.query详情接口查询可获取已存在模块的配置id
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型，参考<a href="https://opendocs.alipay.com/mini/03fjba#%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E"> 搜索直达模块说明 </a>。取值范围：BOX_EXCLUSIVE_BASE-品牌介绍/BOX_EXCLUSIVE_KEYWORD-触发词/BOX_EXCLUSIVE_FUNCTIONS-常用服务/BOX_EXCLUSIVE_ACCOUNTS-官方账号/BOX_ATMOSPHERE_IMAGE-氛围图
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// 关联账号信息，可配置1-2个。传入账号需归属于商家主体。品牌直达修改官方账号(module_type=BOX_EXCLUSIVE_ACCOUNTS)时传入，小程序直达修改常用服务模块时也需传值。 当为品牌直达时，数组中的第1个账号会被设置为"账号1"，也就是将作为搜索直达专区头部的跳转地址。
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("search_box_app_info")]
        public List<SearchBoxAppInfo> RelatedAccounts { get; set; }

        /// <summary>
        /// 服务信息，服务必须审核通过才能申请搜索直达，可配置1-4个。当修改常用服务模块(module_type=BOX_EXCLUSIVE_FUNCTIONS)时传入
        /// </summary>
        [XmlArray("service_infos")]
        [XmlArrayItem("search_box_service_info")]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }

        /// <summary>
        /// 小程序id，小程序直达时必传，需要和申请的商户主体保持一致，且符合<a href="https://opendocs.alipay.com/b/03al6e"> 准入类目 </a>
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
