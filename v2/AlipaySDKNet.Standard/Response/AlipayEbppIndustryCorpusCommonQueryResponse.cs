using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCorpusCommonQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCorpusCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 知识发布任务结果
        /// </summary>
        [XmlElement("corpus_publish_task_result_list")]
        public CorpusPublishTaskResult CorpusPublishTaskResultList { get; set; }

        /// <summary>
        /// 知识同步结果
        /// </summary>
        [XmlElement("corpus_sync_result")]
        public CorpusSyncResult CorpusSyncResult { get; set; }
    }
}
