using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniInstantiateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniInstantiateInfo : AopObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 版本号，一般为x.y.x格式，其中x、y、z都是数字
        /// </summary>
        [XmlElement("latest_version")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [XmlElement("latest_version_status")]
        public string LatestVersionStatus { get; set; }

        /// <summary>
        /// 小程序logo图标
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 二维码图片链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 小程序应用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 小程序模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 实例化小程序模板版本号
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }
    }
}
