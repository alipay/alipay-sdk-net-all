using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendDetail : AopObject
    {
        /// <summary>
        /// 知识点id
        /// </summary>
        [XmlElement("knowledge_id")]
        public long KnowledgeId { get; set; }

        /// <summary>
        /// 知识库id
        /// </summary>
        [XmlElement("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
