using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountAccountlistQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountAccountlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户基础信息
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("account_basel_d_t_o")]
        public List<AccountBaselDTO> AccountList { get; set; }
    }
}
