using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentAgentTicketConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentAgentTicketConfirmModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 指派记录ID，来源于派单通知中的 assignment_id
        /// </summary>
        [XmlElement("assignment_id")]
        public string AssignmentId { get; set; }

        /// <summary>
        /// 执行结果，action 为 REJECT 或 FAIL 时必填
        /// </summary>
        [XmlElement("result")]
        public DisResInfo Result { get; set; }
    }
}
