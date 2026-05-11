using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceQueryCouponResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceQueryCouponResponseDTO : AopObject
    {
        /// <summary>
        /// 审批状态
        /// </summary>
        [XmlElement("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 券申请id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 券申请id
        /// </summary>
        [XmlElement("process_url")]
        public string ProcessUrl { get; set; }
    }
}
