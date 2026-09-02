using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHmAssessmentRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHmAssessmentRecord : AopObject
    {
        /// <summary>
        /// 答案列表Json
        /// </summary>
        [XmlElement("answers_json")]
        public string AnswersJson { get; set; }

        /// <summary>
        /// 评估报告 jsonarray
        /// </summary>
        [XmlElement("assessment_detail")]
        public string AssessmentDetail { get; set; }

        /// <summary>
        /// 用户测量表业务ID
        /// </summary>
        [XmlElement("assessment_id")]
        public string AssessmentId { get; set; }

        /// <summary>
        /// 分数评级
        /// </summary>
        [XmlElement("assessment_level")]
        public string AssessmentLevel { get; set; }

        /// <summary>
        /// 量表名称
        /// </summary>
        [XmlElement("assessment_name")]
        public string AssessmentName { get; set; }

        /// <summary>
        /// 用户测量记录表业务ID
        /// </summary>
        [XmlElement("assessment_record_id")]
        public string AssessmentRecordId { get; set; }

        /// <summary>
        /// 评估得分
        /// </summary>
        [XmlElement("assessment_score")]
        public string AssessmentScore { get; set; }

        /// <summary>
        /// 评估结果
        /// </summary>
        [XmlElement("assessment_summary")]
        public string AssessmentSummary { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
