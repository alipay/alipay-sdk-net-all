using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppitemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceOpeneventAppitemCreateModel : AopObject
    {
        /// <summary>
        /// 行业编码，表示商品提报时，需要提报的行业。一般有支付宝侧分配
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 该商品在商户侧的唯一标识id，比如数据库主键id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品服务关联的套餐信息,json字符串，各行业需要传入的参数请参考公共文档
        /// </summary>
        [XmlElement("product_package_list_json")]
        public string ProductPackageListJson { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 服务包含功能的描述，不超过20个字
        /// </summary>
        [XmlElement("service_func")]
        public string ServiceFunc { get; set; }

        /// <summary>
        /// 服务引导文案，建议6个中文汉字，最长不超过8个汉字，必填
        /// </summary>
        [XmlElement("service_guide")]
        public string ServiceGuide { get; set; }

        /// <summary>
        /// 商品的名称，最长不超过60个字
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 商品主界面截图地址url，支持 jpg,png,jpeg格式，大小不超过2M，用户验收审核使用，必填
        /// </summary>
        [XmlElement("service_snapshot")]
        public string ServiceSnapshot { get; set; }

        /// <summary>
        /// 服务按行业的模板化配置,json字符串，各行业需要传入的参数请参考公共文档
        /// </summary>
        [XmlElement("service_template_config")]
        public string ServiceTemplateConfig { get; set; }

        /// <summary>
        /// 商品所属开发类型，从 H5、生活号、小程序、插件 中4选1
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 商品的访问地址，通过该地址用户可以跳转到商品的页面，必须是https或者alipays开头，最长1024字符
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 服务验收视频url，多个视频以逗号分隔；单个最大不超过50M，最大支持5个;用于审核使用
        /// </summary>
        [XmlElement("service_videos")]
        public string ServiceVideos { get; set; }

        /// <summary>
        /// 门店列表,json字符串，各行业需要传入的参数请参考公共文档
        /// </summary>
        [XmlElement("shop_list_json")]
        public string ShopListJson { get; set; }
    }
}
