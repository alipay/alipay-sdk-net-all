using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 漏洞信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("vul_list")]
        public List<VulList> Data { get; set; }
    }
}
