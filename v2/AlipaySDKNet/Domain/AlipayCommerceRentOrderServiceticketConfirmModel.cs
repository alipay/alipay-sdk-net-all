using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderServiceticketConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderServiceticketConfirmModel : AopObject
    {
        /// <summary>
        /// 补充描述
        /// </summary>
        [XmlElement("additional_description")]
        public string AdditionalDescription { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 操作原因
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 服务单ID
        /// </summary>
        [XmlElement("service_ticket_id")]
        public string ServiceTicketId { get; set; }
    }
}
