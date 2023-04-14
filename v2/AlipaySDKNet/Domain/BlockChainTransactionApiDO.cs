using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BlockChainTransactionApiDO Data Structure.
    /// </summary>
    [Serializable]
    public class BlockChainTransactionApiDO : AopObject
    {
        /// <summary>
        /// 区块链ID
        /// </summary>
        [XmlElement("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 块hash
        /// </summary>
        [XmlElement("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 块高
        /// </summary>
        [XmlElement("block_height")]
        public long BlockHeight { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 起始账户
        /// </summary>
        [XmlElement("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// gas消耗
        /// </summary>
        [XmlElement("gas_used")]
        public long GasUsed { get; set; }

        /// <summary>
        /// 目标账户
        /// </summary>
        [XmlElement("to_account")]
        public string ToAccount { get; set; }

        /// <summary>
        /// 交易hash
        /// </summary>
        [XmlElement("transaction_hash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// 交易时间戳
        /// </summary>
        [XmlElement("transaction_timestamp")]
        public long TransactionTimestamp { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("transaction_type")]
        public long TransactionType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
