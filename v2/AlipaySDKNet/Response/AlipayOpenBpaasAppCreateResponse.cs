using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBpaasAppCreateResponse.
    /// </summary>
    public class AlipayOpenBpaasAppCreateResponse : AopResponse
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用平台类型：ANDROID、RTOS、LINUX、WINDOWS
        /// </summary>
        [XmlElement("app_platform")]
        public string AppPlatform { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// bpaas应用ID
        /// </summary>
        [XmlElement("bpaas_app_id")]
        public string BpaasAppId { get; set; }
    }
}
