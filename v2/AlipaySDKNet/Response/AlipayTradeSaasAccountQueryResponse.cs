using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasAccountQueryResponse.
    /// </summary>
    public class AlipayTradeSaasAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("saas_account_info")]
        public List<SaasAccountInfo> AccountList { get; set; }

        /// <summary>
        /// 实际命中的SaaS客户ID。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }
    }
}
