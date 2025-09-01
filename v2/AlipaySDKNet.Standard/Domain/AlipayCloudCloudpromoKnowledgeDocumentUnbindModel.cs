using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoKnowledgeDocumentUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoKnowledgeDocumentUnbindModel : AopObject
    {
        /// <summary>
        /// 接口api
        /// </summary>
        [XmlElement("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 应用数据ID
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("knowledge_base_id")]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 空间id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
