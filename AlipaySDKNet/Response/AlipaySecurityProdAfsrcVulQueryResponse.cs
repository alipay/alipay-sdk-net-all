using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AopResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [XmlElement("data")]
        public VulInfo Data { get; set; }
    }
}
