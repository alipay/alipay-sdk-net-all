using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobotAnswer Data Structure.
    /// </summary>
    [Serializable]
    public class RobotAnswer : AopObject
    {
        /// <summary>
        /// 文档知识
        /// </summary>
        [XmlElement("document_knowledge")]
        public DocumentKnowledgeDetail DocumentKnowledge { get; set; }

        /// <summary>
        /// 多轮问答内容
        /// </summary>
        [XmlElement("dst")]
        public DstDetail Dst { get; set; }

        /// <summary>
        /// 知识点
        /// </summary>
        [XmlElement("knowledge")]
        public KnowledgeDetail Knowledge { get; set; }

        /// <summary>
        /// 推荐知识点
        /// </summary>
        [XmlArray("recommends")]
        [XmlArrayItem("recommend_detail")]
        public List<RecommendDetail> Recommends { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("text")]
        public TextDetail Text { get; set; }
    }
}
