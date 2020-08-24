using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenPreorderCreateModel : AopObject
    {
        /// <summary>
        /// ISV机构信息
        /// </summary>
        [XmlElement("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 付款信息
        /// </summary>
        [XmlElement("payment_info")]
        public TuitionISVRequestPaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 学生信息
        /// </summary>
        [XmlElement("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
