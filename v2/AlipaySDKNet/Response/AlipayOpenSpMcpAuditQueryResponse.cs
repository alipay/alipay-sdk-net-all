using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpAuditQueryResponse.
    /// </summary>
    public class AlipayOpenSpMcpAuditQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核结果：true-通过, false-未通过
        /// </summary>
        [XmlElement("audit_result")]
        public bool AuditResult { get; set; }
    }
}
