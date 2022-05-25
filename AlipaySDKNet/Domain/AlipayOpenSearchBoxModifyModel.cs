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
        /// 品牌介绍，5-15个中文字符。当module_type=BOX_EXCLUSIVE_BASE时传入，当brand_id为空时不支持修改
        /// </summary>
        [XmlElement("box_desc")]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 自定义关键词，最多可配置6个，限1-8个中文字符。当module_type=BOX_EXCLUSIVE_KEYWORD传入，当brand_id为空时不支持修改
        /// </summary>
        [XmlElement("custom_keywords")]
        public string CustomKeywords { get; set; }

        /// <summary>
        /// 氛围图片id，调用<a href="https://opendocs.alipay.com/pre-open/032j4c"> 支付宝文件上传接口 </a>上传图片获取图片id。当module_type=BOX_ATMOSPHERE_IMAGE时传入，当brand_id为空时不支持修改。<a href="https://opendocs.alipay.com/mini/operation/atmospheredesign"> 图片规范 </a>
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 氛围图片名，当module_type=BOX_ATMOSPHERE_IMAGE时传入，当brand_id为空时不支持修改
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
        /// 搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// 关联账号信息，可配置1-2个。当module_type=BOX_EXCLUSIVE_ACCOUNTS时传入。当brand_id为空时不支持修改
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("search_box_app_info")]
        public List<SearchBoxAppInfo> RelatedAccounts { get; set; }

        /// <summary>
        /// 服务信息，可配置1-4个。当module_type=BOX_EXCLUSIVE_FUNCTIONS时传入
        /// </summary>
        [XmlArray("service_infos")]
        [XmlArrayItem("search_box_service_info")]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }

        /// <summary>
        /// 小程序id，brand_id为空时必传
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
