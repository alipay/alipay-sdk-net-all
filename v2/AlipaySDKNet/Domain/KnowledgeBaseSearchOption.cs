using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KnowledgeBaseSearchOption Data Structure.
    /// </summary>
    [Serializable]
    public class KnowledgeBaseSearchOption : AopObject
    {
        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("knowledge_base_id")]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("legacy_pre_filters")]
        [XmlArrayItem("legacy_pre_filter_detail")]
        public List<LegacyPreFilterDetail> LegacyPreFilters { get; set; }
    }
}
