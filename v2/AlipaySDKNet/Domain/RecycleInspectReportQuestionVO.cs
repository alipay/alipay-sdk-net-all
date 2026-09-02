using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectReportQuestionVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectReportQuestionVO : AopObject
    {
        /// <summary>
        /// 问题编码
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }

        /// <summary>
        /// 问卷名称
        /// </summary>
        [XmlElement("question_name")]
        public string QuestionName { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 质检报告问题答案列表
        /// </summary>
        [XmlArray("report_answer_list")]
        [XmlArrayItem("recycle_inspect_report_answer_v_o")]
        public List<RecycleInspectReportAnswerVO> ReportAnswerList { get; set; }

        /// <summary>
        /// 问卷类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
