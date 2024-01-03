using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DocumentKnowledgeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DocumentKnowledgeDetail : AopObject
    {
        /// <summary>
        /// 文档答案
        /// </summary>
        [XmlElement("document_answer")]
        public string DocumentAnswer { get; set; }

        /// <summary>
        /// 关联的文档片段
        /// </summary>
        [XmlArray("related_document_fragments")]
        [XmlArrayItem("related_document_fragments")]
        public List<RelatedDocumentFragments> RelatedDocumentFragments { get; set; }
    }
}
