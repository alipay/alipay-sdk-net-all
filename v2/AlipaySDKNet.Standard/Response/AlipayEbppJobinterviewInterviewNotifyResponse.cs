using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewNotifyResponse.
    /// </summary>
    public class AlipayEbppJobinterviewInterviewNotifyResponse : AopResponse
    {
        /// <summary>
        /// 候选人唯一ID（即创建会话时下发的 candidateId），空则报"候选人ID不能为空"
        /// </summary>
        [XmlElement("candidate_id")]
        public bool CandidateId { get; set; }

        /// <summary>
        /// 人工面试结果，仅支持 PASSED(通过)/REJECTED(拒绝)/PENDING(待定)，非法值直接拦截
        /// </summary>
        [XmlElement("manual_interview_result")]
        public string ManualInterviewResult { get; set; }
    }
}
