using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingDomainproviderQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpscerthostingDomainproviderQueryResponse : AopResponse
    {
        /// <summary>
        /// DNS服务提供商列表
        /// </summary>
        [XmlArray("providers")]
        [XmlArrayItem("cert_domain_provider")]
        public List<CertDomainProvider> Providers { get; set; }
    }
}
