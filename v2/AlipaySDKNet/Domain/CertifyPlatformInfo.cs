using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertifyPlatformInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertifyPlatformInfo : AopObject
    {
        /// <summary>
        /// 认证平台链接
        /// </summary>
        [XmlElement("certify_platform_name")]
        public string CertifyPlatformName { get; set; }

        /// <summary>
        /// 认证平台链接
        /// </summary>
        [XmlElement("certify_platform_url")]
        public string CertifyPlatformUrl { get; set; }
    }
}
