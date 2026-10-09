using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpscerthostingQueryResponse : AopResponse
    {
        /// <summary>
        /// Https证书列表
        /// </summary>
        [XmlArray("domains")]
        [XmlArrayItem("https_domain_cert")]
        public List<HttpsDomainCert> Domains { get; set; }
    }
}
