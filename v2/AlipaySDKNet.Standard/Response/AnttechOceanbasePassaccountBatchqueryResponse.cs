using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassaccountBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbasePassaccountBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 通行证列表
        /// </summary>
        [XmlArray("pass_accounts")]
        [XmlArrayItem("pass_account_d_t_o")]
        public List<PassAccountDTO> PassAccounts { get; set; }
    }
}
