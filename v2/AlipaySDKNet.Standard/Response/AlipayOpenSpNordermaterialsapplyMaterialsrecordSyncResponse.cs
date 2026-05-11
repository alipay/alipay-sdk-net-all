using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsrecordSyncResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyMaterialsrecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 铺设记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 剩余可重试次数
        /// </summary>
        [XmlElement("remain_retry_count")]
        public long RemainRetryCount { get; set; }

        /// <summary>
        /// 铺设状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
