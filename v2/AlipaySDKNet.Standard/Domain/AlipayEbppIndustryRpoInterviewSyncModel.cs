using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRpoInterviewSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRpoInterviewSyncModel : AopObject
    {
        /// <summary>
        /// 候选人面试评估摘要
        /// </summary>
        [XmlElement("assessment_digest")]
        public string AssessmentDigest { get; set; }

        /// <summary>
        /// 候选人面试评估结果
        /// </summary>
        [XmlElement("assessment_result")]
        public string AssessmentResult { get; set; }

        /// <summary>
        /// 面试完成的状态
        /// </summary>
        [XmlElement("completed_status")]
        public string CompletedStatus { get; set; }

        /// <summary>
        /// 候选人完成面试时间
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// 候选人面试时长，最大24小时，单位：秒
        /// </summary>
        [XmlElement("interview_duration")]
        public long InterviewDuration { get; set; }

        /// <summary>
        /// 候选人面试场次支付宝单号
        /// </summary>
        [XmlElement("interview_no")]
        public string InterviewNo { get; set; }

        /// <summary>
        /// 候选人面试综合得分，0-100之间数值
        /// </summary>
        [XmlElement("interview_score")]
        public string InterviewScore { get; set; }

        /// <summary>
        /// 候选人面试状态
        /// </summary>
        [XmlElement("interview_status")]
        public string InterviewStatus { get; set; }

        /// <summary>
        /// 候选人面试出报告时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 候选人面试报告链接url
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }
    }
}
