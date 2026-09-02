using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentAuditSubmitResponse.
    /// </summary>
    public class AlipayOpenAgentAuditSubmitResponse : AopResponse
    {
        /// <summary>
        /// 修改审核单号，触发审核时返回，可直接查
        /// </summary>
        [XmlElement("audit_id")]
        public string AuditId { get; set; }
    }
}
