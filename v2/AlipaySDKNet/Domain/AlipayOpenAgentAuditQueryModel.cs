using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentAuditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentAuditQueryModel : AopObject
    {
        /// <summary>
        /// 智能体唯一标识
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// alipay.open.agent.audit.submit 返回的审核单号
        /// </summary>
        [XmlElement("audit_id")]
        public string AuditId { get; set; }
    }
}
