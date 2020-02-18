using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechDataServiceBlockchainContractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechDataServiceBlockchainContractQueryModel : AopObject
    {
        /// <summary>
        /// 金融科技租户名
        /// </summary>
        [XmlElement("at_tenant_name")]
        public string AtTenantName { get; set; }

        /// <summary>
        /// 区块链ID
        /// </summary>
        [XmlElement("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 区块链块唯一hash
        /// </summary>
        [XmlElement("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 合约唯一hash
        /// </summary>
        [XmlElement("contract_hash")]
        public string ContractHash { get; set; }

        /// <summary>
        /// 合约结束时间戳
        /// </summary>
        [XmlElement("end_timestamp")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 分页页号
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合约起始时间戳
        /// </summary>
        [XmlElement("start_timestamp")]
        public long StartTimestamp { get; set; }
    }
}
