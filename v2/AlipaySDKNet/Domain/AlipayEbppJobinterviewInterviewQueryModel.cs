using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJobinterviewInterviewQueryModel : AopObject
    {
        /// <summary>
        /// 候选人唯一ID（即创建会话时下发的 candidateId），空则报"候选人ID不能为空"
        /// </summary>
        [XmlElement("candidate_id")]
        public string CandidateId { get; set; }

        /// <summary>
        /// 租户ID，接入方统一租户标识，空则报"租户ID不能为空"
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
