using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPrivacyAuditQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPrivacyAuditQueryResponse : AopResponse
    {
        /// <summary>
        /// 隐私政策审批状态 INIT: 未填写， AUDITING：审核中. PASS：通过， REJECT：驳回
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
