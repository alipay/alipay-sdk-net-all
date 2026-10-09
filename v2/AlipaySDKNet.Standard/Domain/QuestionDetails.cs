using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuestionDetails Data Structure.
    /// </summary>
    [Serializable]
    public class QuestionDetails : AopObject
    {
        /// <summary>
        /// AI 点评
        /// </summary>
        [XmlElement("ai_comment")]
        public string AiComment { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("competency_dimensions")]
        [XmlArrayItem("string")]
        public List<string> CompetencyDimensions { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [XmlElement("detect_result")]
        public string DetectResult { get; set; }

        /// <summary>
        /// 淘汰规则结论：PASS / NOT_PASS / PENDING
        /// </summary>
        [XmlElement("elimination_rule_result")]
        public string EliminationRuleResult { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("follow_questions")]
        [XmlArrayItem("follow_questions")]
        public List<FollowQuestions> FollowQuestions { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("options")]
        public List<Options> Options { get; set; }

        /// <summary>
        /// 题目序号
        /// </summary>
        [XmlElement("question_no")]
        public string QuestionNo { get; set; }

        /// <summary>
        /// 题目分值
        /// </summary>
        [XmlElement("question_score")]
        public string QuestionScore { get; set; }

        /// <summary>
        /// 题目标题
        /// </summary>
        [XmlElement("question_title")]
        public string QuestionTitle { get; set; }

        /// <summary>
        /// 题目类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 题型编码
        /// </summary>
        [XmlElement("type_code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// 候选人选择结果
        /// </summary>
        [XmlElement("user_answer")]
        public string UserAnswer { get; set; }

        /// <summary>
        /// 候选人得分（默认十分制），与题目分值（满分）同量纲，非固定百分制
        /// </summary>
        [XmlElement("user_score")]
        public string UserScore { get; set; }
    }
}
