using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCorpusBatchSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryCorpusBatchSyncResponse : AopResponse
    {
        /// <summary>
        /// 拦截的语料列表
        /// </summary>
        [XmlArray("intercepted_corpus_list")]
        [XmlArrayItem("intercepted_corpus_result")]
        public List<InterceptedCorpusResult> InterceptedCorpusList { get; set; }

        /// <summary>
        /// 同步知识的批次id，用于反向查询同步知识的处理情况
        /// </summary>
        [XmlElement("sync_batch_id")]
        public string SyncBatchId { get; set; }

        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
