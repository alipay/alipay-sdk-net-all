using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcApprovalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcApprovalQueryModel : AopObject
    {
        /// <summary>
        /// 审批单唯一ID，用于唯一标识一条审批单记录
        /// </summary>
        [XmlElement("approval_id")]
        public string ApprovalId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部平台审批单id
        /// </summary>
        [XmlElement("platform_approval_id")]
        public string PlatformApprovalId { get; set; }
    }
}
