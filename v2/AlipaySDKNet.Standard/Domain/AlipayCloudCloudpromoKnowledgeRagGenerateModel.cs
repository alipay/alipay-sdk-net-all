using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoKnowledgeRagGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoKnowledgeRagGenerateModel : AopObject
    {
        /// <summary>
        /// 接口API-Key
        /// </summary>
        [XmlElement("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("knowledge_base_search_option")]
        public List<KnowledgeBaseSearchOption> Options { get; set; }

        /// <summary>
        /// 查询短语
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 相似度阈值（以小数形式表示）
        /// </summary>
        [XmlElement("similarity_threshold")]
        public string SimilarityThreshold { get; set; }

        /// <summary>
        /// 空间租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 返回结果数量（取值范围1-50）
        /// </summary>
        [XmlElement("top_k")]
        public long TopK { get; set; }
    }
}
