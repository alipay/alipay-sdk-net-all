using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCorpusCommonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCorpusCommonQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 知识发布任务查询参数
        /// </summary>
        [XmlElement("corpus_publish_task_query_param")]
        public CorpusPublishTaskQueryParam CorpusPublishTaskQueryParam { get; set; }

        /// <summary>
        /// 知识同步任务id。从知识同步接口的出参中获取
        /// </summary>
        [XmlElement("corpus_sync_batch_id")]
        public string CorpusSyncBatchId { get; set; }
    }
}
