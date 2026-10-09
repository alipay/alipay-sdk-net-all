using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComprehensiveEvaluation Data Structure.
    /// </summary>
    [Serializable]
    public class ComprehensiveEvaluation : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("abnormal_tags")]
        [XmlArrayItem("string")]
        public List<string> AbnormalTags { get; set; }

        /// <summary>
        /// 否 淘汰规则整体结论：PASS / NOT_PASS / PENDING
        /// </summary>
        [XmlElement("elimination_rule_result")]
        public string EliminationRuleResult { get; set; }

        /// <summary>
        /// 面试结果
        /// </summary>
        [XmlElement("interview_result")]
        public string InterviewResult { get; set; }

        /// <summary>
        /// AI面试总结
        /// </summary>
        [XmlElement("interview_summary")]
        public string InterviewSummary { get; set; }

        /// <summary>
        /// 推荐标签（按通过阈值与得分计算）
        /// </summary>
        [XmlElement("recommend_tag")]
        public string RecommendTag { get; set; }
    }
}
