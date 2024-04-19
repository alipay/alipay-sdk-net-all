using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KnowledgeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KnowledgeDetail : AopObject
    {
        /// <summary>
        /// 附件列表
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("attachment_detail_info")]
        public List<AttachmentDetailInfo> Attachments { get; set; }

        /// <summary>
        /// 知识点内容（含HTML）
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

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
