using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeEnterpriseDelegationPullResponse.
    /// </summary>
    public class AlipayTradeEnterpriseDelegationPullResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("enterprise_delegation_auth")]
        public List<EnterpriseDelegationAuth> DataList { get; set; }

        /// <summary>
        /// 授权列表总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
