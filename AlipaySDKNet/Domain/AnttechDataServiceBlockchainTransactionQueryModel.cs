using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechDataServiceBlockchainTransactionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechDataServiceBlockchainTransactionQueryModel : AopObject
    {
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
        /// 交易结束时间戳
        /// </summary>
        [XmlElement("end_timestamp")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 交易来源账户
        /// </summary>
        [XmlElement("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// 分页页号
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 交易开始时间戳
        /// </summary>
        [XmlElement("start_timestamp")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 交易目标账户
        /// </summary>
        [XmlElement("to_account")]
        public string ToAccount { get; set; }

        /// <summary>
        /// 交易唯一hash
        /// </summary>
        [XmlElement("transaction_hash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("transaction_type")]
        public long TransactionType { get; set; }
    }
}
