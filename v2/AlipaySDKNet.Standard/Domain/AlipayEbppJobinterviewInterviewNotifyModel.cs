using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJobinterviewInterviewNotifyModel : AopObject
    {
        /// <summary>
        /// 人工审核 AI 面试结果原因，自由文本，不传为空
        /// </summary>
        [XmlElement("ai_interview_review_reason")]
        public string AiInterviewReviewReason { get; set; }

        /// <summary>
        /// 人工审核 AI 面试结果,PASSED/REJECTED/PENDING;null = 未知/未审核;非空时同样限这三个值
        /// </summary>
        [XmlElement("ai_interview_review_result")]
        public string AiInterviewReviewResult { get; set; }

        /// <summary>
        /// 候选人唯一ID（即创建会话时下发的 candidateId），空则报"候选人ID不能为空"
        /// </summary>
        [XmlElement("candidate_id")]
        public string CandidateId { get; set; }

        /// <summary>
        /// 人工面试结果原因，自由文本，不传为空
        /// </summary>
        [XmlElement("manual_interview_reason")]
        public string ManualInterviewReason { get; set; }

        /// <summary>
        /// 人工面试结果，仅支持 PASSED(通过)/REJECTED(拒绝)/PENDING(待定)，非法值直接拦截
        /// </summary>
        [XmlElement("manual_interview_result")]
        public string ManualInterviewResult { get; set; }

        /// <summary>
        /// 租户ID，接入方统一租户标识，空则报"租户ID不能为空"
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
