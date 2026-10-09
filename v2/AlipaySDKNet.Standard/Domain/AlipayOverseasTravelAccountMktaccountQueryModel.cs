using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelAccountMktaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelAccountMktaccountQueryModel : AopObject
    {
        /// <summary>
        /// cn账号列表
        /// </summary>
        [XmlArray("cn_accounts")]
        [XmlArrayItem("cn_account_d_t_o")]
        public List<CnAccountDTO> CnAccounts { get; set; }
    }
}
