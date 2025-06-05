using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCorpusBatchSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryCorpusBatchSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步知识的批次id，用于反向查询同步知识的处理情况
        /// </summary>
        [XmlElement("sync_batch_id")]
        public string SyncBatchId { get; set; }
    }
}
