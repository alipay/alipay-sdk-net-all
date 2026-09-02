using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentAuditQueryResponse.
    /// </summary>
    public class AlipayOpenAgentAuditQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前审核单状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 核驳回时的原因，非驳回为空
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
