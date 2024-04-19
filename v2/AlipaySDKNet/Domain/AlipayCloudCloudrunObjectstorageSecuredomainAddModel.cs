using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageSecuredomainAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageSecuredomainAddModel : AopObject
    {
        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 安全域名
        /// </summary>
        [XmlElement("secure_domain")]
        public string SecureDomain { get; set; }
    }
}
