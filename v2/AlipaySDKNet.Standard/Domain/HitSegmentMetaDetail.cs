using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HitSegmentMetaDetail Data Structure.
    /// </summary>
    [Serializable]
    public class HitSegmentMetaDetail : AopObject
    {
        /// <summary>
        /// 应用数据ID
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }

        /// <summary>
        /// 应用数据名称
        /// </summary>
        [XmlElement("document_name")]
        public string DocumentName { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("knowledge_base_id")]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// 分片ID
        /// </summary>
        [XmlElement("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 分片位置
        /// </summary>
        [XmlElement("segment_position")]
        public long SegmentPosition { get; set; }
    }
}
