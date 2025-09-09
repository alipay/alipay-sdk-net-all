using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerKnowledgeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerKnowledgeDetail : AopObject
    {
        /// <summary>
        /// 知识点内容
        /// </summary>
        [XmlElement("knowledge_content")]
        public string KnowledgeContent { get; set; }

        /// <summary>
        /// 知识点id
        /// </summary>
        [XmlElement("knowledge_id")]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        [XmlElement("knowledge_title")]
        public string KnowledgeTitle { get; set; }

        /// <summary>
        /// 知识点返回类型。枚举值对应如下 RICH_TEXT:富文本类型 MARKDOWN:markdown类型 JSON:json字符串类型
        /// </summary>
        [XmlElement("knowledge_type")]
        public string KnowledgeType { get; set; }
    }
}
