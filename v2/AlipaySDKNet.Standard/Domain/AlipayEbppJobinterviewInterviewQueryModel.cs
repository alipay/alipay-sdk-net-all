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
        /// 候选人唯一ID（三个ID必填一个：外部候选人ID / 身份证ID / 候选人唯一ID）
        /// </summary>
        [XmlElement("candidate_id")]
        public string CandidateId { get; set; }

        /// <summary>
        /// 外部候选人ID（三个ID必填一个：外部候选人ID / 身份证ID / 候选人唯一ID）
        /// </summary>
        [XmlElement("external_candidate_id")]
        public string ExternalCandidateId { get; set; }

        /// <summary>
        /// 身份证ID（三个ID必填一个：外部候选人ID / 身份证ID / 候选人唯一ID）
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 面试间ID
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 租户ID，接入方统一租户标识，空则报"租户ID不能为空"
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
