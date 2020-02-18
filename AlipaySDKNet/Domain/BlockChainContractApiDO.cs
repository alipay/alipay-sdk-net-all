using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BlockChainContractApiDO Data Structure.
    /// </summary>
    [Serializable]
    public class BlockChainContractApiDO : AopObject
    {
        /// <summary>
        /// 合约定义
        /// </summary>
        [XmlElement("abi")]
        public string Abi { get; set; }

        /// <summary>
        /// 区块链ID
        /// </summary>
        [XmlElement("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 区块链块hash
        /// </summary>
        [XmlElement("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 代码hash
        /// </summary>
        [XmlElement("code_hash")]
        public string CodeHash { get; set; }

        /// <summary>
        /// 合约hash
        /// </summary>
        [XmlElement("contract_hash")]
        public string ContractHash { get; set; }

        /// <summary>
        /// 合约时间戳
        /// </summary>
        [XmlElement("contract_timestamp")]
        public long ContractTimestamp { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("contract_version")]
        public long ContractVersion { get; set; }

        /// <summary>
        /// 二进制字节码
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 交易hash
        /// </summary>
        [XmlElement("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
