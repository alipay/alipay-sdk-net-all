using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiShopMallAuditQueryResponse.
    /// </summary>
    public class KoubeiShopMallAuditQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 工单审核状态：AUDITING 审核中，SUCCESS 通过，REJECTED 拒绝
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }
    }
}
