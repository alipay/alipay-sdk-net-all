using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAiKnowledgeDocumentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAiKnowledgeDocumentModifyModel : AopObject
    {
        /// <summary>
        /// 文档的id，需要和知识库id对应
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }

        /// <summary>
        /// 上传后的文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 知识库的id
        /// </summary>
        [XmlElement("knowledge_base_id")]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// OVERWRITE：覆盖更新； UPSERT：增量更新
        /// </summary>
        [XmlElement("update_mode")]
        public string UpdateMode { get; set; }
    }
}
