using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasAppCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasAppCreateModel : AopObject
    {
        /// <summary>
        /// 应用icon 链接下载地址
        /// </summary>
        [XmlElement("app_icon_url")]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// 应用介绍
        /// </summary>
        [XmlElement("app_introduction")]
        public string AppIntroduction { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 可选参数，ANDROID应用为必填项
        /// </summary>
        [XmlElement("app_package")]
        public string AppPackage { get; set; }

        /// <summary>
        /// 应用平台，native应用类型支持ANDROID、ROTS、LINUX、WINDOWS
        /// </summary>
        [XmlElement("app_platform")]
        public string AppPlatform { get; set; }

        /// <summary>
        /// 应用签名
        /// </summary>
        [XmlElement("app_sign")]
        public string AppSign { get; set; }

        /// <summary>
        /// 应用类型，IOT_BPAAS_MOBILE
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }
    }
}
