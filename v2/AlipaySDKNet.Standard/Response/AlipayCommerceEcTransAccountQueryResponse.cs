using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金专户列表
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("fund_account_api_d_t_o")]
        public List<FundAccountApiDTO> AccountList { get; set; }
    }
}
