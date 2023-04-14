using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationRecyclecampBenefitSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationRecyclecampBenefitSyncModel : AopObject
    {
        /// <summary>
        /// 商户侧权益id，同一商户下不可重复
        /// </summary>
        [XmlElement("outer_benefit_id")]
        public string OuterBenefitId { get; set; }

        /// <summary>
        /// 权益剩余库存，不允许为负数，sync_type为inventory时必传
        /// </summary>
        [XmlElement("remain_inventory")]
        public string RemainInventory { get; set; }

        /// <summary>
        /// 毫秒级时间戳，用于避免同步到旧数据，服务端会记录最后一次请求的时间戳，若后续请求小于记录值，则静默丢弃。建议调用方传业务发生时间，如库存值的更新时间。
        /// </summary>
        [XmlElement("sync_timestamp")]
        public string SyncTimestamp { get; set; }

        /// <summary>
        /// 同步类型，inventory：同步库存，offline：权益下架
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
