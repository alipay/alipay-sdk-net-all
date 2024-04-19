using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageSecuredomainAddResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageSecuredomainAddResponse : AopResponse
    {
        /// <summary>
        /// 安全域名
        /// </summary>
        [XmlElement("secure_domain")]
        public string SecureDomain { get; set; }
    }
}
