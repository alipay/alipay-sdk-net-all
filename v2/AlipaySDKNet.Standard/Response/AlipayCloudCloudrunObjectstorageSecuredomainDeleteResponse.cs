using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageSecuredomainDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageSecuredomainDeleteResponse : AopResponse
    {
        /// <summary>
        /// 安全域名
        /// </summary>
        [XmlElement("secure_domain")]
        public string SecureDomain { get; set; }
    }
}
