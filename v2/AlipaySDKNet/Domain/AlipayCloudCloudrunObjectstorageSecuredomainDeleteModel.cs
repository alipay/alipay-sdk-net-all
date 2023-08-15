using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageSecuredomainDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageSecuredomainDeleteModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

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
