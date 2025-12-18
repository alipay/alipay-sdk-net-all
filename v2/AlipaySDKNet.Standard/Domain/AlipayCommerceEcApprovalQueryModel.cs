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
        /// 企业码申请单单唯一ID
        /// </summary>
        [XmlElement("approval_id")]
        public string ApprovalId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部平台申请单id
        /// </summary>
        [XmlElement("platform_approval_id")]
        public string PlatformApprovalId { get; set; }
    }
}
