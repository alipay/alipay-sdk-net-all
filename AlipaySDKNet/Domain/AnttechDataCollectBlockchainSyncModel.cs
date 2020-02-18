using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechDataCollectBlockchainSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechDataCollectBlockchainSyncModel : AopObject
    {
        /// <summary>
        /// 链上账号列表，JSON字符串
        /// </summary>
        [XmlElement("account_data")]
        public string AccountData { get; set; }

        /// <summary>
        /// 区块链唯一ID
        /// </summary>
        [XmlElement("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 链上合约列表，JSON字符串
        /// </summary>
        [XmlElement("contract_data")]
        public string ContractData { get; set; }

        /// <summary>
        /// 截止块高
        /// </summary>
        [XmlElement("end_height")]
        public long EndHeight { get; set; }

        /// <summary>
        /// 起始块高
        /// </summary>
        [XmlElement("start_height")]
        public long StartHeight { get; set; }

        /// <summary>
        /// 链上交易列表，JSON字符串
        /// </summary>
        [XmlElement("transaction_data")]
        public string TransactionData { get; set; }
    }
}
