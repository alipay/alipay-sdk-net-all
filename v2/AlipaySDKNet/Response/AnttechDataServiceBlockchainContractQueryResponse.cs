using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainContractQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainContractQueryResponse : AopResponse
    {
        /// <summary>
        /// 合约列表
        /// </summary>
        [XmlArray("contract_list")]
        [XmlArrayItem("block_chain_contract_api_d_o")]
        public List<BlockChainContractApiDO> ContractList { get; set; }
    }
}
