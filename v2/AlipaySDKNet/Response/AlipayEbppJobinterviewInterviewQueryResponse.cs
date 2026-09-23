using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewQueryResponse.
    /// </summary>
    public class AlipayEbppJobinterviewInterviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 候选人基本信息
        /// </summary>
        [XmlElement("basic_info")]
        public BasicInfo BasicInfo { get; set; }

        /// <summary>
        /// 候选人唯一 ID
        /// </summary>
        [XmlElement("candidate_id")]
        public string CandidateId { get; set; }

        /// <summary>
        /// 胜任力评估详情
        /// </summary>
        [XmlElement("competency_details")]
        public CompetencyDetails CompetencyDetails { get; set; }

        /// <summary>
        /// 综合评估
        /// </summary>
        [XmlElement("comprehensive_evaluation")]
        public ComprehensiveEvaluation ComprehensiveEvaluation { get; set; }

        /// <summary>
        /// 检测详情
        /// </summary>
        [XmlElement("detection_detail")]
        public DetectionDetail DetectionDetail { get; set; }

        /// <summary>
        /// 淘汰机制明细
        /// </summary>
        [XmlElement("elimination_rule_detail")]
        public EliminationRuleDetailItem EliminationRuleDetail { get; set; }

        /// <summary>
        /// 供应商侧候选人唯一标识
        /// </summary>
        [XmlElement("external_candidate_id")]
        public string ExternalCandidateId { get; set; }

        /// <summary>
        /// 发起面试时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("initiate_start_time")]
        public string InitiateStartTime { get; set; }

        /// <summary>
        /// 面试完成作答时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("interview_end_time")]
        public string InterviewEndTime { get; set; }

        /// <summary>
        /// 是否通过（status=FINISHED 时返回）
        /// </summary>
        [XmlElement("interview_qualified")]
        public bool InterviewQualified { get; set; }

        /// <summary>
        /// 面试开始时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("interview_start_time")]
        public string InterviewStartTime { get; set; }

        /// <summary>
        /// 综合评论
        /// </summary>
        [XmlElement("interview_summary")]
        public string InterviewSummary { get; set; }

        /// <summary>
        /// 面试链接（status=IN_PROGRESS 时返回新链接，其余可能为空）
        /// </summary>
        [XmlElement("interview_url")]
        public string InterviewUrl { get; set; }

        /// <summary>
        /// 答题环节详情
        /// </summary>
        [XmlElement("question_details")]
        public QuestionDetails QuestionDetails { get; set; }

        /// <summary>
        /// 面试报告生成时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("report_generation_time")]
        public string ReportGenerationTime { get; set; }

        /// <summary>
        /// 报告链接(status=COMPLETED 时返回)
        /// </summary>
        [XmlElement("report_url_list")]
        public ReportUrlItem ReportUrlList { get; set; }

        /// <summary>
        /// 报告链接过期时间（yyyy-MM-dd HH:mm:ss，仅 FINISHED 且报告链接就绪时返回）
        /// </summary>
        [XmlElement("room_expire_time")]
        public string RoomExpireTime { get; set; }

        /// <summary>
        /// 得分（status=FINISHED 时返回，0-100）
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 面试状态（对外 6 态：REGISTERED/OPENED/IN_PROGRESS/SUBMITTED/SCORING/FINISHED/CANCELED/NOT_CREATED）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
