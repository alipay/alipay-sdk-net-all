using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderStatusData Data Structure.
    /// </summary>
    [Serializable]
    public class OrderStatusData : AopObject
    {
        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
