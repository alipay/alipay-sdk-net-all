using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneClaimOverduePreconsultResponse.
    /// </summary>
    public class AlipayInsSceneClaimOverduePreconsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 业务受理流水
        /// </summary>
        [XmlElement("overdue_pre_consult_flow_id")]
        public string OverduePreConsultFlowId { get; set; }

        /// <summary>
        /// 不准入原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
