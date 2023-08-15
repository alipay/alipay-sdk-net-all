using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomainBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteDomainBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 域名列表
        /// </summary>
        [XmlArray("domain_list")]
        [XmlArrayItem("static_domain")]
        public List<StaticDomain> DomainList { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
