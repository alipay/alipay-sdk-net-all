using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuditResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuditResultInfo : AopObject
    {
        /// <summary>
        /// 审核驳回的原因
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审核结果 SUBMIT：审核中 APPROVE：审核通过 REJECT：审核驳回
        /// </summary>
        [XmlElement("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 审核类型 UNIFY_ACCESS_CHECK：统一接入平台审核
        /// </summary>
        [XmlElement("audit_type")]
        public string AuditType { get; set; }
    }
}
