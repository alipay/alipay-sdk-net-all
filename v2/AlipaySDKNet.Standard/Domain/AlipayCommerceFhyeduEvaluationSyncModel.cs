using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFhyeduEvaluationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFhyeduEvaluationSyncModel : AopObject
    {
        /// <summary>
        /// 课后点评内容
        /// </summary>
        [XmlElement("assessment")]
        public string Assessment { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 点评id
        /// </summary>
        [XmlElement("evaluation_id")]
        public string EvaluationId { get; set; }

        /// <summary>
        /// 点评时间
        /// </summary>
        [XmlElement("evaluation_time")]
        public string EvaluationTime { get; set; }

        /// <summary>
        /// 点评人
        /// </summary>
        [XmlElement("evaluator")]
        public string Evaluator { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 课次id
        /// </summary>
        [XmlElement("sched_id")]
        public string SchedId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("score_list")]
        [XmlArrayItem("edu_assessment_score")]
        public List<EduAssessmentScore> ScoreList { get; set; }

        /// <summary>
        /// 学员id
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
