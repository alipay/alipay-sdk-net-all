using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingHistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpscerthostingHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// Https证书历史列表
        /// </summary>
        [XmlArray("historys")]
        [XmlArrayItem("https_domain_cert_history")]
        public List<HttpsDomainCertHistory> Historys { get; set; }
    }
}
