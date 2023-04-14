using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainAccountQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户列表
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("block_chain_account_api_d_o")]
        public List<BlockChainAccountApiDO> AccountList { get; set; }
    }
}
