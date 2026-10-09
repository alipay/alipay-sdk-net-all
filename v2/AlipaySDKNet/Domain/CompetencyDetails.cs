using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompetencyDetails Data Structure.
    /// </summary>
    [Serializable]
    public class CompetencyDetails : AopObject
    {
        /// <summary>
        /// 考察维度名称
        /// </summary>
        [XmlElement("competency_item")]
        public string CompetencyItem { get; set; }

        /// <summary>
        /// 等级标签
        /// </summary>
        [XmlElement("competency_level_tag")]
        public string CompetencyLevelTag { get; set; }

        /// <summary>
        /// 维度总结
        /// </summary>
        [XmlElement("competency_summary")]
        public string CompetencySummary { get; set; }

        /// <summary>
        /// 分值占比
        /// </summary>
        [XmlElement("competency_weight")]
        public string CompetencyWeight { get; set; }

        /// <summary>
        /// 关联题目数
        /// </summary>
        [XmlElement("question_count")]
        public string QuestionCount { get; set; }

        /// <summary>
        /// 维度得分（0-100）
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
