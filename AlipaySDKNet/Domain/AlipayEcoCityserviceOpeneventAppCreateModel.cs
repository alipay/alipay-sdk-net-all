using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceOpeneventAppCreateModel : AopObject
    {
        /// <summary>
        /// 服务入驻所选择的行业编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 服务介绍，不超过100个字，必填
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 服务包含功能的描述，不超过20个字，必填
        /// </summary>
        [XmlElement("service_func")]
        public string ServiceFunc { get; set; }

        /// <summary>
        /// 服务引导文案，建议6个中文汉字，最长不超过8个汉字
        /// </summary>
        [XmlElement("service_guide")]
        public string ServiceGuide { get; set; }

        /// <summary>
        /// 服务的标签列表，用来标明服务的一些特征属性
        /// </summary>
        [XmlElement("service_labels")]
        public string ServiceLabels { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务登录后主界面截图地址url，支持 jpg,png,jpeg格式，大小不超过2M，必填
        /// </summary>
        [XmlElement("service_snapshot")]
        public string ServiceSnapshot { get; set; }

        /// <summary>
        /// 按行业不同的模板
        /// </summary>
        [XmlElement("service_template_config")]
        public string ServiceTemplateConfig { get; set; }

        /// <summary>
        /// 服务类型，从 H5、生活号、小程序、插件 中4选1，必填
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务的访问地址，必须是https或者alipays开头，最长1024字符，必填
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 服务验收视频url，多个视频以逗号分隔；单个最大不超过50M，最大支持5个
        /// </summary>
        [XmlElement("service_videos")]
        public string ServiceVideos { get; set; }
    }
}
