using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageSecuredomainQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageSecuredomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 安全域名列表
        /// </summary>
        [XmlArray("secure_domain_list")]
        [XmlArrayItem("string")]
        public List<string> SecureDomainList { get; set; }
    }
}
