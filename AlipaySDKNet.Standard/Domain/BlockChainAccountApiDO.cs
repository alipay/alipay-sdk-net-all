using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BlockChainAccountApiDO Data Structure.
    /// </summary>
    [Serializable]
    public class BlockChainAccountApiDO : AopObject
    {
        /// <summary>
        /// 账户hash
        /// </summary>
        [XmlElement("account_hash")]
        public string AccountHash { get; set; }

        /// <summary>
        /// 账户序号
        /// </summary>
        [XmlElement("account_index")]
        public long AccountIndex { get; set; }

        /// <summary>
        /// 账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement("account_status")]
        public long AccountStatus { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 区块链唯一ID
        /// </summary>
        [XmlElement("block_chain_id")]
        public string BlockChainId { get; set; }

        /// <summary>
        /// 账号所在块hash
        /// </summary>
        [XmlElement("block_hash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// 智能科技统一客户ID
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 父账号hash
        /// </summary>
        [XmlElement("parent_hash")]
        public string ParentHash { get; set; }

        /// <summary>
        /// 创建账号的交易hash
        /// </summary>
        [XmlElement("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
