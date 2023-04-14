using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerSafedomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerSafedomainCreateModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 开发者id
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 域名，示例：example.com。仅支持https协议。
        /// </summary>
        [XmlElement("mini_app_safe_domain")]
        public string MiniAppSafeDomain { get; set; }
    }
}
